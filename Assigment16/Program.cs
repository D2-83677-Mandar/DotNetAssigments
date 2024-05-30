using Assigmnt7;

namespace Assigmnt7
{
    class date
    {


     

        public date()
        {
        }

        private int _year;

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _Month;

        public int month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        private int _DAY;

        public int day
        {
            get { return _DAY; }
            set { _DAY = value; }
        }
        public date(int year, int month, int day)
        {
            _year = year;
            _Month = month;
            _DAY = day;
        }


        public void acceptDate()
        {
            Console.WriteLine("Enter the day ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month :");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());

        }
        public void displaydata()
        {
            Console.WriteLine("day /month /year :   " + day + "/" + month + "/" + year);
        }

        public bool Isvalid()
        {
            if ((day > 0 && day < 30) && (month > 0 && month < 12) && (year > 1900))
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }



    }


    class person
    {


        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _Address;

        public string Address 
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private bool _gender;

        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private date _Date;

        public person()
        {
            _Date = new date();
        }

        public person(string name, string address, bool gender, date date)
        {
            _name = name;
            _Address = address;
            _gender = gender;
            _Date = date;
        }

     


public void accept()
        {
            Console.WriteLine("Enter the Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the gender :");
            gender = bool.Parse(Console.ReadLine());
            _Date.acceptDate();
            


        }
          public void displaydata1()
        {
            Console.WriteLine("name is :" + name);
            Console.WriteLine("address is " + Address);

            Console.WriteLine("GENDER IS "+gender
                );
            _Date.displaydata();

            int currentYear = DateTime.Now.Year;

            int age = currentYear - _Date.year;
            if (DateTime.Now.Month < _Date.month || (DateTime.Now.Month == _Date.month && DateTime.Now.Day < _Date.day))
            {
                age--;
            }

            Console.WriteLine("Your age is: " + age);
        }
    }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
          person p = new person();

            p.accept();
            p.displaydata1();
        }
    }

