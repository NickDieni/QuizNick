using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace QuizNick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMenu nyMenu = new StartMenu();
            nyMenu.Menu();
        }
    }
}
