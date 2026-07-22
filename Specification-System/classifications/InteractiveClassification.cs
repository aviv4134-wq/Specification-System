using Specification_System.input;
using Specification_System.modelbuild;
using Specification_System.output;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.classifications
{
     class InteractiveClassification : Classification
    {
        public InteractiveClassification (Ioutput output, ModelBuilding builder) : base(output, builder)
        { }

        public void Execute(List<Dictionary<string, string>> allRows, Tuple<List<string>, Dictionary<string, double>, Dictionary<Tuple<string, string, string>, double>, Dictionary<Tuple<string, string>, double>> model) //מקבל מודל אם כול השורות של הקבוץ הבונה כדי להשתמש בדיקט
        {
            
            foreach (Dictionary<string, string> row in allRows)
            {
                string labelResoult = modelBuilder.Predict(model, row);
                
                outputOption.Output(labelResoult);
            }
        }
    }
}
