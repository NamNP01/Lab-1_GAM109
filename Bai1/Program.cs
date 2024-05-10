using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public static class UserData
{
    public static string ID;
    public static string Name;
    public static int Health;
    public static int Point;

    static UserData()
    {
        ID = "123";
        Name = "Player1";
        Health = 100;
        Point = 100;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ID" + UserData.ID);
        System.Console.WriteLine("Name" + UserData.Name);
        System.Console.WriteLine("Health " + UserData.Health);
        System.Console.WriteLine("Point " + UserData.Point);
        Console.ReadLine();
    }
}


