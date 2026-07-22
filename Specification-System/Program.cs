using Specification_System.classifications;
using Specification_System.input;
using Specification_System.modelbuild;
namespace Specification_System
{
    class Program
    {
        static void Main()
        {
            //ModelBuilding m = new ModelBuilding();
            //m.L();
            InteractiveClassification c = new InteractiveClassification();

            InputUser u = new InputUser();
            InputCsv inputCsv = new InputCsv();
            
            List< string[]>? allRows = inputCsv.load("tenisStats.csv");
            if (allRows == null) return;
            //string label = inputCsv.GetLabelName(allRows);
            List<Dictionary<string, string>> alldicts = inputCsv.loadRows(allRows); 
            ModelBuilding modelBuilder = new ModelBuilding();
            
            
            //var model = modelBuilder.Train(alldicts, label);
            Console.WriteLine(alldicts[1]["Outlook"]);
            //modelBuilder.Predict(model, alldicts[1]);
            

        }
    }
}
