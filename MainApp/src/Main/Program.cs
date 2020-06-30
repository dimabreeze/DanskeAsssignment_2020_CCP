using System;

namespace Assignment_DmitrijKosmakov_Danske
{
    class Program
    {
        private const string usageText = "Usage: [input file path] [output file path (optional)]";
        static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine(usageText);
                return 1;
            }

            string input = args[0];
            string output = args.Length > 1 ? args[1] : null;
            try
            {
                return new App(input, output).run();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(String.Format("Unexpected program termination - {0}", e.ToString()));
                return 1;
            }
        }
    }
}
