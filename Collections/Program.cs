using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    internal class Program
    {
        static int ArraySum(int[] t)
        {
            int sum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }

            return sum;
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] : {array[i]}");
            }
        }

        static void ShowMaxValue(int[] array)
        {
            int vMax = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > vMax)
                {
                    vMax = array[i];
                }            
            }
            Console.WriteLine();
            Console.WriteLine($"La valeur maximale est {vMax}");
        }

        static void ShowMinValue(int[] array)
        {
            int vMin = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < vMin)
                {
                    vMin = array[i];
                }
            }
            Console.WriteLine($"La valeur minimale est {vMin}");
        }

        static void Arrays()
        {
            //int[] t = {200, 40, 18, 57, 26};
            const int LENGTH_ARRAY = 20;
            int[] t = new int[LENGTH_ARRAY];
            Random rand = new Random();

            for (int i = 0; i < t.Length; i++)
            {
                t[i] += rand.Next(101);
            }

            ShowArray(t);
            ShowMaxValue(t);
            ShowMinValue(t);
        }

        static void ShowList(List<string> list, bool decreasedOrder = false)
        {
            if (!decreasedOrder)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            else
            {
                for (int i = list.Count-1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }

            string longestName = "";
            for (int i = 0; i < list.Count; i++)
            {
                string name = list[i];
                if (name.Length > longestName.Length)
                {
                    longestName = name;
                }
            }
            Console.WriteLine($"Le nom le plus grand est : {longestName}");
        }

        static void Lists()
        {
            /*
            var names = new List<string>();
            

            while (true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir : )");
                string name = Console.ReadLine();

                if(name == "")
                {
                    break;
                }

                if (names.Contains(name))
                {
                    Console.WriteLine("Erreur, ce nom est déjà dans la liste.");
                    Console.WriteLine();
                }
                else
                {
                    names.Add(name);
                }
            }

            //list.Add(2);
            //list.Add(8);
            //list.Add(15);

            for (int i = names.Count - 1; i >= 0; i--)
            {
                if (names[i].EndsWith('e'))
                {
                    names.RemoveAt(i);
                }
            }

            ShowList(names, false);

            */

            var list1 = new List<string>() { "Paul", "Jean", "Pierre", "Emilie", "Martin" };
            var list2 = new List<string>() { "Sophie", "Jean", "Toto", "Martin" };

            ShowCommuneElements(list1, list2);

            
        }
        static void ShowCommuneElements(List<string> l1, List<string> l2)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                string name1 = l1[i];
                if (l2.Contains(name1))
                {
                    Console.WriteLine(name1);
                }
            }
        }

        static void ArrayList()
        {
            ArrayList a = new ArrayList();

        }

        static void ListOfLists()
        {
            var pays = new List<List<string>>();

            pays.Add(new List<string> { "France", "Rennes", "Paris", "Strasbourg" });
            pays.Add(new List<string> { "Espagne", "Madrid", "Barcelone", "Alicante" });
            pays.Add(new List<string> { "Allemagne", "Munich", "Berlin", "Breme" });
            
            for (int i = 0; i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine($"{p[0]} - {p.Count-1} villes");
                for (int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine($"  {p[j]}");
                }
            }

        }

        static void Dictionary()
        {
            string peopleToFind = "Martin";

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622443366");
            d.Add("Marie", "0622883377");
            d["Martin"] = "0658794425";

            if (d.ContainsKey(peopleToFind))
            {
                Console.WriteLine(d[peopleToFind]);
            }
            else
            {
                Console.WriteLine("Cette personne n'existe pas");
            }

            var l = new List<string[]>();
            l.Add(new string[] { "Jean", "0622443366" });
            l.Add(new string[] { "Marie", "0622883377" });
            l.Add(new string[] { "Martin", "0658794425" });
            l.Add(new string[] { "Toto", "0666666666" });

            for (int i = 0; i < l.Count; i++)
            {
                if(l[i][0] == peopleToFind)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }
        }

        static void ForEachLoop()
        {
            //var noms = new string[] { "Toto", "Jean", "Pierre" };
            //var noms = new List<string>() { "Toto", "Jean", "Pierre" };
            /*for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }*/
            /*foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622443366");
            d.Add("Marie", "0622883377");
            d["Martin"] = "0658794425";

            foreach (var e in d)
            {
                Console.WriteLine($"{e.Key} - {e.Value}");
            }
        }

        static void TrisAndLinq()
        {
            /*var noms = new List<string> { "Toto", "Jean", "Pierre", "Emilie", "Benoit", "Alexis", "Charlotte", "Thierry" };

            //noms.Sort();
            //Array.Sort(noms);
            //noms = noms.OrderBy(nom => nom).ToList();
            noms = noms.Where(nom => nom[nom.Length-1] != 'e').ToList();

            foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var notes = new List<int> { 4, 8, 9, 7, 6};
            //notes = notes.OrderBy(n => n).ToList();
            notes = notes.Where(x => x >= 5).ToList();
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        static void MaFonction(out int p)
        {
            p = 10;
        }

        static void MaFonction2(List<int> p)
        {
            p[0] = 10;
        }

        static void PassageValeurOuRef()
        {
            //int a = 5;
            //MaFonction(out a);

            //int num = int.Parse("15");
            int num = 0;
            if(int.TryParse("1u", out num))
            {
                Console.WriteLine("Conversion OK");
            }
            else
            {
                Console.WriteLine("Problème de conversion");
            }


            //var l = new List<int> { 5};
            //MaFonction2(l);

            //Console.WriteLine(l[0]);
            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            //Arrays();
            //Lists();
            //ArrayList();
            //ListOfLists();
            //Dictionary();
            //ForEachLoop();
            //TrisAndLinq();
            PassageValeurOuRef();
        }
    }
}
