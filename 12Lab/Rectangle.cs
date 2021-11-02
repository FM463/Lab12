using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Square
    {

        private int lenght;
        public Rectangle(int lenght, int side, string color, int thickness) : base(side, color, thickness) //длина, боковая сторона
        {
            this.lenght = lenght;     //this обеспечивает доступ к текущему экземпляру класса.
                                      //применение состоит в том чтобы разрешать неоднозначность контекста, которая может возникнуть,
                                      //когда входящий параметр назван так же, как поле данных данного типа.
        }
        public int Side
        {
            get { return side; }       //get – аксессор, который используется для чтения значения из внутреннего поля класса;
            set { Side = value; }      //set – аксессор, используемый для записи значения во внутреннее поле класса.
                                       // return предназначен для возврата значения из метода.
                                       //value представляет значение, присвоенное этому свойству
        }
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        public virtual void Area()      //площадь
        {
            Console.WriteLine($"\tRectangle area={side * lenght}"); //$ позволяет вместо текста в {} использовать их значение
        }
        public virtual void Periemeter()
        {
            Console.WriteLine($"\tPerimeter of a rectangle= {(side + lenght) * 2}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"\tA rectangle was created\nLenght:{side}\nHeight of the rectangle:{lenght}\nСolor:{ color}\nWidth:{thickness}");
        }                     //создан прямоугольник            бок стор    высота прямоугольна     длина                  ширина
    }
}