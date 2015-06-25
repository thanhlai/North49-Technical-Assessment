using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @author: Thanh Lai
 * @project: North49 Technical Assessment
 * @company: North49 Business Solutions 
 * @supervisor: Michael VanKuipers
 * @date: 24/06/2015
 * @version: 1.0.0
 */
namespace North49
{
    /// <summary>
    /// DataProcessing class: used to add, remove, or search for records
    /// </summary>
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

        public static bool AddARecord(string filePath, string newLine)
        {
            try
            {
                // make sure the ID is unique before saving
                List<String> lines = new List<string>();
                string line;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    sr.Close();
                    foreach (string record in lines)
                    {
                        if (record.Split(',')[0].Equals(newLine.Split(',')[0]))
                        {
                            return false;
                        }
                    }
                }

                // writing to the original file
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.Write(String.Join(Environment.NewLine, newLine));
                    sw.Flush();
                    sw.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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
