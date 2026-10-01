using System;

class Program
{
    static void Main()
    {
        int choice = -1;

        while (choice != 0)
        {
            Console.WriteLine("1 — круг");
            Console.WriteLine("2 — прямоугольник");
            Console.WriteLine("3 — неизвестная фигура");
            Console.WriteLine("0 — выход");
            Console.Write("Выбор: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
                Console.Write("Введите число от 0 до 3: ");

            if (choice == 1)
            {
                double x = ReadNumber("Центр X: ");
                double y = ReadNumber("Центр Y: ");
                double radius = ReadNumber("Радиус: ");

                Point center = new Point(x, y);
                Circle circle = new Circle(center, radius);
                Console.WriteLine(ShapeClassifier.Classify(circle));
            }

            if (choice == 2)
            {
                double x1 = ReadNumber("Левый верхний угол X: ");
                double y1 = ReadNumber("Левый верхний угол Y: ");
                double x2 = ReadNumber("Правый нижний угол X: ");
                double y2 = ReadNumber("Правый нижний угол Y: ");

                Point topLeft = new Point(x1, y1);
                Point bottomRight = new Point(x2, y2);
                Rectangle rectangle = new Rectangle(topLeft, bottomRight);
                Console.WriteLine(ShapeClassifier.Classify(rectangle));
            }

            if (choice == 3)
            {
                Console.Write("Название фигуры: ");
                string name = Console.ReadLine();
                Console.WriteLine(ShapeClassifier.Classify(name));
            }
        }
    }

    static double ReadNumber(string question)
    {
        double number;
        Console.Write(question);
        while (!double.TryParse(Console.ReadLine(), out number) || number > 1000)
            Console.Write("Нужно число от 0 до 1000, введите ещё раз: ");
        return number;
    }
}
