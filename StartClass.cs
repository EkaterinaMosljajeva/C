using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//&& - and, || - or
namespace ConsoleApp1
{
    public class StartClass
    {
        public static void Main(string[] args)
        {
            /*Random rnd = new Random();
            int N = rnd.Next(-100, 100);
            int M = rnd.Next(-100, 100);
            int pikkus = 0;
            if (N < 0 && M < 0)
            {
                if (N<M)
                {
                    pikkus = Math.Abs(N) - Math.Abs(M);
                }
                else
                {
                    pikkus = Math.Abs(M) - Math.Abs(N);
                }
            }
            else if (N<0 && M>0)
            {
                pikkus = Math.Abs(N) + M;
            }
            else if (M<0 && N>0)
            {
                pikkus = Math.Abs(M) + N;
            }
            else
            {
                if (M>N)
                {
                    pikkus = M - N;
                }
                else
                {
                    pikkus = N - M;
                }
            }*/
            /*Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int nr = rnd.Next(1, 7);
                Console.WriteLine(nr);
                string paev = "";
                switch (nr)
                {
                    case 1: paev = "Esmaspäev"; break;
                    case 2: paev = "Teisipäev"; break;
                    case 3: paev = "Kolmapäev"; break;
                    case 4: paev = "Neljapäev"; break;
                    case 5: paev = "Reede"; break;
                    case 6: paev = "Laupäev"; break;
                    case 7: paev = "Pühapäev"; break;
                    default:
                        paev = "Tundmatu päev";
                        break;
                }
                Console.WriteLine(paev);
            }
            int j = 0;
            while (j < 10) ;
            {
                Console.WriteLine(paev);
                j++;
            }
            Console.WriteLine(j);
            do
            {
                Console.WriteLine(paev);
            } while (j!=0);
            Console.WriteLine(j);
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-100, 100);
            }
            foreach (var arv in arvud)
            {
                if (arv<0)
                {
                    Console.Beep()
                }
                Console.WriteLine(arv);
            }*/
            /*Console.BackgroundColor = ConsoleColor.Green
            Console.WriteLine("Tere tulemast\nMis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere " + eesnimi);*/
            /*Console.WriteLine("Arv1: ");
            int arv1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Arv2: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char teha = char.Parse(Console.Readline());
            if (teha=='+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
            }
            else if (teha=='-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            }
            */
            /*if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla!\nKui vana sa oled?");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 || vanus > 100)
                {
                    Console.WriteLine("Viga Andmetega");
                }
                else if (vanus<6)
                {
                    Console.WriteLine("Tasuta");
                }
                else if (vanus>=6 && vanus<=14)
                {
                    Console.WriteLine("Lastepilet");
                }
                else if (vanus >= 15 && vanus <= 65)
                {
                    Console.WriteLine("Täispilet");
                }
                else if (vanus > 65)
                {
                    Console.WriteLine("Soduspilet");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }*/
            /*Console.WriteLine("Sisesta esimene nimi: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Sisesta teine nimi: ");
            string nimi2 = Console.ReadLine();
            if (nimi1.ToLower()=="A" && nimi2.ToLower()=="M")
            {
                Console.WriteLine(nimi1 + " ja " + nimi2 + " täna on pinginaabrid");
            }
            else if (nimi2.ToLower() == "A" && nimi1.ToLower() == "M")
            {
                Console.WriteLine(nimi1 + " ja " + nimi2 + " täna on pinginaabrid");
            }
            else
            {
                Console.WriteLine("Te ei ole M ja A");
            }*/
            /*Console.WriteLine("Sisestage ruumi laius:");
            int laius = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisestage ruumi pikkus:");
            int pikkus = int.Parse(Console.ReadLine());
            int rm = laius * pikkus;
            Console.WriteLine("Ruumi põranda pindala: {0} m2",rm);
            Console.WriteLine("Kas soovite põrandat renoveerida? (Jah/Ei");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                Console.WriteLine("Kui palju maksab ruutmeeter");
                int maksab = int.Parse(Console.ReadLine());
                int hind = rm * maksab;
                Console.WriteLine("Põranda asendamise maksumus: {0}\nHind koos 30% allahindlusega võrdub:{1}",hind,hind*0.7);
            }*/
            /*Console.WriteLine("Arv 1:");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv 2:");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv 3:");
            int arv3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv 4:");
            int arv4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv 5:");
            int arv5 = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Summa: {0}\nAritmeetiline keskmine: {1}\nKorrutamise summa:{2}",arv1+arv2+arv3+arv4+arv5,(arv1+arv2+arv3+arv4+arv5)/5,arv1*arv2*arv3*arv4*arv5);*/
            /*while (true)
            {
                Console.WriteLine("Osta elevant!");
                string v = Console.ReadLine();
                if (v.ToLower()=="elevant")
                {
                    break;
                }
            }*/
            Random rnd = new Random();
            int R = rnd.Next(0, 30);
            Console.WriteLine("Arvake ära number (0-30)");
            int V = int.Parse(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                if (V == R)
                {
                    Console.WriteLine("Õige!");
                }
                else if (V < R)
                {
                    Console.WriteLine("Teie poolt arvutatud number on suurem kui {0}", V);
                }
                else
                {
                    Console.WriteLine("Teie poolt arvutatud number on väiksem kui {0}", V);
                }
            }
        }
    }
}
