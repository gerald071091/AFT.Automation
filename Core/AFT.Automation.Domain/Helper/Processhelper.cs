using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AFT.Automation.Domain.Helper
{
    public static class Processhelper
    {

        /// <summary>
        /// Ends the selected processes activity in window process provided by list<string>
        /// </summary>
        /// <param name="listProcess"></param>
        public static void EndSession(this Process prc, params string[] listProcess)
        {
            foreach (string process in listProcess)
            {
                foreach (Process proc in GetSpecificProcess(process))
                {
                    proc.Kill();
                }
            }
        }

        /// <summary>
        /// Ends the selected processes activity in window process provided by string list
        /// </summary>
        /// <param name="args"></param>
        public static void EndSession(this Process prc, string args)
        {
            if (args.Contains(','))
            {
                List<string> listProcess = args.Split(',').ToList();

                foreach (string process in listProcess)
                {
                    foreach (Process proc in GetSpecificProcess(process))
                    {
                        proc.Kill();
                    }
                }
            }

            foreach (var proc in GetSpecificProcess(args))
            {
                proc.Kill();
            }
        }

		/// <summary>
		/// Removes the files older than 1 day to prevent folder size enlargement
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="dirPath"></param>
		public static void RemoveDayOldFile(this Process proc, string dirPath)
		{
			DirectoryInfo dir = new DirectoryInfo(dirPath);
			if (Directory.Exists(dirPath))
			{
				foreach (FileInfo file in dir.EnumerateFiles())
				{
					try
					{
						if (file.CreationTime.AddDays(1) < DateTime.Now)
						{
							file.Delete();
						}
					}
					catch (Exception ex)
					{
						throw new FileNotFoundException(ex.Message);
					}
				}
			}
		}

		private static IEnumerable<Process> GetSpecificProcess(string process)
        {
            return Process.GetProcesses().Where(pr => pr.ProcessName == process.Trim());
        }
    }
}
