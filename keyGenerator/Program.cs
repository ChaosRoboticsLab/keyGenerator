using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "C:\\Users\\Chaos\\RiderProjects\\keyGenerator\\keyGenerator\\wordList.txt"; 

        List<string> words = new List<string>();
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    words.AddRange(line.Split(' '));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка чтения файла:");
            Console.WriteLine(e.Message);
            return;
        }

        Random rnd = new Random();
        string newWord = "";
        for (int i = 0; i < 3; i++)
        {
            int index = rnd.Next(words.Count);
            string selectedWord = words[index];
            newWord += selectedWord.Length >= 3 ? selectedWord.Substring(0, 3) : selectedWord;
        }

        Console.WriteLine("Пароль: " + newWord);
    }
}
