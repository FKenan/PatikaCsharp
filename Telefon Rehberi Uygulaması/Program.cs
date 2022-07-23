using System;
using System.Collections.Generic;

namespace TelefonRehperiUygulamsı
{
    internal class Program
    {
        static List<Phone> rehber = new List<Phone>();

        static void Main(string[] args)
        {

            rehber.Add(new Phone("aa", "a", 1234453423));
            rehber.Add(new Phone("bb", "b", 4234453423));
            rehber.Add(new Phone("cc", "c", 5234453423));
            rehber.Add(new Phone("dd", "d", 6234453423));
            rehber.Add(new Phone("ee", "e", 7234453423));

            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
                Console.WriteLine("(0) Çıkış Yapmak﻿");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        isExit = true;
                        break;
                    case "1":
                        NewPhoneNumber();
                        break;
                    case "2":
                        DeletePhoneNumber();
                        break;
                    case "3":
                        UpdatePhoneNumber();
                        break;
                    case "4":
                        Listele();
                        break;
                    case "5":
                        AramaYap();
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yaptınız");
                        break;
                }
            }
        }

        public static void NewPhoneNumber()
        {
            bool isAdded = false;
            Console.WriteLine();
            while (!isAdded)
            {
                try
                {
                    Console.Write("İsim Giriniz : ");
                    string name = Console.ReadLine().Trim();
                    Console.Write("Soyisim Giriniz : ");
                    string surname = Console.ReadLine().Trim();
                    Console.Write("Telefon numarası Giriniz : ");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine().Trim());

                    if (phoneNumber.ToString().Length == 10)
                    {
                        rehber.Add(new Phone(name, surname, phoneNumber));
                        Console.WriteLine("Kişi eklendi");
                        isAdded = true;
                    }
                    else
                        Console.WriteLine("Hatalı giriş yapıldı!");
                }
                catch (Exception)
                {
                    Console.WriteLine("hatalı giriş");
                }
            }
        }

        public static void DeletePhoneNumber()
        {
            bool isRemoved = false;

            while (!isRemoved)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string nameOrSurname = Console.ReadLine();
                foreach (Phone item in rehber)
                {
                    if (item.Name == nameOrSurname || item.Surname == nameOrSurname)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.Name, item.Surname);
                        string choice = Console.ReadLine().Trim();
                        if (choice == "y")
                        {
                            rehber.Remove(item);
                            isRemoved = true;
                            break;
                        }
                        else if (choice == "n")
                        {
                            Console.WriteLine("Silme işlemi İptal edildi");
                            isRemoved = true;
                            break;
                        }
                    }
                }
                if (!isRemoved)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine();
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    string choice = Console.ReadLine();
                    if (choice == "1") isRemoved = true;
                }
            }
        }

        public static void UpdatePhoneNumber()
        {
            bool isUpdated = false;

            while (!isUpdated)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string nameOrSurname = Console.ReadLine();
                foreach (Phone item in rehber)
                {
                    if (item.Name == nameOrSurname || item.Surname == nameOrSurname)
                    {
                        Console.WriteLine();
                        Console.WriteLine("{0} {1} isimli kişi güncellenmek  üzere, onaylıyor musunuz ?(y/n)", item.Name, item.Surname);
                        string choice = Console.ReadLine().Trim();

                        if (choice == "y")
                        {
                            Update(item);
                            isUpdated = true;
                            break;
                        }
                        else if (choice == "n")
                        {
                            Console.WriteLine("Silme işlemi İptal edildi");
                            isUpdated = true;
                            break;
                        }
                    }
                }
                if (!isUpdated)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine();
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    string choice = Console.ReadLine();
                    if (choice == "1") isUpdated = true;
                }
            }
        }

        public static void Listele()
        {
            Console.WriteLine();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            foreach (Phone item in rehber)
            {
                BilgiYazdır(item);
            }
        }

        public static void AramaYap()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SearchByNameOrSurname();
                    break;
                case "2":
                    SearchByPhone();
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Yapıldı");
                    break;
            }
        }

        public static void Update(Phone item)
        {
            bool isAdded = false;
            while (!isAdded)
            {
                try
                {
                    Console.Write("İsim Giriniz : ");
                    string name = Console.ReadLine().Trim();
                    Console.Write("Soyisim Giriniz : ");
                    string surname = Console.ReadLine().Trim();
                    Console.Write("Telefon numarası Giriniz : ");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine().Trim());

                    if (phoneNumber.ToString().Length == 10)
                    {
                        item.Surname = surname;
                        item.PhoneNumber = phoneNumber;
                        item.Name = name;
                        Console.WriteLine("Kişi güncellendi");
                        isAdded = true;
                    }
                    else
                        Console.WriteLine("Hatalı giriş yapıldı!");
                }
                catch (Exception)
                {
                    Console.WriteLine("hatalı giriş");
                }
            }
        }

        public static void SearchByNameOrSurname()
        {
            Console.WriteLine();
            Console.WriteLine("Aranacak isim yada soyisim : ");
            string value= Console.ReadLine();

            bool isDone=false;

            foreach (Phone item in rehber)
            {
                if (item.Name == value || item.Surname == value)
                {
                    BilgiYazdır(item);
                    isDone = true;
                    break;
                }
            }
            if (!isDone)
            {
                Console.WriteLine();
                Console.WriteLine("{0} Bulunamadı",value);
            }
        }

        public static void SearchByPhone()
        {
            Console.WriteLine();
            Console.WriteLine("Aranacak telefon numarası");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());     // string değer girilmesine karşılık try catch kullanabiliriz.

            bool isDone = false;

            foreach (Phone item in rehber)
            {
                if (item.PhoneNumber == phoneNumber)
                {
                    BilgiYazdır(item);
                    isDone=true;
                    break;
                }
            }
            if (!isDone)
            {
                Console.WriteLine();
                Console.WriteLine("{0} Bulunamadı",phoneNumber);
            }
        }

        public static void BilgiYazdır(Phone item)
        {
            Console.WriteLine("isim: {0}", item.Name);
            Console.WriteLine("Soyisim: {0}", item.Surname);
            Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
            Console.WriteLine("-");
        }
    }
}
