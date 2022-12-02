using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            Calculator cal = new Calculator();
            do
            {

                Console.WriteLine("Enter Parameter Length:");
                int parameter = Convert.ToInt32(Console.ReadLine());
                string var;
                switch (parameter)
                {
                    case 2:
                        Console.WriteLine("Enter +,-,*,/");
                        var = Console.ReadLine();
                        if (var == "+")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            cal.Add(a, b);
                        }
                        else if (var == "-")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            cal.Sub(a, b);
                        }
                        else if (var == "*")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            cal.Mul(a, b);
                        }
                        else if (var == "/")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            cal.Div(a, b);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Method");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter +,-,*,/");
                        var = Console.ReadLine();
                        if (var == "+")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            cal.Add(a, b, c);
                        }
                        else if (var == "-")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            cal.Sub(a, b, c);
                        }
                        else if (var == "*")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            cal.Mul(a, b, c);
                        }
                        else if (var == "/")
                        {
                            Console.WriteLine("Enter Number:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Number:");
                            int c = Convert.ToInt32(Console.ReadLine());
                            cal.Div(a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Method");
                        }
                        break;
                    default:
                        Console.WriteLine("--------------------No match found---------------------");
                        Console.WriteLine("--------------------Try it Again---------------------");
                        Console.WriteLine("--------------Two or Three Parameter are allowed---------------------");
                        break;
                }
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");


        }
    }
    class Calculator
    {
        int result;
        public void Add(int a, int b)
        {
            result = a + b;
            Console.WriteLine($"Addition of {a} and {b}:{result}");
        }
        public void Add(int a, int b, int c)
        {
            result = a + b + c;
            Console.WriteLine($"Addition of {a},{b} and {c}:{result}");
        }
        public void Sub(int a, int b)
        {
            result = a - b;
            Console.WriteLine($"Subtraction of {a} and {b}:{result}");
        }
        public void Sub(int a, int b, int c)
        {
            result = a - b - c;
            Console.WriteLine($"Subtraction of {a},{b} and {c}:{result}");
        }
        public void Mul(int a, int b)
        {
            result = a * b;
            Console.WriteLine($"Multiplication of {a} and {b}:{result}");
        }
        public void Mul(int a, int b, int c)
        {
            result = a * b * c;
            Console.WriteLine($"Multiplication of {a},{b} and {c}:{result}");
        }
        public void Div(int a, int b)
        {
            result = a / b;
            Console.WriteLine($"Division of {a} and {b}:{result}");
        }
        public void Div(int a, int b, int c)
        {
            result = a / b / c;
            Console.WriteLine($"Division of {a},{b} and {c}:{result}");
        }
    }
}

