//using System;
//using System.Collections.Generic;
//using System.Diagnostics.SymbolStore;
//using System.Reflection.Emit;
//using System.Text;

//namespace Specification_System.modelbuild
//{
//    public class ModelBuilding
//    {
//        public void Train(List<Dictionary> rows, string targetColumn)
//        {
//            int n = rows.Count();
//            var labels = rows.Select(row => row[targetColumn]).Distinct();

//            Dictionary<string, double> priors = new Dictionary<string, double>();

//            foreach (string each in labels)
//            {
//                double priors = rows.Where(g => g[targetColumn] == each).Count();
//                priors[each} = count / n;
//            }
//        }
//    }
//}






