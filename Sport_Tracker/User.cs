using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Tracker
{
    class User
    {
        /*Function implements the list measurements*/
        public void AddWeight(float weight)
        {
            string fileName = @"D:\test.txt";
            FileStream stream = null;
            try
            {
                // Create a FileStream with mode CreateNew  
                stream = new FileStream(fileName, FileMode.Append);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write(weight);
                    writer.Write(" ");
                    writer.Write(DateTime.Today.ToString("d"));
                    writer.WriteLine(" ");
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
            // Read a file  
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            Console.ReadKey();
        }

        public void WriteWeight(List<Measurement> Measurements)
        {
            string fileName = @"D:\test.txt";
            FileStream stream = null;
            try
            {
                // Create a FileStream with mode CreateNew  
                stream = new FileStream(fileName, FileMode.Append);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(Measurements[0]);
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
            // Read a file  
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            Console.ReadKey();
        }

        public User()
        {

        }
    }
}
