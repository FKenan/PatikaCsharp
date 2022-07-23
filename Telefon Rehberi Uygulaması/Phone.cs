using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehperiUygulamsı
{
    internal class Phone
    {
        private string name;
        private string surname;
        private long phoneNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long PhoneNumber{ get => phoneNumber;
            set
            {
                if (value.ToString().Length == 10)
                    phoneNumber = value;
                else
                    Console.WriteLine("Hatalı telefon numarası girildi");
            }
        }

        public Phone(string name, string surname, long phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }

    }
}
