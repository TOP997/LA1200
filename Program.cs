using System;

namespace Zahlraten
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";

            int highScore = 100;

            while (exit != "exit")
            {
                int klein = 1;

                int gross = 100;

                

                int programEnde = 60;
                int killswitch = 13;
                int exitWork = 16;
                int programBeendung = 30;

                Random rd = new Random();
                int rand_num = rd.Next(1, 100);

                int userNumber = 0;

                int ty = Convert.ToInt32(0);


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht." + "\n" + "kanst du sie erraten?");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Wenn sie aufgeben wollen schreiben sie einfach");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" <exit>.\n");
                Console.ForegroundColor = ConsoleColor.White;

                while (userNumber != rand_num && programBeendung != programEnde)
                {

                    var Userdumm = Console.ReadLine();

                    if (int.TryParse(Userdumm, out userNumber))
                    {
                        if (userNumber == 420)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Weed");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (userNumber > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Ungültig diese Zahl ist viel zu hoch zählt trotzdem als Versuch");
                            Console.ForegroundColor = ConsoleColor.White;
                            ty++;
                        }

                        if (userNumber < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ungültig diese Zahl ist viel zu tief zählt trotzdem als Versuch");
                            Console.ForegroundColor = ConsoleColor.White;
                            ty++;
                        }

                        if (userNumber == 69)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("N");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("i");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("c");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("e");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (userNumber < rand_num && userNumber > 0)
                        {
                            Console.Beep(800, 800);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Ihre Zahl ist zu klein versuchen sie es erneut.");
                            Console.ForegroundColor = ConsoleColor.White;
                            ty++;


                            if (userNumber > klein) { klein = userNumber; }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Die Zahl ist zwischen " + klein + " und " + gross);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (userNumber > rand_num && userNumber < 101)
                        {
                            Console.Beep(5000, 800);                            
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Ihre Zahl ist zu gross versuchen sie es erneut.");
                            Console.ForegroundColor = ConsoleColor.White;
                            ty++;


                            if (userNumber < gross) { gross = userNumber; }                            
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Die Zahl ist zwischen " + klein + " und " + gross);                            
                            Console.ForegroundColor = ConsoleColor.White;
                        }                        
                    }

                    else if (Userdumm == "exit")
                    {
                        programBeendung = programEnde;
                        exit = "exit";
                        killswitch = exitWork;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("schade die Zahl wäre " + rand_num + " gewesen.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bitte geben sie eine ganze Zahl zwischen 1 und 100 oder <exit> ein.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if (userNumber == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Richtig");
                    Console.Beep(1000, 1000);
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(800, 1000);
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(600, 1000);
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(800, 1000);
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(1000, 1000);
                    System.Threading.Thread.Sleep(100);
                    Console.Beep(1200, 1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    ty++;
                }

                if (ty <= 5 && userNumber == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sie haben " + ty + " Versuche gebraucht.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (ty <= 10 && ty > 5 && userNumber == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sie haben " + ty + " Versuche gebraucht.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (ty > 10 && userNumber == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sie haben " + ty + " Versuche gebraucht.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (killswitch != exitWork)
                {                   
                    if (ty < highScore) { highScore = ty; }
                    else if (ty > highScore && ty < 100) { Console.WriteLine("Schade kein neuer High Score."); }
                    else if (ty >= 100) { Console.WriteLine("Du bist echt schlecht in diesem Spiel."); }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ihr High Score ist " + highScore);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Wenn sie nichtmehr spielen wollen schreiben sie");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("<exit>.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Wenn sie nochmal spielen wollen schreiben sie irgendwas anderes ausser exit.");
                    Console.ForegroundColor = ConsoleColor.White;
                    exit = Console.ReadLine();
                    if (exit == "exit") 
                    { 
                        killswitch = exitWork;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Okay bis zum nächsten mal.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                    
                }                
            }
            Console.ReadKey();            
        }
    }
}
