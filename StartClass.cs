using System;
using System.Collections;
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
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp=Console.ReadKey();
            } while (nupp.Key!=ConsoleKey.Backspace);

            /*Dictionary<int, string> dic = new Dictionary<int, string>(5);
            dic.Add(1, "Üks");
            dic.Add(2, "Kaks");
            dic[3] = "Kolm";
            dic[4] = "Neli";
            dic[5] = "Viis";
            foreach (KeyValuePair<int,string> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }*/

            /*Dictionary<int, Inimene> opilased = new Dictionary<int, Inimene>(3);
            //List<Inimene> list = new List<Inimene>();
            Inimene inimene = new Inimene();
            inimene.Nimi = "Mati";
            inimene.Vanus = 65;
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Mati";
            inimene1.Vanus = 43;
            //list.Add(inimene);
            //list.Add(new Inimene() { Nimi = "Kati" });
            opilased.Add(1,inimene);
            opilased.Add(2, inimene1);
            opilased.Add(3, new Inimene() { Nimi="Marina", Vanus=100});

            foreach (Inimene item in opilased.Values)
            {
                Console.WriteLine(item.Nimi);
            }

            foreach (KeyValuePair<int,Inimene> item in opilased)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Nimi);
            }*/






            /*ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            if (arrayList.Contains("Teine"))
            {
                Console.WriteLine("Sõna Teine on olemas");
                Console.WriteLine("Teine asub kohal {0}",arrayList.IndexOf("Teine")+1);
            }
            else
            {
                Console.WriteLine("Otsitav sõna puudub");
            }
            Console.WriteLine("Kokku järjendis on " + arrayList.Count + " elements");
            arrayList.Insert(3, "Neljas");
            arrayList.Insert(4, "Viies");
            arrayList.Sort();
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.RemoveAt(0);
            arrayList.Remove("Viies");
            arrayList.Clear();*/


            //string nimi = "Python";
            //alamprog.Tere(nimi);

            //int a = 14;
            //int b = 12;
            //int vastus=alamprog.Korruta(a, b);
            //Console.WriteLine(vastus);
            //Console.WriteLine(alamprog.Korruta(a, b));

            //Console.WriteLine("Mitmest arvust leiate keskmise arvu?");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Keskmine arv: {0}", alamprog.Keskmine(n));

            //alamprog.Kass();

            //alamprog.nzvezda();


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

            /*Random rnd = new Random();
            int R = rnd.Next(0, 30);
            Console.WriteLine("Arvake ära number (0-30)");
            for (int i = 0; i < 5; i++)
            {
                int V = int.Parse(Console.ReadLine());
                if (V == R)
                {
                    Console.WriteLine("Õige!");
                    break;
                }
                else if (V < R)
                {
                    Console.WriteLine("Teie poolt arvutatud number on suurem kui {0}", V);
                }
                else
                {
                    Console.WriteLine("Teie poolt arvutatud number on väiksem kui {0}", V);
                }
            }*/



            Console.ReadKey();
        }
    }
}
