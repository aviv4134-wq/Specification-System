using Microsoft.VisualBasic;
using Specification_System.modelbuild;
using Specification_System.output;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.classifications
{
    class Classification
    {
         protected Consule consule = new Consule();
         protected ModelBuilding modelBuilder = new ModelBuilding();

        public void Execute(List<Dictionary<string, string>> allRows, Tuple<string> model) //מקבל מודל אם כול השורות של הקבוץ הבונה כדי להשתמש בדיקט
        {
            

            foreach (Dictionary<string, string> row in allRows)
            {

            }
        }
    }
}
