using Newtonsoft.Json;
using System;
using System.IO;

namespace QuizNick
{
    internal class StartMenu
    {
        private static string jsonFilePath = "C:\\Users\\nad\\source\\repos\\QuizNick\\QuizNick\\QuizSvar.json";
        private string brugerInput;
        public void Menu()
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            QuizData data = JsonConvert.DeserializeObject<QuizData>(jsonContent);

            Console.WriteLine("Tryk en knap for at starte quizzen");
            Console.ReadKey();
            Console.Clear(); 
            Quiz1(data);

            Console.WriteLine("Tryk en knap for at afslutte");
            Console.ReadKey();
        }

        public void Quiz1(QuizData data)
        {
            Console.WriteLine("Hvor meget vand bruger den gennemsnitlige dansker om dagen?\n105 liter\n505 liter\n55 liter\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar1)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
                Quiz2(data);
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
        public void Quiz2(QuizData data)
        {
            Console.WriteLine("Hvor gammelt er vandet, vi tapper fra hanen?\n1 år\n20 år\n10 år\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar2)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
                Quiz3(data);
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
        public void Quiz3(QuizData data)  
        {
            Console.WriteLine("Hvor mange liter vand bruger vi typisk på et brusebad på 5 minutter?\n50 til 100 liter\n5 til 10 liter\n10 til 20 liter\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar3)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
                Quiz4(data);
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
        public void Quiz4(QuizData data)
        {
            Console.WriteLine("Hvor meget vand løber ud af haveslangen på et minut?\n1 liter\n5 liter\n12 liter\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar4)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
                Quiz5(data);
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
        public void Quiz5(QuizData data)
        {
            Console.WriteLine("Hvad bruger mest vand i hjemmet?\nTøjvask\nBad og hygiejne\nToiletskyl\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar5)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
                //Quiz6(data);
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
        public void Quiz6(QuizData data)
        {
            Console.WriteLine("Hvor meget vand indeholder de store havepools?\n40.000-50.000 liter\n5.000-10.000\n60-120 liter\n");

            brugerInput = Console.ReadLine();

            if (brugerInput == data.Svar6)
            {
                Console.WriteLine("Korrekt!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
    }

    public class QuizData
    {
        public string Svar1 { get; set; }
        public string Svar2 { get; set; }
        public string Svar3 { get; set; }
        public string Svar4 { get; set; }
        public string Svar5 { get; set; }
        public string Svar6 { get; set; }
    }
}
