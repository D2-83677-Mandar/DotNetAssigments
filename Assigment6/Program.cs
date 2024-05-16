namespace Assigemnt6
{


    class date
    {
      

        public date(int year, int month, int day)
        {
         _year = year;
         _Month = month;
           _DAY = day;
        }

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

        
        public void  acceptDate()
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
            Console.WriteLine("day /month /year :   "+day+"/"+month+"/"+year);
        }

        public bool Isvalid()
        {
            if((day > 0 &&  day < 30) && (month > 0 && month < 12) && ( year >1900 ))
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
    internal class Program
    {
        static void Main(string[] args)
        {
            date d1 = new date();
            d1.acceptDate();
            if(d1.Isvalid())
            {
                Console.WriteLine(d1);
            }
            else
            {
                Console.WriteLine("invalid date....please cheak Date ");
            }
           
        }
    }
}
