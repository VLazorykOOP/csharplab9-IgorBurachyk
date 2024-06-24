using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "D:\\University\\Третій курс\\Крос-платформне програмування\\Тести\\Lab_9\\t.txt"; // шлях до файлу t.txt
        string outputPath = "D:\\University\\Третій курс\\Крос-платформне програмування\\Тести\\Lab_9\\reversed_t.txt"; // шлях до вихідного файлу зі зворотнім порядком символів

        try
        {
            // Читаємо вміст файлу t.txt по рядках
            string[] lines = File.ReadAllLines(filePath);

            // Створюємо список для зберігання результатів
            List<string> reversedLines = new List<string>();

            // Проходимося по кожному рядку
            foreach (string line in lines)
            {
                // Створюємо стек для поточного рядка
                Stack<char> stack = new Stack<char>();

                // Додаємо кожен символ рядка у стек
                foreach (char c in line)
                {
                    stack.Push(c);
                }

                // Формуємо рядок зі зворотнім порядком символів
                string reversedLine = "";
                while (stack.Count > 0)
                {
                    reversedLine += stack.Pop();
                }

                // Додаємо отриманий рядок до списку
                reversedLines.Add(reversedLine);
            }

            // Записуємо результат у новий файл reversed_t.txt
            File.WriteAllLines(outputPath, reversedLines);

            Console.WriteLine($"Файл {outputPath} успішно створено зі зворотнім порядком символів.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
