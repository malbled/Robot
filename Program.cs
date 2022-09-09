using System;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Robot
{
    class Program
    {
        class Robot
        {
            public int x;
            public int y;

            public void step(char shag)
            {
                switch (shag)
                {
                    case 'U':
                        y--;
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("*");

                        break;
                    case 'D':
                        y++;
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("*");
                        break;
                    case 'R':
                        x++;
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("*");
                        break;
                    case 'L':
                        x--;
                        Console.SetCursorPosition(x,y);
                        Console.WriteLine("*");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            char zz;
            int ch = 0;
           
            bool Proverka(int x, int y)
            {
                if (x == 50 && y == 23)
                    return true;
                else
                    return false;
            }
            Console.WriteLine(@"                                        Инструкция для  нашей 
                                             игры РОБОТ:
                                        ******************** 
                                        *       Шаги:      * 
                                        *  Up     -    U   *  
                                        *  Down   -    D   *  
                                        *  Right  -    R   *  
                                        *  Left   -    L   *
                                        *                  *
                                        ******************** ");

            Robot gamer = new Robot();
            gamer.x = 50;
            gamer.y = 23;
            Console.SetCursorPosition(gamer.x, gamer.y);
            Console.WriteLine("*");
            do
            {
                
                char.TryParse(Console.ReadLine().ToUpper(), out zz);
                gamer.step(zz);
                ch++;
            }
            while (!Proverka(gamer.x, gamer.y));
            
            
            Console.SetCursorPosition(32, 25);
            Console.WriteLine("Ты вернулся в начало за " + ch + " шагов!");
        }
    }
}
