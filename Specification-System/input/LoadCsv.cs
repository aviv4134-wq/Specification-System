using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.input
{
    class InputCsv : IoadInput
    {

        public  string[] load()
        {
            string folderPath = Path.Combine("..", "..", "..", "modelbuild", "tenisStats.csv");
            string[] allRows = File.ReadAllLines(folderPath);
            return allRows;
        }

        public string GetLabelName(string[] allRows)
        {
           string[] colmos = allRows;
            string label = colmos[0].Split()[^1];
            return label;
        }

        //public List<Dictionary<string, string>> loadRows(string[] allRows)
        //{
            
        //    List<Dictionary<string,string>> rows = new List<Dictionary<string,string>>();
        //    foreach (string col in allRows)
        //    {
        //        Dictionary<string, string> row = new Dictionary<string, string>();
        //        row.Add(col, "");
                
        //    }
            
        //    for (int i = 1; i < allRows.Length; i++ )
        //    {
        //        onlyRows.Add(allRows[i]);
        //    }
        //    return onlyRows;



        //}

    }
}
