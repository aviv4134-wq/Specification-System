using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Specification_System.classifications
{
    class BatchClassification : Classification
    {
         public List<Dictionary<string, string>> Execute(List<Dictionary<string, string>> allRows, Tuple<List<string>, Dictionary<string, double>, Dictionary<Tuple<string, string, string>, double>, Dictionary<Tuple<string, string>, double>> model,string label)
        {
            for (int index = 0;index < allRows.Count; index++)
            {
                int rowNumber = index + 1;
                Dictionary<string, string> row  = allRows[index];
                string labelResoult = modelBuilder.Predict(model, row);
               
                row[label] = labelResoult;
                consule.Output($"row {rowNumber}:{row.Keys} -> {labelResoult}  ");
            }
            return allRows;
        }
    }    
}
