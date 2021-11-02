﻿/*1. Напишите объявление класса Rectangle (прямоугольник), который является производным от Square (квадрат),   
 * который, в свою очередь – производный от Shape(фигура). В классе Shape объявите следующие защищенные   
 * члены-данные : цвет линий фигуры и толщина ее линий  и напишите 2 конструктора - по умолчанию и с 
 * параметрами. В классах Square и Rectangle объявите закрытые (защищенные)  члены-данные для хранения 
 * размеров каждой из фигур, несколько конструкторов, вызывающих конструкторы базового класса, а также 
 * методы для вычисления площади и периметра фигур. В классе Rectangle обязательно используйте перекрывание 
 * методов базового класса Square. При необходимости добавьте в классы  методы доступа. Напишите главную программу, 
 * в которой выполните создание объектов-фигур различных типов и их обработку.*/

using System;

namespace Shapes
{
    class Shape
    {
        protected string color;     //доступ к типу или члену возможен только из кода в том же объекте class либо в class ,
        protected int thickness;     //производном от этого class

        public Shape()
        {
            color = "Black";
            thickness = 25;
        }
        public Shape(string color, int thickness)
        {
            this.color = color;        //обеспечивает доступ к текущему экземпляру класса
            this.thickness = thickness;   //разрешать неоднозначность контекста, которая может возникнуть,
                                          //когда входящий параметр назван так же, как поле данных данного типа.
        }
        public String Color
        {
            get { return color; }      //get – аксессор, который используется для чтения значения из внутреннего поля класса; 
            set { color = value; }      //set – аксессор, используемый для записи значения во внутреннее поле класса
                                        // return предназначен для возврата значения из метода.
                                        //value представляет значение, присвоенное этому свойству
        }
        public int Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }
        public void GetInfo()     //метод Getinfo присутствует как в базовом классе
        {
            Console.WriteLine($"Color:{ color}\nLine width:{thickness}");
            //вывод, $-знак чтобы переписать переменную без него то что в {} не буде считываать как переменную а текст
        }
        public void Area() { }   //площадь
        public void Periemeter() { }
        class Program
        {
            static void Main(string[] args)  //"Static" означает, что данное поле, метод или свойство будет принадлежать не каждому объекту класса,
                                             //а всем им вместе
                                             //метод Main, Для передачи в параметрах командной строки
            {
                Shape square2 = new Shape("White", 4265);  //фигурa, Оператор new динамически выделяет память для объекта и
                                                           //возвращает ссылку на эту область памяти
                square2.GetInfo();                          //экземпляры класса(объект)

                Rectangle shape1 = new Rectangle(25, 25, "Black", 25);    //прямоугольник
                shape1.GetInfo();
                shape1.Periemeter();
                shape1.Area();
                Square shape3 = new Square(25, "Black", 356);     //квадрат
                shape3.GetInfo();
                shape3.Periemeter();
                shape3.Area();
                Console.ReadLine();


            }
        }
    }
}