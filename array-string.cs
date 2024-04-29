using System;

class Program
{
    static void Main(string[] args)
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (string myString in myStrings)
        {
            int periodLocation = myString.IndexOf('.');

            if (periodLocation != -1)
            {
                int start = 0;
                do
                {
                    int end = myString.IndexOf('.', start);
                    if (end == -1)
                    {
                        end = myString.Length;
                    }
                    string sentence = myString.Substring(start, end - start).Trim();
                    Console.WriteLine(sentence);
                    start = end + 1;
                } while (start < myString.Length);
            }
        }
    }
}
