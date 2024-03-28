using System;
using System.Collections;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        // Task1

        //Console.Write("1 - Create and Write | 2 - Read: ");
        //int enter = int.Parse(Console.ReadLine());

        //if (enter == 1)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        Console.WriteLine("Error u dont enter filename");
        //        return;
        //    }
        //    filePath += ".txt";


        //    Console.Write("Enter something: ");
        //    string content = Console.ReadLine();
        //    if (filePath == null || filePath == "")
        //    {
        //        Console.WriteLine("Error u dont enter content");
        //        return;
        //    }

        //    try
        //    {
        //        // Створення нового файлу або перезапис існуючого
        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            writer.WriteLine(content);
        //        }

        //        Console.WriteLine($"Файл {filePath} успішно створено");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Помилка: " + ex.Message);
        //    }
        //}
        //else if (enter == 2)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (filePath == null || filePath == "")
        //    {
        //        Console.WriteLine("Error u dont enter filename");
        //        return;
        //    }
        //    filePath += ".txt";

        //    try
        //    {
        //        // Відкриваємо файл для читання
        //        using (StreamReader reader = new StreamReader(filePath))
        //        {
        //            string content = reader.ReadToEnd(); // зчитуємо вміст файлу
        //            Stack<char> vowels = new Stack<char>(); // Створюємо стек для зберігання голосних букв

        //            // Розбиваємо рядок на окремі символи (букви)
        //            foreach (char letter in content)
        //            {
        //                if (IsVowel(letter))
        //                {
        //                    vowels.Push(letter); // Додаємо голосні букви до стеку
        //                }
        //            }

        //            Console.Write("Голоснi: ");
        //            while (vowels.Count > 0)
        //            {
        //                char vowel = vowels.Pop(); // Вилучаємо голосні букви з вершини стеку
        //                Console.Write($"`{vowel}` ");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Помилка при читанні файлу: " + ex.Message);
        //    }
        //}
        //else return;

        // Task1
        // Task2

        //Console.Write("1 - Create and Write | 2 - Read: ");
        //int enter = int.Parse(Console.ReadLine());

        //if (enter == 1)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (filePath == null || filePath == "")
        //    {
        //        Console.WriteLine("Error u dont enter filename");
        //        return;
        //    }
        //    filePath += ".txt";


        //    Console.Write("Enter something: ");
        //    string content = Console.ReadLine();
        //    if (filePath == null || filePath == "")
        //    {
        //        Console.WriteLine("Error u dont enter content");
        //        return;
        //    }

        //    try
        //    {
        //        // Створення нового файлу або перезапис існуючого
        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            writer.WriteLine(content);
        //        }

        //        Console.WriteLine($"Файл {filePath} успішно створено");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Помилка: " + ex.Message);
        //    }
        //}
        //else if (enter == 2)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        Console.WriteLine("Error u dont enter filename");
        //        return;
        //    }
        //    filePath += ".txt";

        //    try
        //    {
        //        // Відкриваємо файл для читання
        //        using (StreamReader reader = new StreamReader(filePath))
        //        {
        //            string content = reader.ReadToEnd(); // зчитуємо вміст файлу
        //            Queue<int> numbers = new Queue<int>();
        //            Queue<int> aNums = new Queue<int>();
        //            Queue<int> bNums = new Queue<int>();

        //            // Розділяємо рядок на слова та перевіряємо кожне слово на число
        //            string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        //            foreach (string word in words)
        //            {
        //                if (int.TryParse(word, out int number))
        //                {
        //                    numbers.Enqueue(number);
        //                }
        //            }

        //            // Перше число з черги numbers
        //            int a = numbers.Count > 0 ? numbers.Peek() : 0;
        //            // Останнє число з черги numbers
        //            int b = numbers.Count > 0 ? numbers.Last() : 0;

        //            Console.Write("Numbers: ");
        //            while (numbers.Count > 0)
        //            {
        //                int number = numbers.Dequeue();

        //                if (number < a)
        //                {
        //                    aNums.Enqueue(number);
        //                }
        //                else if (number > b)
        //                {
        //                    bNums.Enqueue(number);
        //                }

        //                Console.Write($"{number} ");
        //            }

        //            Console.WriteLine($"\nFirst and last: {a}, {b}");

        //            Console.Write("Numbers < a: ");
        //            while (aNums.Count > 0)
        //            {
        //                int number = aNums.Dequeue();
        //                Console.Write($"{number} ");
        //            }

        //            Console.Write("\nNumbers > b: ");
        //            while (bNums.Count > 0)
        //            {
        //                int number = bNums.Dequeue();
        //                Console.Write($"{number} ");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Помилка при читанні файлу: " + ex.Message);
        //    }
        //}
        //else return;

        // Task2
        // Task3.1

        //Console.Write("1 - Create and Write | 2 - Read: ");
        //int enter = int.Parse(Console.ReadLine());

        //if (enter == 1)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        Console.WriteLine("Error: you didn't enter a filename.");
        //        return;
        //    }
        //    filePath += ".txt";

        //    Console.Write("Enter something: ");
        //    string content = Console.ReadLine();
        //    if (string.IsNullOrEmpty(content))
        //    {
        //        Console.WriteLine("Error: you didn't enter content.");
        //        return;
        //    }

        //    try
        //    {
        //        // Створення нового файлу або перезапис існуючого
        //        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
        //        {
        //            writer.WriteLine(content);
        //        }

        //        Console.WriteLine($"File {filePath} successfully created.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //}
        //else if (enter == 2)
        //{
        //    Console.Write("Filename: ");
        //    string filePath = Console.ReadLine();
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        Console.WriteLine("Error: you didn't enter a filename.");
        //        return;
        //    }
        //    filePath += ".txt";

        //    try
        //    {
        //        // Відкриваємо файл для читання
        //        using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
        //        {
        //            string content = reader.ReadToEnd(); // зчитуємо вміст файлу
        //            ArrayList vowels = new ArrayList(); // Створюємо ArrayList для зберігання голосних букв

        //            // Розбиваємо рядок на окремі символи (букви) та перевіряємо, чи є вони голосними
        //            foreach (char letter in content)
        //            {
        //                if (IsVowel(letter))
        //                {
        //                    vowels.Add(letter); // Додаємо голосні букви до ArrayList
        //                }
        //            }

        //            vowels.Reverse();

        //            Console.Write("Vowels: ");
        //            foreach (char vowel in vowels)
        //            {
        //                Console.Write($"`{vowel}` ");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error reading file: " + ex.Message);
        //    }
        //}
        //else return;

        // Task3.1
        // Task3.2

        Console.Write("1 - Create and Write | 2 - Read: ");
        int enter = int.Parse(Console.ReadLine());

        if (enter == 1)
        {
            Console.Write("Filename: ");
            string filePath = Console.ReadLine();
            if (string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("Error u dont enter filename");
                return;
            }
            filePath += ".txt";

            Console.Write("Enter something: ");
            string content = Console.ReadLine();
            if (string.IsNullOrEmpty(content))
            {
                Console.WriteLine("Error u dont enter content");
                return;
            }

            try
            {
                ArrayList list = new ArrayList();
                list.Add(content);

                // Створення нового файлу або перезапис існуючого
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in list)
                    {
                        writer.WriteLine(item);
                    }
                }

                Console.WriteLine($"File {filePath} successfully created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        else if (enter == 2)
        {
            Console.Write("Filename: ");
            string fileName = Console.ReadLine();
            string filePath = fileName + ".txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error file does not exist");
                return;
            }

            try
            {
                // Відкриваємо файл для читання
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ArrayList numbers = new ArrayList();
                    string line;

                    // Зчитуємо рядок з файлу
                    line = reader.ReadLine();
                    Console.WriteLine($"Read line from file: {line}");

                    // Розділяємо рядок на окремі числа та додаємо їх до списку
                    string[] numberStrings = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string numString in numberStrings)
                    {
                        if (int.TryParse(numString, out int number))
                        {
                            numbers.Add(number);
                        }
                    }

                    // Виводимо всі цифри з файлу
                    Console.Write("Numbers from the file: ");
                    foreach (var number in numbers)
                    {
                        Console.Write($"{number} ");
                    }

                    // Знаходимо перше і останнє число
                    int a = numbers.Count > 0 ? (int)numbers[0] : 0;
                    int b = numbers.Count > 0 ? (int)numbers[numbers.Count - 1] : 0;

                    Console.WriteLine($"\nFirst: {a}, Last: {b}");

                    // Виводимо всі числа менші за перше число
                    Console.Write($"Numbers < a: ");
                    foreach (var number in numbers)
                    {
                        if ((int)number < a)
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    // Виводимо всі числа більші за останнє число
                    Console.Write($"\nNumbers > b: ");
                    foreach (var number in numbers)
                    {
                        if ((int)number > b)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
        else return;

        // Task3.2
    }

    // Task1 + 3
    static bool IsVowel(char letter)
    {
        switch (char.ToLower(letter))
        {
            case 'а':
            case 'о':
            case 'е':
            case 'и':
            case 'у':
            case 'я':
            case 'ю':
            case 'є':
            case 'і':
                return true;
            default:
                return false;
        }
    }
    // Task1 + 3
}