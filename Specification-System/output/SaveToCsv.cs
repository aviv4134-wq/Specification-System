using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Specification_System.output
{
    class SaveToCsv : Ioutput
    {
        public void Output<T>(T data)
        {
            var model = data as List<Dictionary<string, object>>;
            string currentDir = Directory.GetCurrentDirectory();
            string FullPath = Path.Combine(currentDir, "predictions.csv");
            using (var write = new StreamWriter(FullPath))
            {
                string headers = string.Join(",", model[0].Keys); 
                write.WriteLine(headers);
                foreach(var row in model)
                {
                    string r = string.Join(",", row.Values);
                    write.WriteLine(r);

                }

            }
        }
    }
}
