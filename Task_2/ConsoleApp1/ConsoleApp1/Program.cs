using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "D:\\University\\Третій курс\\Крос-платформне програмування\\Тести\\Lab_9\\Task_2\\text.txt"; // шлях до текстового файлу

        try
        {
            // Читаємо вміст файлу і розділяємо його на слова
            string[] words = File.ReadAllText(filePath)
                                .Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Створюємо черги для гласних і приголосних слів
            Queue<string> vowelWords = new Queue<string>();
            Queue<string> consonantWords = new Queue<string>();

            // Визначаємо гласні букви
            HashSet<char> vowels = new HashSet<char> { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я', 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я' };

            // Розділяємо слова на дві черги: гласні і приголосні
            foreach (var word in words)
            {
                if (word.Length > 0)
                {
                    char firstChar = word[0];

                    if (vowels.Contains(firstChar))
                    {
                        vowelWords.Enqueue(word);
                    }
                    else
                    {
                        consonantWords.Enqueue(word);
                    }
                }
            }

            // Виводимо слова спочатку з черги з гласними словами, потім з черги з приголосними словами
            Console.WriteLine("Слова, які починаються на голосну букву:");
            while (vowelWords.Count > 0)
            {
                Console.WriteLine(vowelWords.Dequeue());
            }

            Console.WriteLine();

            Console.WriteLine("Слова, які починаються на приголосну букву:");
            while (consonantWords.Count > 0)
            {
                Console.WriteLine(consonantWords.Dequeue());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
