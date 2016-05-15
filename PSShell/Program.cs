using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;

namespace PSShell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PSShell - rui@deniable.org";
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            string command = null;

            do
            {
                Console.Write("PS > ");
                command = Console.ReadLine();

                try
                {
                    Pipeline pipeline = runspace.CreatePipeline();
                    pipeline.Commands.AddScript(command);
                    pipeline.Commands.Add("Out-String");
                    Collection<PSObject> results = pipeline.Invoke();
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PSObject obj in results)
                    {
                        stringBuilder.AppendLine(obj.ToString());
                    }
                    Console.Write(stringBuilder.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0}", e.Message);
                }
            } while (command != "exit");

            runspace.Close();
            Environment.Exit(0);
        }
    }
}
