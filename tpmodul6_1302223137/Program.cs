// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        SayaTubeVideo stv1 = new SayaTubeVideo("Tutorial Design By Contract – [Farah Amalia Putri]");
        stv1.IncreasePlayCount(180);
        stv1.PrintVideoDetails();
    }
}

public class SayaTubeVideo
{
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
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
            playCount += pc;
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

