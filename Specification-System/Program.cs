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
            List< string[]> rows = lo.load();
             lo.loadRows(rows);

        }
    }
}
