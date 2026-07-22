using Specification_System.input;
using Specification_System.output;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.classifications
{
     class InteractiveClassification : Classification
    {
        private Consule interactive = new Consule();

        public void Execute(List<Dictionary<string, string>> allRows,Tuple<string> model) //מקבל מודל אם כול השורות של הקבוץ הבונה כדי להשתמש בדיקט
        {
            

            foreach (Dictionary<string, string> row in allRows)
            {
                
            }
        }
    }
}
