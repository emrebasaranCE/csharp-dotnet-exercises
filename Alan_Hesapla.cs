using System;
using System.Diagnostics.Metrics;

namespace Alan_Hesapla_ns
{
    class Program
    {
       public static void not_main()
        {
            Console.WriteLine("Please enter your selection:\nFind the area of a circle(1)\nFind the area of a rectangle(2)\nFind the area of a triangle(3)\n");
            int user_choice = Convert.ToInt16(Console.ReadLine());

            switch (user_choice)
            {
                case 1:
                    Console.WriteLine("Please select what you want to do:\nFind the area of a circle(1)\nFind the circumference of a circle(2)\nFind the volume of a sphere(3)\n");
                    int choice_for_circle = Convert.ToInt16(Console.ReadLine());

                    switch (choice_for_circle)
                    {
                        case 1:
                            circle_area();
                            break;
                        case 2:
                            circle_circumference();
                            break;
                        case 3:
                            circle_volume();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Please select what you want to do:\nFind the area of a rectangle(1)\nFind the perimeter of a rectangle(2)\nFind the volume of a cube(3)");
                    int choice_for_rectangle = Convert.ToInt16(Console.ReadLine());

                    switch (choice_for_rectangle)
                    {
                        case 1:
                            rectangle_area();
                            break;
                        case 2:
                            rectangle_circumference();
                            break;
                        case 3:
                            rectangle_volume();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Please select what you want to do:\nFind the area of a triangle(1)\nFind the perimeter of a triangle(2)\nFind the volume of a tetrahedron(3)");
                    int choice_for_triangle = Convert.ToInt16(Console.ReadLine());

                    switch (choice_for_triangle)
                    {
                        case 1:
                            triangle_area();
                            break;
                        case 2:
                            triangle_circumference();
                            break;
                        case 3:
                            triangle_volume();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        public static void circle_area()
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is: " + area);
        }

        public static void circle_circumference()
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }

        public static void circle_volume()
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("The volume of the circle is: " + volume);
        }

        public static void rectangle_area()
        {
            Console.WriteLine("Please enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }

        public static void rectangle_circumference()
        {
            Console.WriteLine("Please enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * (length + width);
            Console.WriteLine("The circumference of the rectangle is: " + circumference);
        }

        public static void rectangle_volume()
        {
            Console.WriteLine("Please enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double volume = length * width * height;
            Console.WriteLine("The volume of the rectangle is: " + volume);
        }

        public static void triangle_area()
        {
            Console.WriteLine("Please enter the base of the triangle: ");
            double triangle_base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of the triangle: ");
            double triangle_height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * triangle_base * triangle_height;
            Console.WriteLine("The area of the triangle is: " + area);
        }

        public static void triangle_circumference()
        {
            Console.WriteLine("Please enter the first side of the triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second side of the triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third side of the triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            double circumference = side1 + side2 + side3;
            Console.WriteLine("The circumference of the triangle is: " + circumference);
        }

        public static void triangle_volume()
        {
            Console.WriteLine("Please enter the base of the triangle: ");
            double triangle_base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of the triangle: ");
            double triangle_height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the depth of the triangle: ");
            double triangle_depth = Convert.ToDouble(Console.ReadLine());
            double volume = 0.5 * triangle_base * triangle_height * triangle_depth;
            Console.WriteLine("The volume of the triangle is: " + volume);
        }
    }
}


// Hello World This Is Me
