using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.input
{
    class InputCsv : IoadInput //for build process the csv input files
    {

        public List<string[]>? load(string fileName)
        {
            try
            {
                string folderPath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "modelbuild", fileName));
                string[] allRows = File.ReadAllLines(folderPath);

                List<string[]> rows = new List<string[]>();
                foreach (string row in allRows)
                {
                    string[] rowSplited = row.Split();
                    rows.Add(rowSplited);
                }
                return rows;
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("ERORR: File not found");
                return null;
            }

            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string GetLabelName(string[] allRows)
        {
            string[] colmos = allRows;
            string label = colmos[0].Split()[^1];
            return label;
        }

        public List<Dictionary<string, string>> loadRows(List<string[]> allRows)
        {
            string[] coloms = allRows[0];
            
            
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            allRows.RemoveAt(0);

            for(int j = 0;j < allRows.Count; j++)
            {
                Dictionary<string, string> row = new Dictionary<string, string>();
                for (int i = 0; i < coloms.Length; i++)
                {
                    
                    row.Add(coloms[i], allRows[j][i]);
                    if (i == coloms.Length - 1)
                    rows.Add(row);
                    
                }
                
            }

            return rows;
        }

    }
}
