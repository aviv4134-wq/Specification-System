using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.input
{
    class LoadCsv : IoadInput
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

        public List<string> loadRows(string[] allRows)
        {
            List<string> onlyRows = new List<string>();
            for (int i = 1; i < allRows.Length; i++ )
            {
                onlyRows.Add(allRows[i]);
            }
            return onlyRows;



        }

    }
}
