using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo17
{
    public struct Menu
    {
        public string message;
        public string[] choix;
        public ushort position;

        public void Monter()
        {
            if(position == 0)
            {
                position = (ushort)(choix.Length - 1);
            }
            else 
            { 
                position--; 
            }
            //position = (position == 0) ? (ushort)(choix.Length - 1) : (ushort)(position - 1);
        }

        public void Descendre()
        {
            if (position == choix.Length - 1)
            {
                position = 0;
            }
            else { 
                position++;
            }
        }

        public ushort Afficher()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine();
                for (int i = 0; i < choix.Length; i++)
                {
                    if(i == position)
                    {
                        Console.WriteLine($"-> {choix[i]} <-");
                    }
                    else
                    {
                        Console.WriteLine(choix[i]);
                    }
                }
                do
                {
                    key = Console.ReadKey(true).Key;
                } while (key != ConsoleKey.Enter && key != ConsoleKey.DownArrow && key != ConsoleKey.UpArrow);
                if(key == ConsoleKey.UpArrow)
                {
                    Monter();
                }
                else if(key == ConsoleKey.DownArrow)
                {
                    Descendre();
                }
            }
            while (key != ConsoleKey.Enter);
            return position;
        }
    }
}
