﻿// ROHATSU RIFF FRAMEWORK / copyright (c) 2014-2017 rohatsu software studios limited / www.rohatsu.com
using log4net.Config;
using RIFF.Core;
using RIFF.Framework;
using System;
using System.Text;

namespace RIFF
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net.config"));
            var engine = RIFFSection.GetDefaultEngine();
            var config = engine.BuildEngineConfiguration();

            var environment = RFEnvironments.StartConsole(engine.Environment, config, engine.Database, new string[] { engine.Assembly });
            var context = environment.Start();

            var engineConsole = config.Console;
            if (engineConsole != null)
            {
                engineConsole.Initialize(context, config, engine.Database);
            }

            var executor = new RFConsoleExecutor(config, context, engine, engineConsole);
            Console.WriteLine(">>> Loaded engine {0} from {1} in environment {2}", engine?.EngineName, engine?.Assembly, engine.Environment);

            do
            {
                try
                {
                    System.Console.Write("> ");
                    var input = System.Console.ReadLine();
                    executor.ExecuteCommand(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EXCEPTION: {0}", ex.Message);
                }
            } while (!executor._isExiting);

            environment.Stop();
        }

        private static string ReadLine()
        {
            var inputStream = Console.OpenStandardInput(65536);
            var bytes = new byte[65536];
            var outputLength = inputStream.Read(bytes, 0, 65536);
            //Console.WriteLine(outputLength);
            var chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }
    }
}
