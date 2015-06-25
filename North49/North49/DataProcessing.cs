using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North49
{
    class DataProcessing
    {
        public static void RemoveARecord(string filePath, int rowIndex)
        {
            List<String> lines = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(rowIndex);

                sr.Close();
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(String.Join(Environment.NewLine, lines.ToArray()));
                sw.Flush();
                sw.Close();
            }
        }

        public static void AddARecord(string filePath, string newLine)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.Write(String.Join(Environment.NewLine, newLine));
                sw.Flush();
                sw.Close();
            }
        }

        public static List<String> FilterARecord(string filePath, string searchString)
        {
            List<String> lines = new List<string>();
            List<String> results = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                foreach(string record in lines)
                {
                    if (record.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        results.Add(record);
                    }
                }
                sr.Close();
            }
            return results;
        }
    }
}
