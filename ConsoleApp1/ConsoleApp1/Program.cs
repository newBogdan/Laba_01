using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Определение переменных всех примитивных типов
        bool boolV;
        byte byteV;
        sbyte sbyteV;
        short shortV;
        ushort ushortV;
        int intV;
        uint uintV;
        long longV;
        ulong ulongV;
        float floatV;
        double doubleV;
        decimal decimalV;
        char charV;
        string stringV;
        /*
            bool - логический тип данных (true или false)
            byte - беззнаковое целое число от 0 до 255
            sbyte - знаковое целое число от -128 до 127
            short - 16-битное знаковое целое число (-32,768 до 32,767)
            ushort - 16-битное беззнаковое целое число (от 0 до 65,535)
            int - 32-битное знаковое целое число (-2,147,483,648 до 2,147,483,647)
            uint - 32-битное беззнаковое целое число (от 0 до 4,294,967,295)
            long - 64-битное знаковое целое число (-9,223,372,036,854,775,808 до 9,223,372,036,854,775,807)
            ulong - 64-битное беззнаковое целое число (от 0 до 18,446,744,073,709,551,615)
            float - 32-битное число с плавающей точкой
            double - 64-битное число с плавающей точкой
            decimal - 128-битное десятичное число с фиксированной точкой
            char - 16-битный символ Юникода
            string - набор символов Юникода
        */
        Console.WriteLine("\tЗадание 1/a");
        // Ввод значений с клавиатуры
        Console.Write("Введите значение типа bool: ");
        boolV = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Введите значение типа byte: ");
        byteV = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите значение типа sbyte: ");
        sbyteV = Convert.ToSByte(Console.ReadLine());

        Console.Write("Введите значение типа short: ");
        shortV = Convert.ToInt16(Console.ReadLine());

        Console.Write("Введите значение типа ushort: ");
        ushortV = Convert.ToUInt16(Console.ReadLine());

        Console.Write("Введите значение типа int: ");
        intV = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение типа uint: ");
        uintV = Convert.ToUInt32(Console.ReadLine());

        Console.Write("Введите значение типа long: ");
        longV = Convert.ToInt64(Console.ReadLine());

        Console.Write("Введите значение типа ulong: ");
        ulongV = Convert.ToUInt64(Console.ReadLine());

        Console.Write("Введите значение типа float: ");
        floatV = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите значение типа double: ");
        doubleV = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение типа decimal: ");
        decimalV = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите значение типа char: ");
        charV = Convert.ToChar(Console.ReadLine());

        Console.Write("Введите значение типа string: ");
        stringV = Console.ReadLine();

        Console.WriteLine("\nРезультат: ");
        Console.WriteLine("bool: " + boolV);
        Console.WriteLine("byte: " + byteV);
        Console.WriteLine("sbyte: " + sbyteV);
        Console.WriteLine("short: " + shortV);
        Console.WriteLine("ushort: " + ushortV);
        Console.WriteLine("int: " + intV);
        Console.WriteLine("uint: " + uintV);
        Console.WriteLine("long: " + longV);
        Console.WriteLine("ulong: " + ulongV);
        Console.WriteLine("float: " + floatV);
        Console.WriteLine("double: " + doubleV);
        Console.WriteLine("decimal: " + decimalV);
        Console.WriteLine("char: " + charV);
        Console.WriteLine("string: " + stringV);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 1/b");

        // Явное приведение
        double explicitDouble = 3.14;
        int explicitInt = (int)explicitDouble; // Явное приведение double к int
        Console.WriteLine("Явное приведение double к int: " + explicitInt);

        long explicitLong = 1000000;
        int explicitInt2 = (int)explicitLong; // Явное приведение long к int
        Console.WriteLine("Явное приведение long к int: " + explicitInt2);

        float explicitFloat = 2.718f;
        int explicitInt3 = (int)explicitFloat; // Явное приведение float к int
        Console.WriteLine("Явное приведение float к int: " + explicitInt3);

        int explicitInt4 = 65;
        char explicitChar = (char)explicitInt4; // Явное приведение int к char
        Console.WriteLine("Явное приведение int к char: " + explicitChar);

        int explicitInt5 = 97;
        char explicitChar2 = (char)explicitInt5; // Явное приведение int к char
        Console.WriteLine("Явное приведение int к char: " + explicitChar2 + "\n");

        // Неявное приведение
        int implicitInt = 100;
        double implicitDouble1 = implicitInt; // Неявное приведение int к double
        Console.WriteLine("Неявное приведение int к double: " + implicitDouble1);

        int implicitInt2 = 65;
        char implicitChar = (char)implicitInt2; // Неявное приведение int к char
        Console.WriteLine("Неявное приведение int к char: " + implicitChar);

        long implicitLong = 99999999999;
        double implicitDouble2 = implicitLong; // Неявное приведение long к double
        Console.WriteLine("Неявное приведение long к double: " + implicitDouble2);

        ushort implicitUShort = 10000;
        int implicitInt3 = implicitUShort; // Неявное приведение ushort к int
        Console.WriteLine("Неявное приведение ushort к int: " + implicitInt3);

        int implicitInt4 = 97;
        char implicitChar2 = (char)implicitInt4; // Неявное приведение int к char
        Console.WriteLine("Неявное приведение int к char: " + implicitChar2);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 1/c");

        int intValue = 42;
        object boxedInt = intValue; // упаковка значения типа int в объект

        double doubleValue = 3.14;
        object boxedDouble = doubleValue; // упаковка значения типа double в объект

        bool boolValue = true;
        object boxedBool = boolValue; // упаковка значения типа bool в объект

        char charValue = 'A';
        object boxedChar = charValue; // упаковка значения типа char в объект

        decimal decimalValue = 10.5m;
        object boxedDecimal = decimalValue; // упаковка значения типа decimal в объект

        // Распаковка
        int uboxedInt = (int)boxedInt; // распаковка объекта в тип int
        double uboxedDouble = (double)boxedDouble; // распаковка объекта в тип double
        bool uboxedBool = (bool)boxedBool; // распаковка объекта в тип bool
        char uboxedChar = (char)boxedChar; // распаковка объекта в тип char
        decimal uboxedDecimal = (decimal)boxedDecimal; // распаковка объекта в тип decimal

        Console.WriteLine("Распакованные значения: ");
        Console.WriteLine("Распакованное значение int: " + uboxedInt);
        Console.WriteLine("Распакованное значение double: " + uboxedDouble);
        Console.WriteLine("Распакованное значение bool: " + uboxedBool);
        Console.WriteLine("Распакованное значение char: " + uboxedChar);
        Console.WriteLine("Распакованное значение decimal: " + uboxedDecimal);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 1/d");

        var name = "Богдан"; // неявно типизированная переменная name будет иметь тип string
        var age = 18; // неявно типизированная переменная age будет иметь тип int
        var day = 11; // неявно типизированная переменная day будет иметь тип int
        var isValid = true; // неявно типизированная переменная isValid будет иметь тип bool
        var pi = 3.14; // неявно типизированная переменная pi будет иметь тип double

        var sum = age + day; // sum будет иметь тип int
        var fullName = "Тарасик " + name; // fullName будет иметь тип string
        var isValidString = isValid.ToString(); // isValidString будет иметь тип string

        Console.WriteLine("Результат: ");
        Console.WriteLine("Неявно типизированная переменная sum: " + sum);
        Console.WriteLine("Неявно типизированная переменная fullName: " + fullName);
        Console.WriteLine("Неявно типизированная переменная pi: " + pi);
        Console.WriteLine("Неявно типизированная переменная isValidString: " + isValidString);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 1/e");

        int? nullableInt = null;
        Console.WriteLine(nullableInt);  // Вывод: null

        nullableInt = 42;
        Console.WriteLine(nullableInt);  // Вывод: 42

        int regularInt = nullableInt ?? 0;
        Console.WriteLine(regularInt);  // Вывод: 42


        Console.ReadLine();
        Console.WriteLine("\tЗадание 1/f");
        Console.WriteLine("В коде в комментарии");
        /*
        var myVariable = "Hello";
        Console.WriteLine(myVariable);  // Вывод: Hello

        myVariable = 42;
        Console.WriteLine(myVariable);
        */

        Console.ReadLine();
        Console.WriteLine("\tЗадание 2/a");

        string str1 = "Hello";
        string str2 = "World";
        if (str1 == str2)
        {
            Console.WriteLine("Строки равны.");
        }
        else
        {
            Console.WriteLine("Строки не равны.");
        }

        string str3 = "Hello";
        string str4 = "Hello";
        if (str3 == str4)
        {
            Console.WriteLine("Строки равны.");
        }
        else
        {
            Console.WriteLine("Строки не равны.");
        }

        Console.ReadLine();
        Console.WriteLine("\tЗадание 2/b");

        string str5 = "Hello";
        string str6 = "world";

        // Сцепление строк
        string str7 = str5 + " " + str6;
        Console.WriteLine("Сцепление строк: " + str7);

        // Копирование строки
        string str8 = String.Copy(str5);
        Console.WriteLine("Копирование строки: " + str8);

        // Выделение подстроки
        string substr = str7.Substring(6, 5); // начиная с индекса 6, длиной 5 символов
        Console.WriteLine("Выделение подстроки: " + substr);

        // Разделение строки на слова
        string[] words = str7.Split(' ');
        Console.WriteLine("Разделение строки на слова:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Вставка подстроки в заданную позицию
        string newStr = str5.Insert(3, " there");
        Console.WriteLine("Вставка подстроки в заданную позицию: " + newStr);

        // Удаление заданной подстроки
        string removedStr = str7.Remove(6, 5);
        Console.WriteLine("Удаление заданной подстроки: " + removedStr);

        string name1 = "Богдан";
        int age1 = 18;
        Console.WriteLine($"Моё имя {name1} и мне {age1} лет.");

        Console.ReadLine();
        Console.WriteLine("\tЗадание 2/c");

        string emptyString = "";
        string nullString = null;

        // Проверка, является ли строка пустой или равной null
        bool isEmptyOrNull = string.IsNullOrEmpty(emptyString);
        Console.WriteLine("emptyString = null или пустая? " + isEmptyOrNull);

        isEmptyOrNull = string.IsNullOrEmpty(nullString);
        Console.WriteLine("nullString = null или пустая? " + isEmptyOrNull);

        // Получение длины строки
        int length = emptyString.Length;
        Console.WriteLine("Длина строки emptyString: " + length);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 2/d");

        // Создание строки на основе StringBuilder
        StringBuilder stringBuild = new StringBuilder("Hello, World!");

        // Удаление символа на позиции 7
        stringBuild.Remove(7, 1);

        // Добавление символов в начало и конец строки
        stringBuild.Insert(0, "Начало ");
        stringBuild.Append(" Конец");

        // Вывод окончательной строки
        Console.WriteLine(stringBuild.ToString());

        Console.ReadLine();
        Console.WriteLine("\tЗадание 3/a");

        // Создание двумерного массива размером 3x3
        int[,] matrix = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        // Вывод двумерного массива на консоль
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
        Console.WriteLine("\tЗадание 3/b");

        // Создание одномерного массива строк
        string[] array = { "строка1", "строка2", "строка3", "строка4", "строка5" };
        // Вывод содержимого массива
        Console.WriteLine("Содержимое массива:");
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
        // Вывод длины массива
        Console.WriteLine("Длина массива: " + array.Length);
        // Пользователь выбирает позицию и значение для замены
        Console.WriteLine("Введите позицию элемента для замены (от 0 до " + (array.Length - 1) + "):");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новое значение:");
        string value = Console.ReadLine();
        // Замена элемента массива
        array[position] = value;
        // Вывод обновленного содержимого массива
        Console.WriteLine("Обновленное содержимое массива:");
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine();
        Console.WriteLine("\tЗадание 3/c");

        double[][] array1 = new double[3][];
        Console.WriteLine("Введите значения для первой строки (2 столбца):");
        array1[0] = new double[2];
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Значение для столбца {i + 1}: ");
            array1[0][i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Введите значения для второй строки (3 столбца):");
        array1[1] = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Значение для столбца {i + 1}: ");
            array1[1][i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Введите значения для третьей строки (4 столбца):");
        array1[2] = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Значение для столбца {i + 1}: ");
            array1[2][i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Ступенчатый массив вещественных чисел:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < array1[i].Length; j++)
            {
                Console.Write(array1[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
        Console.WriteLine("\tЗадание 3/d");

        var array2 = new[] { 1, 2, 3, 4, 5 };
        var str9 = "Hello, World!";

        Console.WriteLine("Неявно типизированная переменная для хранения массива: " + string.Join( ",", array2));
        Console.WriteLine("Неявно типизированная переменная для хранения строки: " + str9);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 4/a и b");

        (int, string, char, string, ulong) cortege = (5, "Hello", 'A', "World", 20 );
        Console.WriteLine(cortege);
        Console.WriteLine(cortege.Item1);
        Console.WriteLine(cortege.Item3);
        Console.WriteLine(cortege.Item4);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 4/c");

        var tuple1 = (1, "Hello", 3.14);//Распаковка элементов с использованием типов данных
        (int a1, string b1, double c1) = tuple1;
        Console.WriteLine(a1);
        Console.WriteLine(b1);
        Console.WriteLine(c1);
        Console.WriteLine(" ");

        var tuple2 = (1, "Hello", 3.14, "World");//Распаковка только нужных элементов
        var (a2, _, c2, _) = tuple2;
        Console.WriteLine(a2);
        Console.WriteLine(c2);
        Console.WriteLine(" ");

        var tuple = (1, "Hello", 3.14);//Распаковка элементов
        var (a, b, c) = tuple;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(" ");

        Console.ReadLine();
        Console.WriteLine("\tЗадание 4/d");

        (int a, byte b) left = (5, 10);
        (long a, int b) right = (5, 10);
        Console.WriteLine(left == right);
        Console.WriteLine(left != right);

        Console.ReadLine();
        Console.WriteLine("\tЗадание 5");

        int[] numbers = { 1, 2, 3, 4, 5 };
        string text = "Hello";
        (int max, int min, int sum, char firstLetter) result = GetArrayInfo(numbers, text);
        Console.WriteLine($"Max: {result.max}");
        Console.WriteLine($"Min: {result.min}");
        Console.WriteLine($"Sum: {result.sum}");
        Console.WriteLine($"First letter: {result.firstLetter}");

        Console.ReadLine();
        Console.WriteLine("\tЗадание 6");

        FunctionWithCheckedBlock();
        FunctionWithUncheckedBlock();


    }

    //Локальная функция к 5 заданию
    static (int max, int min, int sum, char firstLetter) GetArrayInfo(int[] array, string text)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        foreach (int num in array)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
            sum += num;
        }
        char firstLetter = text[0];
        return (max, min, sum, firstLetter);
    }

    static void FunctionWithCheckedBlock()
    {
        checked
        {
            int maxValue = int.MaxValue;
            Console.WriteLine("Значение в блоке checked: " + maxValue);
        }

    }
    static void FunctionWithUncheckedBlock()
    {
        unchecked
        {
            int maxValue = int.MaxValue;
            Console.WriteLine("Значение в блоке unchecked: " + maxValue);
        }
    }
}