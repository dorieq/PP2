using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_full
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 58);
            Realisation far = new Realisation(@"C:\Program Files (x86)\Android\android-sdk");

            bool quit = false;

            while (!quit)
            {
                far.Print();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Enter:
                        far.Process(pressedKey);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
