using System;

namespace ClassPractic1
{
    internal class Program
    {

        public class Car
        {
            public string gos_znak;
            public string model;
            public string color;
            public string ownerFio;

            public Car(string gos_znak, string model, string color, string ownerFio)
            {
                this.gos_znak = gos_znak;
                this.model = model;
                this.color = color;
                this.ownerFio = ownerFio;
            }

            ~Car()
            {
                Console.WriteLine($"Car {gos_znak} is being destroyed.");
            }

            public void printInfo()
            {
                Console.WriteLine($"Гос. знак: {gos_znak}, Модель: {model}, Цвет: {color}, Владелец: {ownerFio}");
            }


        }

        public class Symbol
        {
            private char symbol;

            public Symbol(char symbol)
            {
                this.symbol = symbol;
            }

            public void GetSymbol()
            {
                Console.WriteLine($"Символ: {symbol}");
            }

            public void GetSymbolCode()
            {
                Console.WriteLine($"Код символа '{symbol}': {(int)symbol}");
            }
        }

        public class ASCII
        {
            private char symbol1;
            private char symbol2;

            public ASCII(char symbol1, char symbol2)
            {
                this.symbol1 = symbol1;
                this.symbol2 = symbol2;
            }

            public void between()
            {
                for (int i = (int)symbol1; i <= (int)symbol2; i++)
                {
                    Console.WriteLine($"Символ: {(char)i}");
                }
            }

        }

        public class Constructor
        {
            private int num1, num2;

            public Constructor()
            {
                
            }

            public Constructor(int num1)
            {
                this.num1 = num1;
            }

            public Constructor(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }
        }

        public class Vector
        {
            private double x, y, z;

            public Vector(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public Vector SummVector(Vector other)
            {
                return new Vector (this.x + other.x, this.y + other.y, this.z + other.z);
            }

            public Vector MinusVector(Vector other)
            {
                return new Vector(this.x - other.x, this.y - other.y, this.z - other.z);
            }

            public double Scalar(Vector other)
            {
                return (this.x * other.x + this.y * other.y + this.z * other.z);
            }

            public double VectorLength()
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            }

            public double CosAngle(Vector v1, Vector v2)
            {
                return (v1.Scalar(v2) / (v1.VectorLength() * v2.VectorLength()));

            }
            public void PrintVector()
            {
                Console.WriteLine($"Вектор: ({x}, {y}, {z})");
            }

        }


