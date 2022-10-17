using System;

namespace HomeWork5
{

    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Triangle : Figure
    {
        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double GetArea()
        {
            return GetPerimeter()/2;
        }
        public override double GetPerimeter()
        {
            return A+B+C;
        }
    }

    class Square : Figure
    {
        public double A { set; get; }

        public Square(double a)
        {
            A = a;
        }

        public override double GetArea()
        {
            return A*A;
        }
        public override double GetPerimeter()
        {
            return A*4;
        }
    }

    class Rectangle : Figure
    {
        public double A { set; get; }
        public double B { set; get; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
    
        public override double GetArea()
        {
            return A*B;
        }
        public override double GetPerimeter()
        {
            return 2*(A+B);
        }
    }

    class Parallelogram : Figure
    {
        public double A { set; get; }
        public double B { set; get; }
        public double H { set; get; }

        public Parallelogram(double a, double b, double h)
        {
            A = a;
            B = b;
            H = h;
        }   

        public override double GetArea()
        {
            return A*H;
        }
        public override double GetPerimeter()
        {
            return 2*(A+B);
        }
    }

    class Diamond : Figure
    {
        public double A { set; get; }
        public double H { set; get; }

        public Diamond(double a, double h)
        {
            A = a;
            H = h;
        }
    
        public override double GetArea()
        {
            return A*H;
        }
        public override double GetPerimeter()
        {
            return 4*A;
        }
    }

    class Trapeze : Figure
    {
        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }
        public double D { set; get; }

        public Trapeze(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override double GetArea()
        {
            return (A+B)/Math.Abs(A-B)*Math.Sqrt((GetPerimeter()-A)*(GetPerimeter()-B)*(GetPerimeter()-A-C)*(GetPerimeter()-A-D));
        }
        public override double GetPerimeter()
        {
            return A+B+C+D;
        }
    }

    class Circle : Figure
    {
        public double R { set; get; }

        public Circle(double r)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI*R*R;
        }
        public override double GetPerimeter()
        {
            return 2*Math.PI*R;
        }
    }

    class Elipse : Figure
    {
        public double A { set; get; }
        public double B { set; get; }

        public Elipse (double a, double b)
        {
            A = a;
            B = b;
        }
        public override double GetArea()
        {
            return Math.PI*A*B;
        }
        public override double GetPerimeter()
        {
            return 4*(Math.PI*A*B+(A-B*B))/(A+B);
        }
    }

    class СompositeFigure : Figure 
    {
        Figure []Figures;
        public СompositeFigure(params Figure[] figures) 
        {
            Figures = figures;
        }
        public override double GetArea()
        {
            double area = 0;

            for (int i = 0;  i < Figures.Length; i++)
            {
                area+=Figures[i].GetArea();
            }

            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter=0;

            for (int i = 0; i < Figures.Length; i++)
            {
                perimeter += Figures[i].GetPerimeter();
            }

            return perimeter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(3,5,6);

            Diamond diamond = new Diamond(4, 7);

            Trapeze trapeze = new Trapeze(8, 4, 2, 4);

            СompositeFigure figures = new СompositeFigure(triangle,diamond, trapeze);

            Console.WriteLine("Figures area: " + figures.GetArea());
        }
    }
}