using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inköpslista = new List<string>();
            inköpslista.Add("Sill");
            inköpslista.Add("Potatis");
            inköpslista.Add("Gräslök");
            inköpslista.Add("Gräddfil");
            inköpslista.Add("Lax");
            inköpslista.Add("Räkor");
            inköpslista.Add("Kräftstjärtar");
            inköpslista.Add("Västerbottenpaj");
            inköpslista.Add("Bröd");
            inköpslista.Add("köttbullar");
            inköpslista.Add("Pepparsalami");
            inköpslista.Add("Korv");
            inköpslista.Add("Ägg");
            inköpslista.Add("Rom");

            StreamWriter sw = new StreamWriter("inköpslista.txt");

            foreach (var item in inköpslista)
            {
                sw.WriteLine(item);
            }
            sw.Close();

        }
    }
}