        static void Main(string[] args)
        {
            Car car = null;
            Symbol symbol = null;
            int op;

            Console.WriteLine("Задание 1 - введите 1 || Задание 2,1 - введите 2,1 || Задание 2,2 - введите 2,2 || Задание 2,3 - введите 2,3 || Задание 3 (векторы) - введите 3");
            double task = Convert.ToDouble(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Console.WriteLine("Ввести данные - 1 || Посмотреть данные - 2 || Удалить данные - 3 || 0 - выход");
                    op = Convert.ToInt32(Console.ReadLine());
                    while (op != 0)
                    {
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Введите гос. знак:");
                                string gos_znak = Console.ReadLine();
                                Console.WriteLine("Введите модель:");   
                                string model = Console.ReadLine();
                                Console.WriteLine("Введите цвет:");
                                string color = Console.ReadLine();
                                Console.WriteLine("Введите ФИО владельца:");
                                string ownerFio = Console.ReadLine();
                                car = new Car(gos_znak, model, color, ownerFio);
                                car.printInfo();
                                break;
                            case 2:
                                try
                                {
                                    car.printInfo();
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("Данные отсутствуют. Пожалуйста, введите данные сначала.");
                                }
                                break;
                            case 3:
                                try
                                {
                                    car = null;
                                    Console.WriteLine("Данные удалены.");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при удалении данных: {ex.Message}");
                                }
                                break;
                            default:
                                Console.WriteLine("Неверный ввод. Пожалуйста, введите 1, 2, 3 или 0 для выхода.");
                                break;
                        }
                        Console.WriteLine("Ввести данные - 1 || Посмотреть данные - 2 || Удалить данные - 3 || 0 - выход");
                        op = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2.1:
                    Console.WriteLine("Присвоить значение - 1 || код символа - 2 || символ + код - 3 || выход - 0");
                    op = Convert.ToInt32(Console.ReadLine());
                    while (op != 0)
                    {
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Введите символ:");
                                char s = Convert.ToChar(Console.ReadLine());

                                symbol = new Symbol(s);
                                break;
                            case 2:
                                try
                                {
                                    symbol.GetSymbol();
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("Символ не присвоен. Пожалуйста, присвойте символ сначала.");
                                }
                                break;
                            case 3:
                                try
                                {
                                    symbol.GetSymbolCode();
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("Символ не присвоен. Пожалуйста, присвойте символ сначала.");
                                }
                                break;
                            default:
                                Console.WriteLine("Неверный ввод. Пожалуйста, введите 1, 2, 3 или 0 для выхода.");
                                break;
                        }
                        Console.WriteLine("Присвоить значение - 1 || код символа - 2 || символ + код - 3 || выход - 0");
                        op = Convert.ToInt32(Console.ReadLine());
                    }

                    break;
                case 2.2:
                    Console.WriteLine("Введите первый символ:");
                    char symbol1 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Введите второй символ:");
                    char symbol2 = Convert.ToChar(Console.ReadLine());
                    ASCII ascii = new ASCII(symbol1, symbol2);
                    ascii.between();
                    break;
                case 2.3:
                    Console.WriteLine("Введите первое число:");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число:");
                    string num2 = Console.ReadLine();
                    if (num1 == "")
                    {
                        Constructor constructor1 = new Constructor(Convert.ToInt32(num2));
                    }
                    else if (num2 == "")
                    {
                        Constructor constructor2 = new Constructor(Convert.ToInt32(num1));
                    }
                    else
                    {
                        Constructor constructor3 = new Constructor(Convert.ToInt32(num1), Convert.ToInt32(num2));
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите координаты первого вектора (x, y, z):");
                    Vector v1 = new Vector(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите координаты второго вектора (x, y, z):");
                    Vector v2 = new Vector(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

                    Console.WriteLine("Введите действие: 1 - сложение | 2 - вычитание | 3 - скалярное произведение | 4 - длина вектора | 5 - вычисление косинуса угла | 0 - выход");

                    op = Convert.ToInt32(Console.ReadLine());

                    while (op != 0)
                    {
                        switch (op)
                        {
                            case 1:
                                Vector sum = v1.SummVector(v2);
                                Console.WriteLine($"Сумма векторов: ");
                                sum.PrintVector();
                                break;
                            case 2:
                                Vector diff = v1.MinusVector(v2);
                                Console.WriteLine($"Разность векторов: ");
                                diff.PrintVector();
                                break;
                            case 3:
                                double scalar = v1.Scalar(v2);
                                Console.WriteLine($"Скалярное произведение: {scalar}");
                                break;
                            case 4:
                                double length1 = v1.VectorLength();
                                double length2 = v2.VectorLength();
                                Console.WriteLine($"Длина первого вектора: {length1}, Длина второго вектора: {length2}");
                                break;
                            case 5:
                                double cosAngle = v1.CosAngle(v1, v2);
                                Console.WriteLine($"Косинус угла между векторами: {cosAngle}");
                                break;
                            default:
                                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 0 до 5.");
                                break;
                        }
                        Console.WriteLine("Введите действие: 1 - сложение | 2 - вычитание | 3 - скалярное произведение | 4 - длина вектора | 5 - вычисление косинуса угла | 0 - выход");
                        op = Convert.ToInt32(Console.ReadLine());
                    }

                    break;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите 1, 2.x или 3.");
                    break;
            }

        }

    }
}
