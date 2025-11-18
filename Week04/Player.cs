using System;

public class Player
{
    // Instance fields
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
        playerName = "Unknown";
        level = 1;
        health = 100;
    }

    // Parameterized constructor
    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }

    // Method to display player details
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player: {playerName}, Level: {level}, Health: {health}");
    }
}