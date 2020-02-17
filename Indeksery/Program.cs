using System;

class Program
{
    static void Main(string[] args)
    {
        Sentence sentence = new Sentence("this is test message");
        Console.WriteLine(sentence[1]);
        Console.ReadLine();
    }
}

class Sentence
{
    private string[] words;

    public Sentence(string sentence)
    {
        this.words = sentence.Split();
    }

    public string this[int n]
    {
        get
        {
            if (words.Length > n)
                return words[n];
            else
                return null;
        }
        set
        {
            if (words.Length > n)
                words[n] = value;
        }
    }
}