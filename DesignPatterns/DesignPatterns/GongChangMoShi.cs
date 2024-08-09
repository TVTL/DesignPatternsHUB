using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://www.runoob.com/design-pattern/factory-pattern.html
/// </summary>
namespace DesignPatterns
{
    class GongChangMoShi
    {
    }
    public interface Shape
    {
        void draw();
    }
    public class Rectangle:Shape
    {
        public void draw()
        {
            System.Console.WriteLine("Rectangle implements Shape::draw() method.");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            System.Console.WriteLine("Square implements Shape::draw() method.");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            System.Console.WriteLine("Circle implements Shape::draw() method.");
        }
    }
}
