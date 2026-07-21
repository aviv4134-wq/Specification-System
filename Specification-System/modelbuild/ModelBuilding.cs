using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Reflection.Emit;
using System.Text;

namespace Specification_System.modelbuild
{
    public class ModelBuilding
    {
        public Tuple<List<string>, Dictionary<string, double>, Dictionary<Tuple<string, string, string>, double>, Dictionary<Tuple<string, string>, double>>
            Train(List<Dictionary<string, string>> rows, string targetColumn)
            {
            
            int n = rows.Count();
            var labels = rows.Select(row => row[targetColumn]).Distinct().ToList();
            //A
            Dictionary<string, double> priors = new Dictionary<string, double>();

            foreach (string each in labels)
            {
                double count = rows.Where(g => g[targetColumn]?.ToString() == each).Count();

                priors[each] = count / n;
            }
            //B
            Dictionary<Tuple<string, string, string>, double> cond = new Dictionary<Tuple<string, string, string>, double>();
            Dictionary<Tuple<string, string>, double> unseen = new Dictionary<Tuple<string, string>, double>();

            foreach(string label in labels)
            {
                var labelRows = rows.Where(row => row[targetColumn]?.ToString() == label).ToList();
                int countLabelRows = labelRows.Count;

                var featureColumns = rows.First().Keys.Where(col => col != targetColumn);

                foreach (string feature in featureColumns)
                {
                    var distinctValues = rows.Select(row => row[feature]).Distinct().ToList();
                    int distinctCount = distinctValues.Count();

                    foreach (string val in distinctValues)
                    {
                        int matchCount = labelRows.Count(row => row[feature]?.ToString() == val);
                        double probability = (matchCount + 1.0) / (countLabelRows + distinctCount);
                        cond[Tuple.Create(label, feature, val)] = probability;
                        Console.WriteLine(cond);
                    }
                    unseen[Tuple.Create(label, feature)] = 1.0 / (countLabelRows + distinctCount);
                }
            }
            return Tuple.Create(labels, priors, cond, unseen);
        }

    }
    
}







