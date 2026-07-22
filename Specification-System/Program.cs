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

            InputCsv lo = new InputCsv();
            List< string[]> rows = lo.load();
            var l =  lo.loadRows(rows);
            ModelBuilding a = new ModelBuilding();
            Console.WriteLine("fdvcs");
            var r = a.Train(l, "Play");
            var model = a.Train(l, "Play");
            foreach (var pair in model.Item1)
            {
                Console.WriteLine($"{pair}");
            }


        }
    }
}
