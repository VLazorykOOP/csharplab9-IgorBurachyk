using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Читання тексту з файлу або введення тексту вручну
        string text = "Українські міста: Київ, Львів, Одеса, Харків. Ці міста мають багато історичних пам'яток.";

        // Розділення тексту на слова
        string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // ArrayList для зберігання слів
        ArrayList vowelsList = new ArrayList();
        ArrayList consonantsList = new ArrayList();

        // Хеш-множина голосних букв
        HashSet<char> vowels = new HashSet<char> { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я', 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я' };

        // Розподілення слів за першою літерою
        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                char firstChar = char.ToLower(word[0]);
                if (vowels.Contains(firstChar))
                {
                    vowelsList.Add(word);
                }
                else
                {
                    consonantsList.Add(word);
                }
            }
        }

        // Виведення результатів
        Console.WriteLine("Слова, що починаються на гласну букву:");
        foreach (string word in vowelsList)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine();

        Console.WriteLine("Слова, що починаються на приголосну букву:");
        foreach (string word in consonantsList)
        {
            Console.WriteLine(word);
        }
    }
}
