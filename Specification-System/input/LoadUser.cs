using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.input
{
    class InputUser : IoadInput
    {
        public List<string[]> load(string filePath)
        {
            
            return new List<string[]>();

        }

        public List<Dictionary<string, string>> LoadDict(List<string[]> allRows)
        {
            int FirstRowColom = 1;
            Console.WriteLine($".Model trained on {allRows.Count() - FirstRowColom} rows");
            
            string[] colomsRow = allRows[0];
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();

            bool run = true;
            while (run)
            {
                Dictionary<string, string> row = new Dictionary<string, string>();

                int labelColom = 1; 
                for (int index = 0;index < colomsRow.Length - labelColom; index++)
                {
                    Console.WriteLine($"enter {colomsRow[index]}  : ");
                    string? userField = Console.ReadLine();
                    if (index == 0 && userField.IsWhiteSpace())
                    {
                        run = false;
                        break;
                    }

                    row.Add(colomsRow[index] , userField);
                    
                }
                if (run == false) break;

                rows.Add(row);

            }

            return rows;



        }



    }
}
