// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class Program
{
    public static void Main(string[] args)
    {
     /*   SayaTubeVideo stv1 = new SayaTubeVideo("Tutorial Design By Contract – [Farah Amalia Putri]");
        stv1.IncreasePlayCount(180);
        stv1.PrintVideoDetails();
     */

        SayaTubeVideo stv1 = null;

        //PreCondition
        try
        {
            stv1 = new SayaTubeVideo("Tutorial Design By Contract – [Farah Amalia Putri]");
            for (int j = 1; j <= 10000000; j++)
            {
                stv1.IncreasePlayCount(1);
            }
            stv1.PrintVideoDetails();

        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR! " + ex.Message);
        }
      
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length <= 100 && title != null); //Prekondisi
        this.title = title;
        this.id = Random();
        this.playCount = 0;
    }
    private int Random()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int pc)
    {
        Contract.Requires(pc > 0 && pc <= 10000000); //Prekondisi
        Contract.Ensures(pc < int.MaxValue, "Error"); //Postkondisi

        try //Ketika kondisi benar
        {
            checked
            {
                playCount += pc;
            }

        }
        catch (OverflowException) //Ketika kondisi salah
        {
            Console.WriteLine("ERROR! Melebihi Kapasitas");
        }

    }

    public void PrintVideoDetails()
    {
        Console.Write("ID: " + id);
        Console.WriteLine(" ");
        Console.Write("Title: " + title);
        Console.WriteLine(" ");
        Console.Write("Jumlah putar: " + playCount);
    }
}

