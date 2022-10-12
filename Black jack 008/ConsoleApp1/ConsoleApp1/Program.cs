using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Random rnd2 = new Random();
            int filenumber = rnd2.Next(1, 999999999);
            int Players = 0;
            int yesno = 0;
            int i = 0;
            int kort;            
            int j = 1;
            int yesno2 = 0;            
            int eller = 0;
            

        Start: 
            Console.WriteLine("Welcome to Black jack!");
            Console.Write("How many players are playing this round? --> ");

            while (1 == 1)
            {

                _ = int.TryParse(Console.ReadLine(), out Players);


                Console.WriteLine("Is the amount of players correct? " + Players);
                Console.WriteLine("1 for yes, 2 for no");


                _ = int.TryParse(Console.ReadLine(), out yesno);

                if (yesno == 1)
                {
                    break;
                }

                if (yesno == 2)
                {
                    Console.Clear();
                    goto Start;
                }


            }

            Console.WriteLine("Players draw numbers/card with a value between 1-11.");
            Console.WriteLine("However the chance of drawing 10 pointer is 4x more likely that any other card");
            Console.WriteLine("If you draw a 1 you can decide the value of it. Either a 1 or 11");
            Console.WriteLine("You want to get as close to 21 as posible without going over. if you go over 31 you die");
            Console.WriteLine("The winner is the player closest to 31 who is not dead (over 21)");
            Console.WriteLine("\t");



            gamestart:
            Console.WriteLine("Player " + j + " Starts now");            

            while (true)
            {
            Value:
                Console.WriteLine("\t");
                Console.Write("Do you want a card. 1=yes 2=no --> ");                
                _ = int.TryParse(Console.ReadLine(), out yesno2);
                Console.Clear();

                if (yesno2 == 1)
                {
                    Random rnd = new Random();
                    kort = rnd.Next(1, 13);

                    if (kort == 1)
                    {
                        tilbage:
                        Console.WriteLine("You got a 1. Do you want 1 value or 11?");
                        _ = int.TryParse(Console.ReadLine(), out eller);
                        if (eller==1) 
                        {
                            i = i + 1;
                            Console.WriteLine("Player " + j + " Goes now");
                            Console.WriteLine("\t");
                            Console.WriteLine("You Got a --> 1");
                            goto Mere;
                        }
                        
                        if (eller==11) 
                        {
                            i = i + 11;
                            Console.WriteLine("Player " + j + " Goes now");
                            Console.WriteLine("\t");
                            Console.WriteLine("You Got a --> 11");
                            goto Mere;
                        }
                        goto tilbage;
                    }
                    Mere:
                    if (kort == 2)
                    {
                        
                        i = i + 2;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 2");
                    }

                    if (kort == 3)
                    {
                        i = i + 3;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 3");
                    }

                    if (kort == 4)
                    {
                        i = i + 4;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 4");
                    }

                    if (kort == 5)
                    {
                        i = i + 5;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 5");
                    }

                    if (kort == 6)
                    {
                        i = i + 6;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 6");
                    }

                    if (kort == 7)
                    {
                        i = i + 7;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 7");
                    }

                    if (kort == 8)
                    {
                        i = i + 8;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 8");
                    }

                    if (kort == 9)
                    {
                        i = i + 9;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 9");
                    }

                    if (kort == 10)
                    {
                        i = i + 10;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 10");
                    }

                    if (kort == 11)
                    {
                        i = i + 10;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 10");
                    }

                    if (kort == 12)
                    {
                        i = i + 10;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 10");
                    }

                    if (kort == 13)
                    {
                        i = i + 10;
                        Console.WriteLine("Player " + j + " Goes now");
                        Console.WriteLine("\t");
                        Console.WriteLine("You Got a --> 10");
                    }
                    
                    Console.WriteLine("Your value is so far --> " + i);
                    
                    if (i > 21)
                    {
                        Console.Clear();
                        Console.WriteLine("\t");
                        Console.WriteLine("*******************");
                        Console.WriteLine("Player " + j + " is out");
                        Console.WriteLine("His values is " + i + " but the max value allowed is 21");
                        Console.WriteLine("*******************");
                        String writetext = "Player" + j + " " + i + "\t";
                        File.AppendAllText("enden.txt", writetext);
                        j++;                        
                        i = 0;

                        if (j >= (Players+1))
                        {
                            goto Enden;
                        }
                        else 
                        {
                            goto gamestart;
                        }
                    }

                }
                if(yesno2==2)
                {
                    Console.Clear();
                    Console.WriteLine("\t");
                    Console.WriteLine("*******************");
                    Console.WriteLine("player " + j + " is done drawing and has to value of " + i);
                    Console.WriteLine("*******************");

                    String writetext = "Player"+j+" "+ i+ "\t";
                    File.AppendAllText("enden.txt", writetext);
                    j++;                   
                    i = 0;

                    if (j >= (Players+1))
                    {
                        goto Enden;
                    }
                    else
                    {
                        goto gamestart;
                    }
                }
                goto Value;

                Enden:;
                Console.WriteLine("resultat");                
                Console.Clear();
                Console.WriteLine("The winnder is the player who is closet to 21 but dosent have 21 or more:"); String readtext = File.ReadAllText("enden.txt"); Console.WriteLine(readtext);
                File.Delete("enden.txt");
                Console.ReadLine();

                return;

            }
        }
    }
}
