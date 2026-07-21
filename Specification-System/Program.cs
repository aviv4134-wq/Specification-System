using Specification_System.input;
namespace Specification_System
{
   class Program
    {
        static void Main()
        {
            //ModelBuilding m = new ModelBuilding();
            //m.L();
            InputCsv lo = new InputCsv();
            string[] rows = lo.load();

            Console.WriteLine(lo.loadRows(rows)[^1]); 
        }
    }
}
