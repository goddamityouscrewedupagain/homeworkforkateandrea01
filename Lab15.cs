using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*   namespace Lab15
{
    class Print
    {
        protected int page = 0;

        public void setPage(int page)
        {
            if (page > 0 && page < 500)
            {
                this.page = page;
            }
            else
                this.page = 0;
        }
        public int getAge()
        {
            return page;
        }
        protected string name = "";
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
    class Magazine : Print
    {
        protected int Price = 0;

        public void setPrice(int price)
        {
            if (price > 0 && price < 200)
            {
                this.Price = price;
            }
            else
                this.Price = 0;
        }
        public int getPrice()
        {
            return Price;
        }

        class Book : Print
        {
            protected int year = 0;
            public void setYear(int year)
            {
                if (1990 > 0 && year < 2012)
                    this.year = year;
                else
                    this.year = 0;
            }
            public int getYear()
            {
                return year;
            }

            internal void setPrice(int p)
            {
                throw new NotImplementedException();
            }
        }
        class Textbook : Book
        {
            protected int kolvo_statej = 0;
            public void setStatya(int kolvo_statej)
            {
                this.kolvo_statej = kolvo_statej;
            }
            public int getStatya()
            {
                return kolvo_statej;
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                Print print = new Print();
                Magazine magazine = new Magazine();
                Book book = new Book();
                Textbook textbook = new Textbook();
                Console.WriteLine("введите возможное кол-во страниц печатного издания");
                print.setPage(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("введите имя печатного издания");
                print.setName(Convert.ToString(Console.ReadLine()));

                Console.WriteLine("_________________________________");
                Console.WriteLine("введите кол-во страниц журнала");
                magazine.setPage(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("введите название журнала");
                magazine.setName(Convert.ToString(Console.ReadLine()));
                Console.WriteLine("введите цену журнала");
                magazine.setPrice(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("_________________________________");
                Console.WriteLine("введите кол-во страниц учебника");
                textbook.setPage(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("введите название учебника");
                textbook.setName(Convert.ToString(Console.ReadLine()));
            }
        }
    }
}
*/