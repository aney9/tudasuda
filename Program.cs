using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
namespace lol
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("F1 6 - октава ");
            Console.WriteLine("F2 7 - октава ");
            Console.WriteLine("F3 8 - октава ");
            Console.WriteLine("ESC выход ");
            Console.WriteLine("Нажмите F1,F2,F3 для выбора октавы(a-j и w-y)");
            while (true)
            {
                ConsoleKeyInfo cifra = Console.ReadKey();
                if (cifra.Key == ConsoleKey.F1)
                {
                    oktava1();
                }
                if (cifra.Key == ConsoleKey.F2)
                {
                    oktava2();
                }
                if (cifra.Key == ConsoleKey.F3)
                {
                    oktava3();

                }
                if (cifra.Key == ConsoleKey.Escape)
                {
                    oktava4();
                    break;

                }
            }
        }
        static void oktava1()
        {
            while (true)
            {
                int[] noty = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                ConsoleKeyInfo xz = Console.ReadKey();
                if (xz.Key == ConsoleKey.A)
                {
                    Console.Beep(noty[0], 350);
                }
                if (xz.Key == ConsoleKey.W)
                {
                    Console.Beep(noty[1], 350);
                }
                if (xz.Key == ConsoleKey.S)
                {
                    Console.Beep(noty[2], 350);
                }
                if (xz.Key == ConsoleKey.E)
                {
                    Console.Beep(noty[3], 350);
                }
                if (xz.Key == ConsoleKey.D)
                {
                    Console.Beep(noty[4], 350);
                }
                if (xz.Key == ConsoleKey.F)
                {
                    Console.Beep(noty[5], 350);
                }
                if (xz.Key == ConsoleKey.R)
                {
                    Console.Beep(noty[6], 350);
                }
                if (xz.Key == ConsoleKey.G)
                {
                    Console.Beep(noty[7], 350);
                }
                if (xz.Key == ConsoleKey.T)
                {
                    Console.Beep(noty[8], 350);
                }
                if (xz.Key == ConsoleKey.H)
                {
                    Console.Beep(noty[9], 350);
                }
                if (xz.Key == ConsoleKey.Y)
                {
                    Console.Beep(noty[10], 350);
                }
                if (xz.Key == ConsoleKey.J)
                {
                    Console.Beep(noty[11], 350);
                }
                if (xz.Key == ConsoleKey.F2)
                {
                    oktava2();
                }
                if (xz.Key == ConsoleKey.F3)
                {
                    oktava3();
                }
                if (xz.Key == ConsoleKey.Escape)
                {
                    oktava4();
                }
            }
        }
        static void oktava2()
        {
            while (true)
            {
                int[] noty = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                ConsoleKeyInfo xz = Console.ReadKey();

                if (xz.Key == ConsoleKey.A)
                {
                    Console.Beep(noty[0], 350);
                }
                if (xz.Key == ConsoleKey.W)
                {
                    Console.Beep(noty[1], 350);
                }
                if (xz.Key == ConsoleKey.S)
                {
                    Console.Beep(noty[2], 350);
                }
                if (xz.Key == ConsoleKey.E)
                {
                    Console.Beep(noty[3], 350);
                }
                if (xz.Key == ConsoleKey.D)
                {
                    Console.Beep(noty[4], 350);
                }
                if (xz.Key == ConsoleKey.F)
                {
                    Console.Beep(noty[5], 350);
                }
                if (xz.Key == ConsoleKey.R)
                {
                    Console.Beep(noty[6], 350);
                }
                if (xz.Key == ConsoleKey.G)
                {
                    Console.Beep(noty[7], 350);
                }
                if (xz.Key == ConsoleKey.T)
                {
                    Console.Beep(noty[8], 350);
                }
                if (xz.Key == ConsoleKey.H)
                {
                    Console.Beep(noty[9], 350);
                }
                if (xz.Key == ConsoleKey.Y)
                {
                    Console.Beep(noty[10], 350);
                }
                if (xz.Key == ConsoleKey.J)
                {
                    Console.Beep(noty[11], 350);
                }
                if (xz.Key == ConsoleKey.F1)
                {
                    oktava1();
                }
                if (xz.Key == ConsoleKey.F3)
                {
                    oktava3();
                }
                if (xz.Key == ConsoleKey.Escape)
                {
                    oktava4();
                }
            }

        }
        static void oktava3()
        {
            while (true)
            {
                int[] noty = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                ConsoleKeyInfo xz = Console.ReadKey();
                if (xz.Key == ConsoleKey.A)
                {
                    Console.Beep(noty[0], 350);
                }
                if (xz.Key == ConsoleKey.W)
                {
                    Console.Beep(noty[1], 350);
                }
                if (xz.Key == ConsoleKey.S)
                {
                    Console.Beep(noty[2], 350);
                }
                if (xz.Key == ConsoleKey.E)
                {
                    Console.Beep(noty[3], 350);
                }
                if (xz.Key == ConsoleKey.D)
                {
                    Console.Beep(noty[4], 350);
                }
                if (xz.Key == ConsoleKey.F)
                {
                    Console.Beep(noty[5], 350);
                }
                if (xz.Key == ConsoleKey.R)
                {
                    Console.Beep(noty[6], 350);
                }
                if (xz.Key == ConsoleKey.G)
                {
                    Console.Beep(noty[7], 350);
                }
                if (xz.Key == ConsoleKey.T)
                {
                    Console.Beep(noty[8], 350);
                }
                if (xz.Key == ConsoleKey.H)
                {
                    Console.Beep(noty[9], 350);
                }
                if (xz.Key == ConsoleKey.Y)
                {
                    Console.Beep(noty[10], 350);
                }
                if (xz.Key == ConsoleKey.J)
                {
                    Console.Beep(noty[11], 350);
                }
                if (xz.Key == ConsoleKey.F1)
                {
                    oktava1();
                }
                if (xz.Key == ConsoleKey.F2)
                {
                    oktava2();
                }
                if (xz.Key == ConsoleKey.Escape)
                {
                    oktava4();
                }
            }

        }
        static void oktava4()
        {
            ConsoleKeyInfo xz = Console.ReadKey();
            while (true)
            {
                if (xz.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

    }

}






