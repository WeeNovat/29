using System;
using System.Collections.Generic;

namespace ShapePolymorphism
{
    public interface IDrawable
    {
        void Draw();
    }

    public abstract class Shape : IDrawable
    {
        public abstract double CalculateArea();

        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Draw()
        {
            Console.WriteLine($"[Draw] Малюємо Коло з радіусом {Radius}");
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override void Draw()
        {
            Console.WriteLine($"[Draw] Малюємо Квадрат зі стороною {Side}");
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Draw()
        {
            Console.WriteLine($"[Draw] Малюємо Трикутник з основою {Base} та висотою {Height}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Square(4),
                new Triangle(6, 3)
            };

            Console.WriteLine("=== Обробка фігур через поліморфізм ===\n");

            foreach (var shape in shapes)
            {
                shape.Draw();
                
                double area = shape.CalculateArea();
                Console.WriteLine($"Площа фігури: {area:F2}\n");
            }

            Console.ReadLine();
        }
    }
}
