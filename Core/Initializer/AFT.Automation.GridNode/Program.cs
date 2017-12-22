using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AFT.Automation.GridNode
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Grid Hub Port: ");
			var hub = Console.ReadLine();

			Console.Write("Grid Hub host: ");
			var host = Console.ReadLine();

			Console.Write("Node Port: ");
			var node = Console.ReadLine();	

			Console.Write("Browser: ");
			var browser = Console.ReadLine();

			SetUpNodeHubPort(hub, host, node, browser);
		}

		private static void SetUpNodeHubPort(string hub, string host, string node, string browser)
		{
			int num;
			var appDomain = AppDomain.CurrentDomain;
			var basePath = appDomain.RelativeSearchPath ?? appDomain.BaseDirectory;
			var serverPath = Path.Combine(basePath, "Server", "selenium-server-standalone-3.0.1.jar");
			var cmdPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32", "cmd.exe");

			if (!string.IsNullOrEmpty(node) && int.TryParse(node, out num))
			{
				try
				{
					IDictionary<string, Action> InitializeNode = new Dictionary<string, Action>
					{
						{"firefox", () =>
							{
								var firefoxDriverPath = Path.Combine(basePath, "Driver", "geckodriver.exe");
								var firefoxConfigPath = Path.Combine(basePath, "Configuration", "FirefoxNodeConfig.json");
								var gridFirefoxNodeArgs = string.Format(@"/c D: & java -Dwebdriver.gecko.driver={1} -jar {2} -role node -hub http://{5}:{4}/grid/register -nodeConfig {3} -port {0}", 
									node, firefoxDriverPath, serverPath, firefoxConfigPath, hub, host);
								ExecuteProcess(cmdPath, gridFirefoxNodeArgs);
							}
						},

						{"chrome", () =>
							{
								var chromeDriverPath = Path.Combine(basePath, "Driver", "chromedriver.exe");
								var chromeConfigPath = Path.Combine(basePath, "Configuration", "ChromeNodeConfig.json");
								var gridChromeNodeArgs = string.Format(@"/c D: & java -Dwebdriver.chrome.driver={1} -jar {2} -role node -hub http://{5}:{4}/grid/register -nodeConfig {3} -port {0}", 
									node, chromeDriverPath, serverPath, chromeConfigPath, hub, host);
								ExecuteProcess(cmdPath, gridChromeNodeArgs);
							}
						},

						{"ie", () =>
							{
								var ieDriverPath = Path.Combine(basePath, "Driver", "IEDriverServer.exe");
								var ieConfigPath = Path.Combine(basePath, "Configuration", "IENodeConfig.json");
								var gridIENodeArgs = string.Format(@"/c D: & java -Dwebdriver.ie.driver={1} -jar {2} -role node -hub http://{5}:{4}/grid/register -nodeConfig {3} -port {0}", 
									node, ieDriverPath, serverPath, ieConfigPath, hub, host);
								ExecuteProcess(cmdPath, gridIENodeArgs);
							}
						}
					};

					InitializeNode[browser]();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			else
			{
				Console.WriteLine("Please input valid node port number");
			}

		}

		private static void ExecuteProcess(string fileName, string arguments)
		{
			var process = new Process
			{
				StartInfo =
					{
						FileName = fileName,
						Arguments = arguments,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						CreateNoWindow = false
					}
			};

			process.Start();
			Console.WriteLine(process.StandardOutput.ReadToEnd());
		}
	}	
}

