using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t', ',', '.', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '"', '\'' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.IndexOf('n') >= 0)
                    {
                        if (result.Length > 0)
                            result.Append(" ");
                        result.Append(word);
                    }
                }
            }

            return result.Length > 0 ? result.ToString() : "Слов с буквой 'n' не найдено.";
        }
    }
}
