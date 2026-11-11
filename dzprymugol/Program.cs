//дз за 24.10 1 
//class Program
//{

//    static void Main(string[] args)
//    {
//        Program calculator = new Program();
//        calculator.Start();
//    }

//    void Start()
//    {
//        Console.WriteLine("=== Улучшенный калькулятор ===");

//        Console.Write("Введите первое число: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите второе число: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите операцию (+, -, *, /): ");
//        string op = Console.ReadLine();

//        double result = Calculate(num1, num2, op);
//        bool hasError = CheckErrors(num2, op);
//        PrintResult(num1, num2, op, result, hasError);
//    }

//    double Calculate(double a, double b, string op)
//    {
//        if (op == "+") return a + b;
//        if (op == "-") return a - b;
//        if (op == "*") return a * b;
//        if (op == "/" && b != 0) return a / b;
//        return 0;
//    }

//    bool CheckErrors(double b, string op)
//    {
//        return op == "/" && b == 0;
//    }
//    void PrintResult(double a, double b, string op, double result, bool error)
//    {
//        Console.WriteLine("\n--------------------------------");
//        if (error)
//        {
//            Console.WriteLine("Ошибка: Деление на ноль невозможно!");
//        }
//        else
//        {
//            Console.WriteLine($"Результат: {a} {op} {b} = {result}");
//        }
//        Console.WriteLine("--------------------------------");
//    }
//дз за 29.10 и за 31.10 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] originalArray = { 10, 20, 30, 40, 50 };

//        Console.Write("Исходный массив: ");
//        for (int i = 0; i < originalArray.Length; i++)
//        {
//            Console.Write(originalArray[i] + " ");
//        }
//        Console.WriteLine(); 
//        int[] reversedArray = new int[originalArray.Length];

//        for (int i = 0, j = originalArray.Length - 1; i < originalArray.Length; i++, j--)
//        {
//            reversedArray[i] = originalArray[j];
//        }

//        Console.Write("Перевернутый массив: ");
//        for (int i = 0; i < reversedArray.Length; i++)
//        {
//            Console.Write(reversedArray[i] + " ");
//        }
//        Console.WriteLine();
//    }
// 
//дз за 7.11
//class Rectangle
//{
//    public double width;
//    public double height;

//    public double GetArea()
//    {
//        return width * height;
//    }

//    public double GetPerimeter()
//    {
//        return 2 * (width + height);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("=== Работа с геометрической фигурой Прямоугольник ===\n");

//        Rectangle rect1 = new Rectangle();
//        rect1.width = 5.0;
//        rect1.height = 10.0;
//        double area1 = rect1.GetArea();
//        double perimeter1 = rect1.GetPerimeter();

//        Console.WriteLine("Прямоугольник №1:");
//        Console.WriteLine($"- Ширина: {rect1.width}");
//        Console.WriteLine($"- Высота: {rect1.height}");
//        Console.WriteLine($"- Площадь: {area1}");
//        Console.WriteLine($"- Периметр: {perimeter1}");
//        Console.WriteLine("--------------------------------------");

//        Rectangle rect2 = new Rectangle();
//        rect2.width = 3.5;
//        rect2.height = 4.2;

//        double area2 = rect2.GetArea();
//        double perimeter2 = rect2.GetPerimeter();

//        Console.WriteLine("Прямоугольник №2:");
//        Console.WriteLine($"- Ширина: {rect2.width}");
//        Console.WriteLine($"- Высота: {rect2.height}");
//        Console.WriteLine($"- Площадь: {area2}");
//        Console.WriteLine($"- Периметр: {perimeter2}");
//        Console.WriteLine("--------------------------------------");
//    }
//}