using Microsoft.VisualBasic;
using Specification_System.modelbuild;
using Specification_System.output;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.classifications
{
    abstract class Classification
    {
        protected Ioutput outputOption;
        protected ModelBuilding modelBuilder;

        public Classification(Ioutput output, ModelBuilding builder)
        {
            outputOption = output;
            modelBuilder = builder;
        }

         //מקבל מודל אם כול השורות של הקבוץ הבונה כדי להשתמש בדיקט
        
            
        
    }
}
