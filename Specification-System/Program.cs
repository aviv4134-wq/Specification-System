using Specification_System.input;
namespace Specification_System
{
    class Program
    {
        static void Main()
        {
            //ModelBuilding m = new ModelBuilding();
            //m.L();
            InputUser u = new InputUser();
            InputCsv lo = new InputCsv();
            string filePath = "tenisStats.csv";
            List< string[]> rows = lo.load(filePath);
            List<Dictionary<string, string>> rowsUser =  u.LoadDict(rows);
            //foreach (Dictionary<string,string> row in rowsUser ) Console.WriteLine(row["Outlook"]);

        }
    }
}
