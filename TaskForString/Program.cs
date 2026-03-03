namespace TaskForString
{
    class Sentence
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
