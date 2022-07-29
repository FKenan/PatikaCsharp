using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    internal class Program
    {
        static bool isLogged = false;

        static void Main(string[] args)
        {
            new Category("Kategori 1");
            new Category("Kategori 2");
            new Category("Kategori 3");

            bool isVoted = false;
            while (!isVoted)
            {
                if (!isLogged)
                {
                    Console.WriteLine("Giriş yapılmadı.Oyunuzu kullanmadan önce giriş yapmalısınız");
                    Logging();
                }
                else
                {
                    WriteCategories();
                    Console.Write("Seçiminiz : ");
                    Category selectedCategory = selectCategory(Convert.ToInt32(Console.ReadLine()));
                    selectedCategory.AddVote();
                    isVoted = true;
                }
            }
            Console.ReadLine();
        }

        public static void WriteCategories()
        {
            Console.WriteLine("*****Katagoriler*****");
            foreach (Category item in Category.Categories)
            {
                Console.WriteLine($"({item.Id}) => {item.CategoryName}");
            }
        }

        public static Category selectCategory(int selectedCategoryId)
        {
            foreach (Category item in Category.Categories)
            {
                if (item.Id == selectedCategoryId) 
                    return  item;
            }
            return null;
        }

        public static bool isUserExists(string userName)
        {
            foreach (User item in User.Users)
            {
                if (item.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Logging()
        {
            Console.WriteLine("Kullanıcı Adınız  : ");

            if (isUserExists(Console.ReadLine()))
            {
                isLogged = true;
            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı.");
                Console.WriteLine("Kayıt Olmak için (1)");
                Console.WriteLine("Tekrar denemek için (2)");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.Write("Kullanıcı Adı : ");
                    string userName = Console.ReadLine();
                    Console.Write("Ad : ");
                    string name = Console.ReadLine();
                    Console.Write("Soyad : ");
                    string surname = Console.ReadLine();
                    new User(userName, name, surname);
                    isLogged = true;
                }
            }
        }
    }
}
