using System.Globalization;

namespace Part_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Min an
            int min, max, middle;
            bool done = false;
            Console.WriteLine("Enter a min and a max");
            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            while (!done)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Enter a number in between " + min + " and " + max);
                middle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");





                if (middle > max)
                { 
                    Console.WriteLine("No this isn't in the range");
                    done = true;
                }

                else if (middle < max)
                {
                    Console.WriteLine("Yes this is in the range");
                    done = true;
                }


                else if (middle < min)
                {
                    Console.WriteLine("No this isn't in the range");
                    done = true;
                }
                else if (middle > min)
                {
                    Console.WriteLine("Yes this is in the range");
                    done = true;

                }
            }


            // Percent Program
            int average;
            double scores = 0, passCounter = 0;
            bool finished = false;
            double total;
            string repeat;
            int n;
            while (!finished)
            {
                Console.WriteLine("Enter scores and this program wil calculate the average");
                Console.WriteLine();
                average = Convert.ToInt32(Console.ReadLine());

                if (average >= 70)
                {
                    scores += 1;
                    passCounter += 1;
                }

                else if (average < 70)
                {
                    scores += 1;
                }
                Console.WriteLine("");
                Console.WriteLine("Do you want to enter another score");
                Console.WriteLine("yes or no?");
                repeat = Console.ReadLine();

                if (repeat == "yes") 
                {
                    finished = false;
                }
                

                else if (repeat == "no") 
                {
                    finished = true;
                }

                

            }

            total = passCounter / scores;
            total = total * 100;

            Console.WriteLine(total);



            //Odd Sum
            int sum = 0;
            Console.WriteLine("This program will add all odd numbers before the one you enter together.");
            Console.WriteLine("Enter a number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write($"{sum}");
            Console.ReadLine();


            //Random Numbers
            bool random = false;
            Random generator = new Random();
            int minimum;
            int maximum;
            Console.WriteLine("Enter a minnium and a maximum and this program will generate 25 random numbers between those numbers");
            Console.WriteLine("Enter a minimum");
            minimum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter a maximum");
            maximum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(generator.Next(minimum, maximum));
            }


            //dice game
            bool run;
            run = false;
            int dubs;
            int money, notdubs, bet, sumtotal, roll, roll2;
            string loop;
            Console.WriteLine("You have $100 to bet on dice rolls.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You will select how much money to bet and depending on your roll, you will win or lose your money");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Dice Roll Multipliers");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Doubles: Your bet doubles");
            Console.WriteLine("Not Doubles: Win half of your bet");
            Console.WriteLine("Even Sum: Win your bet");
            Console.WriteLine("Odd Sum: Win your bet");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);

            
            
            while (!run)
            {
                Console.WriteLine("Enter your bet");
                bet = Convert.ToInt32(Console.ReadLine());
                money = 100;
                sumtotal = money - bet;
                roll = (generator.Next(1, 7));
                roll2 = (generator.Next(1, 7));

                DrawDice(roll);
                DrawDice(roll2);



                //doubles
                if (roll == roll2)
                {
                    dubs = (bet * 2);
                    money = (100 + dubs);
                    Console.WriteLine($"You now have" + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }

                }

                //even
                else if (roll + roll2 == 2)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 4)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 6)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 8)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 10)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 12)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                //odds

                else if (roll + roll2 == 1)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 3)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 5)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 7)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (roll + roll2 == 9)
                {
                    money = (100 + 10);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                    Console.WriteLine($"You now have: " + money);
                }

                else if (roll + roll2 == 11)
                {
                    money = (100 + 10);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                //not doubles
                else if (roll != roll2)
                {
                    notdubs = (bet / 2);
                    money = (100 - notdubs);
                    Console.WriteLine($"You now have: " + money);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go again, yes or no");
                    loop = Console.ReadLine();
                    if (loop == "yes")
                    {
                        run = false;
                    }


                    else if (loop == "no")
                    {
                        run = true;
                    }
                }

                else if (money <= 0)
                {
                    Console.WriteLine("You are broke, congrats");
                    run = true;
                }


            }

        }







        public static void DrawDice(int face)
        {
            if (face == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (face == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (face == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (face == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (face == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (face == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }











        }
    }
}