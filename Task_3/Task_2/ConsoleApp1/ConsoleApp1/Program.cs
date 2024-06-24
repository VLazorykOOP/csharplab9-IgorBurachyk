using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Читання тексту з файлу або введення тексту вручну
        string text = "абввба, рівень, лівів, повік, сон, кіт, ротор, лігілі, мама, тигр, ремінь, казак.";

        // Розділення тексту на слова
        string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // ArrayList для зберігання симетричних слів
        ArrayList symmetricWords = new ArrayList();

        // Пошук і додавання симетричних слів
        foreach (string word in words)
        {
            if (IsSymmetric(word))
            {
                symmetricWords.Add(word);
            }
        }

        // Виведення результатів
        Console.WriteLine("Симетричні слова у тексті:");
        foreach (string symmetricWord in symmetricWords)
        {
            Console.WriteLine(symmetricWord);
        }
    }

    // Метод для перевірки, чи є слово симетричним
    static bool IsSymmetric(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
