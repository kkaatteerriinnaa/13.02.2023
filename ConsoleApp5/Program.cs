using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Web site = new Web();
            Magazine maga = new Magazine();
            Shop Sh = new Shop();

            site.printWeb();
            maga.printMag();
            Sh.printSh();
        }
    }
    class Web
    {
        public string name = "name";
        public string way = "way";
        public string description = "description";
        public int ip;
        
        public void printWeb()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Путь к сайту: {way}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"IP: {ip}");
        }
        public string NameW
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string WayW
        {
            set
            {
                way = value;
            }
            get
            {
                return way;
            }
        }
        public string DescriptionW
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public int IpW
        {
            set
            {
                ip = value;
            }
            get
            {
                return ip;
            }
        }
    }
    class Magazine
    {
        public string name = "name";
        public int year = 1999;
        public string description = "description";
        public string phone = "0932685964";
        public string mail = "@Email.com";

        public void printMag()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Год основания: {year}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"e-mail: {mail}");
        }
        public string NameM
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int YearM
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }
        public string DescriptionM
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public string PhoneM
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        public string MailM
        {
            set
            {
                mail = value;
            }
            get
            {
                return mail;
            }
        }
    }
    class Shop
    {
        public string name = "name";
        public string adress = "adress.com";
        public string description = "description";
        public string phone = "0932685964";
        public string mail = "@Email.com";
        public void printSh()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Год основания: {adress}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"e-mail: {mail}");
        }
        public string NameS
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string AdressS
        {
            set
            {
                adress = value;
            }
            get
            {
                return adress;
            }
                
        }
        public string DescriptionS
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public string PhoneS
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        public string MailS
        {
            set
            {
                mail = value;
            }
            get
            {
                return mail;
            }
        }
    }
}
