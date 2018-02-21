using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemPrograming._2.Processes
{
    class Program
    {

        static void Main(string[] args)
        {

            #region GetProcesses

            //Process[] allProcesses = Process.GetProcesses();
            //foreach (Process item in allProcesses)
            //{
            //    Console.WriteLine(item.ProcessName);
            //}
            //Console.ReadLine();

            #endregion

            #region PowerShellToTXT

            //ProcessStartInfo processStartInfo = new ProcessStartInfo()
            //{
            //    FileName = "powershell",
            //    Arguments = "ls",
            //    RedirectStandardOutput = true,
            //    UseShellExecute = false,
            //};

            //AppDomain domain = AppDomain.CurrentDomain;
            //using (var process = Process.Start(processStartInfo))
            //{
            //    using (StreamReader st = process.StandardOutput)
            //    {
            //        File.AppendAllText(domain.BaseDirectory + @"\a.txt", st.ReadToEnd());
            //    }

            //    Process.Start(processStartInfo);
            //}
            #endregion


            #region ProcessorLoadCounter

            //PerformanceCounter performanceCounter = new PerformanceCounter("Process", "% Processor Time", "explorer", true);
            //while (true)
            //{
            //    Console.WriteLine(performanceCounter.NextValue() / Environment.ProcessorCount);
            //    Thread.Sleep(250);
            //}

            #endregion

            #region IncludeAssemblyToProject

            //AppDomain domain = AppDomain.CurrentDomain;
            //foreach (var item in domain.GetAssemblies())
            //{
            //    Console.WriteLine(item.FullName);
            //    foreach (var type in item.GetTypes())
            //    {
            //        Console.WriteLine(type.FullName);
            //    }
            //}
            //Console.WriteLine();

            //domain.Load(new AssemblyName("TestApp"));



            //foreach (var item in domain.GetAssemblies())
            //{
            //    foreach (var type in item.GetTypes().Where(p => p.FullName.Contains("TestApp")))
            //    {
            //        Console.WriteLine(type.FullName);
            //    }

            //}

            #endregion

            AppDomain domain = AppDomain.CurrentDomain;
            string pathToAssembly = domain.BaseDirectory + "TestApp.exe";

            Assembly domainAssembly = Assembly.LoadFrom(pathToAssembly);
            Type secretUserType = domainAssembly.GetType("TestApp.SecretUser");

            ConstructorInfo constructor = secretUserType.GetConstructor(Type.EmptyTypes);
            object secretUserObject = constructor.Invoke(new object[] { });




        }

    }
}
