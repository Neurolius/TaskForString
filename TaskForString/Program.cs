namespace TaskForString
{
    public class Sentence
    {
        public string Text { get; set; }
        
        public int GetLetterCount()
        {
            int count = 0;
            foreach (char c in Text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int GetLength()
        {
            return Text?.Length??0;
        }
        public string GetLowerText()
        {
            return Text?.ToLower()??string.Empty;
        }
    }
    
    public static class ConsoleUI
    {
        public static Sentence ReadSentace()
        {
            Console.WriteLine("Введите предложение");
            string? input = Console.ReadLine();
            return new Sentence { Text = input };
        }
        public static void PrintResult(double percent, Dictionary<string, int> letterPercents)
        {
            Console.WriteLine($"Процент букв в предложении: {percent:F2}%");
            Console.WriteLine("Процент каждой буквы:");
            foreach (var kvp in letterPercents)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}%");
            }
        }
    }

    public class Logic
    {
        public static double CalculateLetterPercent(Sentence sentence)
        {
            int letterCount = sentence.GetLetterCount();
            int totalLength = sentence.GetLength();
            if (totalLength == 0) return 0;
            return (double)letterCount / totalLength * 100;
        }

        public static Dictionary<string, int> CalculateEachLetterPercent(Sentence sentence)
        {
            var result = new Dictionary<string, int>();
            string lowerText = sentence.GetLowerText();
            int totalLength = sentence.GetLength();
            if (totalLength == 0) return result;
            foreach (char c in lowerText)
            {
                if (char.IsLetter(c))
                {
                    string letter = c.ToString();
                    if (!result.ContainsKey(letter))
                    {
                        result[letter] = 0;
                    }
                    result[letter]++;
                }
            }
            foreach (var key in result.Keys.ToList())
            {
                result[key] = (int)((double)result[key] / totalLength * 100);
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = ConsoleUI.ReadSentace();
            var letterPercent = Logic.CalculateLetterPercent(sentence);
            var eachLetterPercent = Logic.CalculateEachLetterPercent(sentence);
            ConsoleUI.PrintResult(letterPercent, eachLetterPercent);
        }
    }
}
