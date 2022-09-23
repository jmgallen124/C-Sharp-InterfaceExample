// Jeremy Gallen's sample program to demonstrate interfaces

namespace InterfaceExample
{
    // Draw shape interface
    public interface DrawShape
    {
        void draw();
    }

    // Class to draw shape
    public class Square : DrawShape
    {
        // Implementation of draw method
        public void draw()
        {
            Console.WriteLine("Drawing a square...");
        }
    }

    // Triangle class
    public class Triangle : DrawShape
    {
        // Implement draw method
        public void draw()
        {
            Console.WriteLine("Drawing a triangle...");
        }
    }

    // Main class
    internal class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Demonstrate interfaces
            DrawShape shape;
            shape = new Square();
            shape.draw();
            shape = new Triangle();
            shape.draw();
        }
    }
}