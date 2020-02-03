using System;
using static Mathematic;

class Program
{
    static void Main(string[] args)
    {
        Player[] players= new Player[2];
        Player player = new Player("Shadow", 1324);
        Player player2 = new Player("Dark", 4673);
        players[0] = player;
        players[1] = player2;

        foreach (Player play in players)
        {
            Console.WriteLine("Player nick: " + play.Nick + ". Player id: " + play.Id);
        }
        Console.WriteLine("Player nick: " + player.Nick + ". Player id: " + player.Id);
        Console.WriteLine("Player nick: " + player2.Nick + ". Player id: " + player2.Id);
        
        Console.WriteLine(value: "Your score is: " + add(5, 7));
    }
}

class Player
{
    private string nick;
    private int id;
    private static int nextId = 0;
    public Player(string nick, int id)
    {
        this.nick = nick;
        nextId++;
        this.id = nextId;
    }
    public string Nick
    {
        get => nick;
        set => nick = value;
    }

    public int Id => id;
}

class Mathematic
{
    public static int add(int a, int b)
    {
        return a + b;
    }
}