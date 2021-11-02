using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public int side;  //боковая сторона
        public Square(int side, string line_color, int line_thickness) : base(line_color, line_thickness)
        {
            this.side = side;   //this обеспечивает доступ к текущему экземпляру класса
        }
        public int Side
        {
            get { return side; }    //get – аксессор, который используется для чтения значения из внутреннего поля класса;
            set { side = value; }     //set – аксессор, используемый для записи значения во внутреннее поле класса.
                                      // return предназначен для возврата значения из метода.
                                      //value представляет значение, присвоенное этому свойству
        }
        public virtual void Area()
        {
            Console.WriteLine($"\tSquare area={side * side}");
            //вывод, $-знак чтобы переписать переменную без него то что в {} не буде считываать как переменную а текст
        }
        public virtual void Periemeter()
        {
            Console.WriteLine($"\tPeriemeter of a square= {side * 4}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"\tA square was created\nSide length:{ side}\nColor:{ color}\nWidth:{thickness}");
            //создан квадрат        бок сторона                          ширина
        }
    }
}