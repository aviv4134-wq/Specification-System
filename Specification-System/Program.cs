using Specification_System.classifications;
using Specification_System.input;
using Specification_System.modelbuild;
using Specification_System.output;
namespace Specification_System
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("error no files in runtime");
                return;
            }

            ModelBuilding modelBuilder = new ModelBuilding();      //בניית מודל וגם ביטול המאין במידה והקובץ ריק או יש שגיאה
            InputCsv csvLoader = new InputCsv();
            
            List<string[]>? rawRows = csvLoader.load(args[0]);

            if (rawRows == null) return;

            string labelName = csvLoader.GetLabelName(rawRows);

            List<Dictionary<string, string>> rowsCsv = csvLoader.LoadToDicts(rawRows);

            Tuple<List<string>, Dictionary<string, double>, Dictionary<Tuple<string, string, string>, double>, Dictionary<Tuple<string, string>, double>> model = modelBuilder.Train(rowsCsv, labelName);

            switch (args.Length)
            {
                case 1:
                    {
                        ConsuleShow counsule = new ConsuleShow();
                        InteractiveClassification interactive = new InteractiveClassification(counsule, modelBuilder);
                        InputUser userIn = new InputUser();
                        List < Dictionary<string, string> > userRaws = userIn.LoadToDicts(rawRows);

                        interactive.Execute(userRaws,model);
                        break;

                    }

                case 2:
                    {
                        break;
                    }

                default:
                    {
                        Console.WriteLine("only 1 or 2 argument allowed");
                        break;
                    }
            }







            //m.L();


            InputUser u = new InputUser();
            InputCsv inputCsv = new InputCsv();
            
            List< string[]>? allRows = inputCsv.load("tenisStats.csv");
            if (allRows == null) return;
            string label = inputCsv.GetLabelName(allRows);
            List<Dictionary<string, string>> alldicts = inputCsv.LoadToDicts(allRows); 
            
            
            
            //var model = modelBuilder.Train(alldicts, label);
            Console.WriteLine(alldicts[1]["Outlook"]);
            //modelBuilder.Predict(model, alldicts[1]);
            

        }
    }
}
