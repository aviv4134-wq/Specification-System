using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_System.modelbuild
{
     class ModelBuilding
    {
        public void L()
        {
            
            string folderPath = Path.Combine("..", "..", "..", "modelbuild", "tenisStats.csv"); 
            string[] s =  File.ReadAllLines(folderPath);
            string label = s[0].Split()[^1]; //take the first row spliteed an then take the last col
            

            //foreach (string r in s)
            //{ Console.WriteLine(r); }
        } 
    }
}
