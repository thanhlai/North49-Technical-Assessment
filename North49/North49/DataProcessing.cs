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
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(String.Join(Environment.NewLine, lines.ToArray()));
            }

        }
    }
}
