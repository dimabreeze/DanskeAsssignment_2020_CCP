using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_DmitrijKosmakov_Danske
{
    public class App
    {
        private IList<AbstractShape> shapes = null;
        private string outputFilePath = null;

        public App(string inputFilePath, string outputFilePath)
        {
            if (inputFilePath == null)
                throw new ArgumentNullException("[inputFilePath] is null");
            this.outputFilePath = outputFilePath;

            var parsed = ParseFile(inputFilePath);

            this.shapes = ReadRectangles(parsed)
                //.Concat(ReadOvals(parsed))
                //.Concat(ReadTriangles(parsed))
                .OrderBy(r => r.Area)
                .ToList(); // instanciate a list so that we don't depend on input file
        }
        public int run()
        {
            WriteToOutput();
            return 0;
        }
        private IEnumerable<List<double>> ParseFile(string inputFilePath)
        {
            return File.ReadLines(inputFilePath)
                .Select(s =>
                    s.Split(new char[] { ',', '\t' })  // split single line
                    .Select(double.Parse)              // transform each string token to double value
                )
                .Select(e => e.ToList());              // make list of doubles
        }
        private IEnumerable<AbstractShape> ReadRectangles(IEnumerable<List<double>> enumerable)
        {
            return 
                from array_of_doubles in enumerable
                where array_of_doubles[2] >= 0 && array_of_doubles[3] >= 0 // validate
                select new Rectangle(
                    array_of_doubles[0],
                    array_of_doubles[1],
                    array_of_doubles[2],
                    array_of_doubles[3]
                ) as AbstractShape;
        }
        private IEnumerable<AbstractShape> ReadOvals(IEnumerable<List<double>> enumerable)
        {
            throw new NotImplementedException();
        }
        private IEnumerable<AbstractShape> ReadTriangles(IEnumerable<List<double>> enumerable)
        {
            throw new NotImplementedException();
        }
        private void WriteToOutput()
        {
            // Save standard output
            var std_out = Console.Out;

            using (Stream stream = outputFilePath != null
                ? new FileStream(outputFilePath, FileMode.Create)
                : Console.OpenStandardOutput()
                )
            {
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.UTF8);
                Console.SetOut(writer);

                foreach (var shape in shapes)
                    Console.WriteLine(String.Format("{0} => area={1}", shape.ToString(), shape.Area));
                writer.Flush();
            }
            // Restore standard output
            Console.SetOut(std_out);
        }
    }
}
