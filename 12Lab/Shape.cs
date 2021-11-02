using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shapes
    {
        protected string _color;   //доступ к типу или члену возможен только из кода в том же объекте class либо в class , производном от этого class
        public int _thickness;

        public Shapes()
        {
            Console.WriteLine("Enter color:");
            _Color = Console.ReadLine();
            Console.WriteLine("Enter thickness:");
            _Thickness = Convert.ToInt32(Console.ReadLine());   //Преобразует значение указанного символа Юникода в эквивалентное 32-битное целое
        }
        public Shapes(string _color, int _thickness)
        {
            this._Color = _color;         //this обеспечивает доступ к текущему экземпляру класса
            this._Thickness = _thickness;
        }
        public String _Color
        {
            get { return _Color; }    //get – аксессор, который используется для чтения значения из внутреннего поля класса;
            set { _Color = value; }    //set – аксессор, используемый для записи значения во внутреннее поле класса.
                                       // return предназначен для возврата значения из метода.
                                       //value представляет значение, присвоенное этому свойству
        }
        public int _Thickness
        {
            get { return _Thickness; }
            set { _Thickness = value; }
        }
        public void Area() { }
        public void Periemeter() { }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Color:{ _Color}\nLine width:{_Thickness}");
            //вывод, $-знак чтобы переписать переменную без него то что в {} не буде считываать как переменную а текст
        }

    }
}