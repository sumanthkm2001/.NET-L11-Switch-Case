namespace L11
{
    class Program
    {
        enum Day
        {
            Sunday=1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week in integer(1-7) >> ");
            int intDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You Selected {0}.", (Day)intDay);

            string strOutput;

            switch ((Day)intDay)
            {
                case Day.Sunday:
                    strOutput = "10:00a-2:00p";
                    break;
                case Day.Monday:
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                    strOutput = "Closed";
                    break;
                case Day.Friday:
                    strOutput = "8:00a-5:00p";
                    break;
                case Day.Saturday:
                    strOutput = "8:00a-2:00p";
                    break;
                default:
                    strOutput = "Invalid Number";
                    break;
            }
            Console.WriteLine("Hours : {0}.",strOutput); 

            /*
            if (intDay == (int)Day.Sunday || intDay == (int)Day.Saturday || intDay == (int)Day.Friday)
                Console.WriteLine("8:00a - 5:00p");
            else if (intDay == (int)Day.Monday || intDay == (int)Day.Tuesday || intDay == (int)Day.Wednesday || intDay == (int)Day.Thursday)
                Console.WriteLine("Closed");
            else { Console.WriteLine("Inavlid"); }
            */

            Console.Read();
        }
    }
}