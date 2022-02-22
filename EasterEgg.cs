using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcIndividuell;

namespace CalcIndividuell
{
    internal class EasterEgg
    {
        public void MyEasterEgg()
        {
            Console.WriteLine("Välkomen till MusicBox");
            Console.WriteLine("Vad vill du lyssna på ?");
            Console.WriteLine("Skriv nummret innan låten för att lyssna på den");

            Console.WriteLine("                             ");

            Console.WriteLine("1: Supermario");

            Console.WriteLine("2: Tetris");

            Console.WriteLine("3: StarWars");
            Songs songs = new Songs();
            Inmatning inmatning = new Inmatning();
            switch (inmatning.InmatningAvVal())
            {
                case "1":
                    songs.Mario();
                    break;

                case "2":
                    songs.Tetris();
                    break;
                case "3":
                    songs.StarWars();
                        break;

            }

        }
    }
}
