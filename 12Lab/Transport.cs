using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Transport
    {
        private int number;
        private int year_of_issue;
        private string model;

        public Transport(int number, int year_of_issue, string model)
        {
            this.number = number;
            this.year_of_issue = year_of_issue;
            this.model = model;
        }

        public Transport()
        {
            Console.WriteLine(number);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year_of_issue);
            year_of_issue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your model: ");
            model = Console.ReadLine();
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Year_of_issue
        {
            get { return year_of_issue; }
            set { year_of_issue = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Number:{number}\nYes_of_issue:{year_of_issue}\nModel:{model}");
        }
        class automobile : Transport
        {
            public int max_speed;

            public automobile(int max_speed)
            {
                this.max_speed = max_speed;
            }

            public automobile()
            {
                Console.WriteLine(max_speed);
                max_speed = Convert.ToInt32(Console.ReadLine());
            }

            public int Max_speed
            {
                get { return max_speed; }
                set { max_speed = value; }
            }

            public void GetInfo()
            {
                Console.WriteLine($"Max_speed:{max_speed}");
            }
        }
        class bus : Transport
        {
            public int number_of_seats;

            public bus(int number_of_seats)
            {
                this.number_of_seats = number_of_seats;
            }

            public bus()
            {
                Console.WriteLine(number_of_seats);
                number_of_seats = Convert.ToInt32(Console.ReadLine());
            }

            public int Number_of_seats
            {
                get { return number_of_seats; }
                set { number_of_seats = value; }
            }

            public void GetInfo()
            {
                Console.WriteLine($"Number_of_seats:{number_of_seats}");
            }
        }
    }
}