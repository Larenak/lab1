using System;
using System.Globalization;
using System.Text;

namespace Lab1;

public class LabTasks
{
    public void Run()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
        Console.WriteLine("Лабораторная работа №1");
        Console.WriteLine("Введите номер задания, затем номер задачи.");
        Console.WriteLine("Дробные числа можно вводить с запятой или точкой.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1 — Методы\n2 — Условия\n3 — Циклы\n4 — Массивы\n0 — Выход");
            int assignment = ReadInt("Номер задания", 0, 4);

            if (assignment == 0)
            {
                Console.WriteLine("До свидания!");
                return;
            }

            ShowTasks(assignment);
            int task = ReadInt("Номер задачи (0 — назад)", 0, 5);

            if (task != 0)
            {
                SolveTask(assignment, task);
            }
        }
    }

    // Задание 1. Методы.
    public double Fraction(double x)
    {
        return x % 1;
    }

    public int CharToNum(char x)
    {
        return x - '0';
    }

    public bool Is2Digits(int x)
    {
        return (x >= 10 && x <= 99) || (x >= -99 && x <= -10);
    }

    public bool IsInRange(int a, int b, int num)
    {
        return (num >= a && num <= b) || (num >= b && num <= a);
    }

    public bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // Задание 2. Условия.
    public int Abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }

        return x;
    }

    public bool Is35(int x)
    {
        if (x % 3 == 0 && x % 5 == 0)
        {
            return false;
        }

        return x % 3 == 0 || x % 5 == 0;
    }

    public int Max3(int x, int y, int z)
    {
        int maximum = x;

        if (y > maximum)
        {
            maximum = y;
        }

        if (z > maximum)
        {
            maximum = z;
        }

        return maximum;
    }

    public int Sum2(int x, int y)
    {
        int sum = x + y;

        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }

        return sum;
    }

    public string Day(int x)
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }

    // Задание 3. Циклы.
    public string ListNums(int x)
    {
        string result = "0";

        for (int i = 1; i <= x; i++)
        {
            result += " " + i;
        }

        return result;
    }

    public string Chet(int x)
    {
        string result = "0";

        for (int i = 2; i <= x; i += 2)
        {
            result += " " + i;
        }

        return result;
    }

    public int NumLen(long x)
    {
        int length = 0;

        do
        {
            length++;
            x /= 10;
        }
        while (x != 0);

        return length;
    }

    public void Square(int x)
    {
        for (int row = 0; row < x; row++)
        {
            for (int column = 0; column < x; column++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }
    }

    public void RightTriangle(int x)
    {
        for (int row = 1; row <= x; row++)
        {
            for (int space = 0; space < x - row; space++)
            {
                Console.Write(' ');
            }

            for (int star = 0; star < row; star++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }
    }

    // Задание 4. Массивы. Индексы начинаются с нуля.
    public int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }

    public int MaxAbs(int[] arr)
    {
        int maximum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            // Приведение к long защищает модуль int.MinValue от переполнения.
            if (Math.Abs((long)arr[i]) > Math.Abs((long)maximum))
            {
                maximum = arr[i];
            }
        }

        return maximum;
    }

    public int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];

        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[i + ins.Length] = arr[i];
        }

        return result;
    }

    public int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }

    public int[] FindAll(int[] arr, int x)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[index] = i;
                index++;
            }
        }

        return result;
    }

    private void ShowTasks(int assignment)
    {
        Console.WriteLine();

        switch (assignment)
        {
            case 1:
                Console.WriteLine("1 — Дробная часть\n2 — Букву в число\n3 — Двузначное\n4 — Диапазон\n5 — Равенство");
                break;
            case 2:
                Console.WriteLine("1 — Модуль числа\n2 — Тридцать пять\n3 — Тройной максимум\n4 — Двойная сумма\n5 — День недели");
                break;
            case 3:
                Console.WriteLine("1 — Числа подряд\n2 — Чётные числа\n3 — Длина числа\n4 — Квадрат\n5 — Правый треугольник");
                break;
            case 4:
                Console.WriteLine("1 — Поиск первого значения\n2 — Поиск максимального\n3 — Добавление массива в массив\n4 — Возвратный реверс\n5 — Все вхождения");
                break;
        }
    }

    private void SolveTask(int assignment, int task)
    {
        Console.WriteLine($"\nЗадание {assignment}, задача {task}");

        switch (assignment * 10 + task)
        {
            case 11:
                Console.WriteLine($"Результат: {Fraction(ReadDouble("x"))}");
                break;
            case 12:
                Console.WriteLine($"Результат: {CharToNum(ReadDigit())}");
                break;
            case 13:
                ShowBool(Is2Digits(ReadInt("x")));
                break;
            case 14:
                {
                    int a = ReadInt("a");
                    int b = ReadInt("b");
                    int num = ReadInt("num");
                    ShowBool(IsInRange(a, b, num));
                    break;
                }
            case 15:
                {
                    int a = ReadInt("a");
                    int b = ReadInt("b");
                    int c = ReadInt("c");
                    ShowBool(IsEqual(a, b, c));
                    break;
                }
            case 21:
                Console.WriteLine($"Результат: {Abs(ReadInt("x", -int.MaxValue, int.MaxValue))}");
                break;
            case 22:
                ShowBool(Is35(ReadInt("x")));
                break;
            case 23:
                {
                    int x = ReadInt("x");
                    int y = ReadInt("y");
                    int z = ReadInt("z");
                    Console.WriteLine($"Результат: {Max3(x, y, z)}");
                    break;
                }
            case 24:
                {
                    Console.WriteLine("Числа ограничены миллиардом по модулю, чтобы сумма помещалась в int.");
                    int x = ReadInt("x", -1000000000, 1000000000);
                    int y = ReadInt("y", -1000000000, 1000000000);
                    Console.WriteLine($"Результат: {Sum2(x, y)}");
                    break;
                }
            case 25:
                Console.WriteLine($"Результат: {Day(ReadInt("x (1–7 — дни недели, иначе сообщение об ошибке)"))}");
                break;
            case 31:
                Console.WriteLine($"Результат: {ListNums(ReadInt("x (неотрицательное число)", 0))}");
                break;
            case 32:
                Console.WriteLine($"Результат: {Chet(ReadInt("x (неотрицательное число)", 0))}");
                break;
            case 33:
                Console.WriteLine($"Результат: {NumLen(ReadLong("x"))}");
                break;
            case 34:
                {
                    int x = ReadInt("Размер квадрата (натуральное число)", 1);
                    Console.WriteLine("Результат:");
                    Square(x);
                    break;
                }
            case 35:
                {
                    int x = ReadInt("Высота треугольника (натуральное число)", 1);
                    Console.WriteLine("Результат:");
                    RightTriangle(x);
                    break;
                }
            case 41:
                {
                    int[] arr = ReadArray("arr");
                    int x = ReadInt("Искомое число x");
                    Console.WriteLine($"Результат: {FindFirst(arr, x)}");
                    break;
                }
            case 42:
                {
                    int[] arr = ReadArray("arr", 1);
                    Console.WriteLine($"Результат: {MaxAbs(arr)}");
                    break;
                }
            case 43:
                {
                    int[] arr = ReadArray("arr");
                    int[] ins = ReadArray("ins");
                    int pos = ReadInt("Позиция вставки (индексы начинаются с 0)", 0, arr.Length);
                    Console.WriteLine($"Результат: {FormatArray(Add(arr, ins, pos))}");
                    break;
                }
            case 44:
                {
                    int[] arr = ReadArray("arr");
                    Console.WriteLine($"Результат: {FormatArray(ReverseBack(arr))}");
                    Console.WriteLine($"Исходный массив: {FormatArray(arr)}");
                    break;
                }
            case 45:
                {
                    int[] arr = ReadArray("arr");
                    int x = ReadInt("Искомое число x");
                    Console.WriteLine($"Результат: {FormatArray(FindAll(arr, x))}");
                    break;
                }
        }
    }

    private int ReadInt(string prompt, int minimum = int.MinValue, int maximum = int.MaxValue)
    {
        int value;

        do
        {
            Console.Write($"{prompt}: ");
            value = int.Parse(Console.ReadLine());

            if (value < minimum || value > maximum)
            {
                Console.WriteLine("Значение не подходит. Повторите ввод.");
            }
        }
        while (value < minimum || value > maximum);

        return value;
    }

    private long ReadLong(string prompt)
    {
        Console.Write($"{prompt}: ");
        return long.Parse(Console.ReadLine());
    }

    private double ReadDouble(string prompt)
    {
        Console.Write($"{prompt}: ");
        string input = Console.ReadLine().Replace('.', ',');
        return double.Parse(input);
    }

    private char ReadDigit()
    {
        while (true)
        {
            Console.Write("Введите один символ от '0' до '9': ");
            string input = Console.ReadLine();

            if (input.Length == 1 && input[0] >= '0' && input[0] <= '9')
            {
                return input[0];
            }

            Console.WriteLine("Ошибка: нужна одна цифра от 0 до 9.");
        }
    }

    private int[] ReadArray(string name, int minimumLength = 0)
    {
        int length = ReadInt($"Количество элементов массива {name} (не меньше {minimumLength})", minimumLength);
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReadInt($"{name}[{i}]");
        }

        Console.WriteLine($"{name} = {FormatArray(arr)}");
        return arr;
    }

    private void ShowBool(bool value)
    {
        Console.WriteLine($"Результат: {value.ToString().ToLowerInvariant()}");
    }

    private string FormatArray(int[] arr)
    {
        return "[" + string.Join(", ", arr) + "]";
    }
}
