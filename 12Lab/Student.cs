//Напишите объявления для следующих диаграмм классов, включив в него члены-данные,
//конструкторы по умолчанию и с параметрами , методы доступа,
//методы ввода-вывода для клавиатуры и экрана и т.д. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class Student
    {
        private int number;
        private string surname;
        private string gender;

        public Student(int number, string surname, string gender)
        {
            this.number = number;
            this.surname = surname;
            this.gender = gender;
        }

        public Student()
        {
            Console.WriteLine("Enter your last name: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            gender = Console.ReadLine();
            Console.WriteLine(number);
            number = Convert.ToInt32(Console.ReadLine());

        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Nomer:{number}\nStudent surname:{surname}\nGender:{gender}");
        }
        class Zaochnik : Student
        {
            private string place_of_work;
            private string position;

            public Zaochnik(string place_of_work, string position)
            {
                this.place_of_work = place_of_work;
                this.position = position;
            }

            public Zaochnik()
            {
                Console.WriteLine("Enter your place of work: ");
                place_of_work = Console.ReadLine();
                Console.WriteLine("Enter position: ");
                position = Console.ReadLine();
            }

            public string Place_of_work
            {
                get { return place_of_work; }
                set { place_of_work = value; }
            }
            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public void GetInfo()
            {
                Console.WriteLine($"Zaochnik place_of_work:{place_of_work}\nPosition:{position}");
            }
        }
    }
}