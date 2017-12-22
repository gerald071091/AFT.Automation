using System;
using System.Diagnostics;
using System.IO;

namespace AFT.Automation.GridHub
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Grid Hub Port: ");
			var hub = Console.ReadLine();

			Console.Write("Grid Hub host: ");
			var host = Console.ReadLine();

			SetUpGridHubPort(hub, host);
		}

		private static void SetUpGridHubPort(string hubPort, string hostAddress)
		{
			int num;
			var appDomain = AppDomain.CurrentDomain;
			var basePath = appDomain.RelativeSearchPath ?? appDomain.BaseDirectory;
			var serverPath = Path.Combine(basePath, "Server", "selenium-server-standalone-3.0.1.jar");
			var configPath = Path.Combine(basePath, "Configuration", "ServerConfig.json");

			if (!string.IsNullOrEmpty(hubPort) && int.TryParse(hubPort, out num))
			{
				try
				{
					var gridHubArgs = string.Format(@"/c D: & java -jar {2} -role hub -hubConfig {3} -host {1} -port {0}", hubPort, hostAddress, serverPath, configPath);
					var cmdPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32", "cmd.exe");
					ExecuteProcess(cmdPath, gridHubArgs);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			else
			{
				Console.WriteLine("Please input valid hub port number");
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
