
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCsharp
{
    internal class CollectionsAlgoritma
    {
        static void Main(string[] args)
        {
            #region Problem 1

            ArrayList asal = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            int counter = 0;

            int asalToplam = 0;
            int asaldegilToplam = 0;

            while (counter <= 20)
            {
                Console.Write("Sayı gir :");
                try
                {

                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1 || number == 2)
                    {
                        asal.Add(number);
                        counter++;
                    }
                    else
                    {
                        bool isAsal = true;

                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                asaldegil.Add(number);
                                counter++;
                                isAsal = false;
                                break;
                            }
                        }
                        if (isAsal)
                        {
                            asal.Add(number);
                            counter++;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Numerik ifade girmediniz");
                }
            }

            Console.WriteLine();

            asal.Sort();
            asaldegil.Sort();

            Console.WriteLine("***Asal Sayılar***");
            foreach (int item in asal)
            {
                Console.WriteLine(item);
                asalToplam += item;
            }

            try
            {
                Console.WriteLine("{0} tane asal sayı var.Ortalaması : {1} ", asal.Count, (double)(asalToplam / asal.Count));
            }
            catch (Exception)
            {
                Console.WriteLine("Asal sayı yok");
            }

            Console.WriteLine();

            Console.WriteLine("***Asal Olmayan Sayılar***");
            foreach (int item in asaldegil)
            {
                Console.WriteLine(item);
                asaldegilToplam += item;
            }

            try
            {
                Console.WriteLine("{0} tane asal olmayan sayı var.Ortalaması : {1} ", asaldegil.Count, (double)(asaldegilToplam / asaldegil.Count));
            }
            catch (Exception)
            {
                Console.WriteLine("Asal olmayan sayı yok");
            }
            #endregion

            #region Problem 2 
            int[] arr = new int[20];
            int[] minArr = new int[3];
            int[] maxArr = new int[3];

            int sumMin = 0;
            int sumMax = 0;
            bool isAdded;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Sayı gir :");
                isAdded = false;
                while (!isAdded)
                {
                    try
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        arr[i] = a;
                        isAdded = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hatalı giriş yapıldı.");
                    }
                }
            }

            Array.Sort(arr);

            for (int i = 0; i < 3; i++)
            {
                minArr[i] = arr[i];
            }
            for (int i = arr.Length - 1, count = 0; i >= arr.Length - 3; i--, count++)
            {
                maxArr[count] = arr[i];
            }

            Console.WriteLine("----------------------");

            Console.Write("Dizideki en küçük 3 Sayı :");

            foreach (int i in minArr)
            {
                Console.Write($"{i,-7}");
                sumMin += i;
            }

            Console.WriteLine(" => Ortalaması :" + sumMin / minArr.Length);

            Console.WriteLine("---------------------");

            Console.Write("Dizideki en büyük 3 Sayı :");

            foreach (int i in maxArr)
            {
                Console.Write($"{i,-7}");
                sumMax += i;
            }

            Console.WriteLine(" => Ortalaması :" + sumMax / maxArr.Length);
            #endregion

            #region Problem 3
            string s = Console.ReadLine();
            char[] charArr = s.ToCharArray();
            char[] sesliHarfler = new char[8] { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            List<char> geciciList = new List<char>();// kaç eleman ekleneceğini bilinmediği için list e atıp arraya çevirdim

            for (int i = 0; i < charArr.Length; i++)
            {
                if (sesliHarfler.Contains(char.ToLower(charArr[i])))
                {
                    geciciList.Add(char.ToLower(charArr[i]));
                }
            }
            char[] cumledekiSesliHarfler = geciciList.ToArray();
            Array.Sort(cumledekiSesliHarfler);
            Console.Write("Cümledeki sesli harfler : ");
            foreach (char c in cumledekiSesliHarfler)
            {
                Console.Write($"{c,-5}");
            }
            #endregion

            Console.Read();
        }
    }
}
