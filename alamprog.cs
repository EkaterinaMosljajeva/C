using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class alamprog
    {
        public static void nzvezda()
        {
            Console.WriteLine("Kordade arv: ");
            int n = int.Parse(Console.ReadLine());
            int[] stars = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} arv: ", i + 1);
                stars[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in stars)
            {
                Console.Write(zvezda(num));
                Console.WriteLine();
            }
        }

        public static string zvezda(int n)
        {
            string var = "";
            for (int i = 0; i < n; i++)
            {
                var += "*";
            }
            return var;
        }

        public static string Kass2(int arv1,int arv2, char tehe)
        {
            System.Data.DataTable table=new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString() + tehe.ToString()+arv2.ToString(),String.Empty));
            j=Math.Round(j,0);
            string vastus = "";
            string nur = "nurr ";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }
            return vastus;
        }

        public static void Kass()
        {
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teha: ");
            string t = Console.ReadLine();
            int n = 0;
            if (t == "+")
            {
                n = a + b;
            }
            else if (t == "-")
            {
                n = a - b;
            }
            else if (t == "*")
            {
                n = a * b;
            }
            else if (t == "/")
            {
                n = a / b;
                //n = Math.Round(n, 1);
            }
            else
            {
                Console.WriteLine("Vale Andmetüüp");
            }
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("nurr ");
                }
            }
            else
            {
                Console.WriteLine("Vastus ei saa olla võrdne või väiksem kui 0");
            }
        }

        public static int Keskmine(int n)
        {
            int a;
            int k=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sisestage {0} arv: ", i+1);
                a = int.Parse(Console.ReadLine());
                k+=a;
            }
            return k / n;
        }

        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }

        public static void Tere(string name)
        {
            Console.WriteLine("Tere {0}", name);
        }
    }
}
