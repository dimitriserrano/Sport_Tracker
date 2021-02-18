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
            string fileName = @"D:\Weight.txt";
            FileStream stream = null;
            if (!File.Exists(fileName))
            {
                try
                {
                    // Create a FileStream with mode CreateNew  
                    stream = new FileStream(fileName, FileMode.Create);
                    // Create a StreamWriter from FileStream  
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        writer.Write("Le ");
                        writer.Write(DateTime.Today.ToString("d"));
                        writer.Write(" : ");
                        writer.Write(weight);
                        writer.Write("kg");
                        writer.WriteLine(string.Empty);

                    }
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }
            }else
            try
            {
                // Create a FileStream with mode CreateNew  
                stream = new FileStream(fileName, FileMode.Append);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write("Le ");
                    writer.Write(DateTime.Today.ToString("d"));
                    writer.Write(" : ");
                    writer.Write(weight);
                    writer.Write("kg");
                    writer.WriteLine(string.Empty);

                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void ReadWeight()
        {
            string fileName = @"D:\Weight.txt";
            // Read a file  
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                string mots = sr.ReadToEnd();
                Console.WriteLine(string.Empty);
                Console.WriteLine(mots);
            }
            finally
            {
                if (sr != null)
                    sr.Dispose();
            }   
        }

        public User()
        {

        }
    }
}
