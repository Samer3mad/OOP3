using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Part_01
    {
        #region Part 01
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }


        class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle()
            {
                Width = 0;
                Height = 0;
            }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public Rectangle(int value)
            {
                Width = value;
                Height = value;
            }
        }

        class ComplexNumber
        {
            public double Real { get; set; }
            public double Imag { get; set; }

            public ComplexNumber(double real, double imag)
            {
                Real = real;
                Imag = imag;
            }

            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1?.Real ?? 0 + c2?.Real ?? 0, c1?.Imag ?? 0 + c2?.Imag ?? 0);
            }

            public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1?.Real ?? 0 - c2?.Real ?? 0, c1?.Imag ?? 0 - c2?.Imag ?? 0);
            }

            public override string ToString()
            {
                return $"{Real} + {Imag}i";
            }
        }

        class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Employee is working.");
            }
        }

        class Manager : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Manager is managing.");
            }
        }

        class BaseClass
        {
            public virtual void DisplayMessage()
            {
                Console.WriteLine("Message from BaseClass");
            }
        }

        class DerivedClass1 : BaseClass
        {
            public override void DisplayMessage()
            {
                Console.WriteLine("Message from DerivedClass1");
            }
        }

        class DerivedClass2 : BaseClass
        {
            public new void DisplayMessage()
            {
                Console.WriteLine("Message from DerivedClass2");
            }
        }
        #endregion



    }
}
