using Microsoft.VisualBasic;
using Specification_System.modelbuild;
using Specification_System.output;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Specification_System.classifications
{
    class BatchClassification : Classification
    {

        public BatchClassification(Ioutput output, ModelBuilding builder) : base(output, builder) 
        { }
         public List<Dictionary<string, string>> Execute(List<Dictionary<string, string>> allRows, Tuple<List<string>, Dictionary<string, double>, Dictionary<Tuple<string, string, string>, double>, Dictionary<Tuple<string, string>, double>> model,string label)
        {
            for (int index = 0;index < allRows.Count; index++)
            {
                int rowNumber = index + 1;
                Dictionary<string, string> row  = allRows[index];
                string labelResoult = modelBuilder.Predict(model, row);
               
                row[label] = labelResoult;
                outputOption.Output($"row {rowNumber}:{row.Keys} -> {labelResoult}  ");
            }
            return allRows;
        }
    }    
}
