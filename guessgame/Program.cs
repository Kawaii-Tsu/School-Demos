using System;

namespace guessgame
{
    class Program
    {
        static void Main(string[] args)
        {

            //intro
            spacer(1);
            Console.WriteLine("Thank you for choosing the Guessing Game as your play choice!");
            spacer(2);
            Console.WriteLine("Playing this game is very simple, but winning it will require some luck. To play, you need to guess a number between 1 to 30.");
            Console.WriteLine("If your number matches the number that the program picks, you win! If not, it will state if the number you chose is lower or higher than what it chose.");
            Console.WriteLine("Best of Luck player!");

            //new and updated spacer function, now you can state how many lines you want to skip!
            void spacer(int amountOfSpace)
            {
                if (amountOfSpace == 1){
                    Console.WriteLine(" ");
                } else if (amountOfSpace == 2){
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                } else if (amountOfSpace == 3){
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
            
            }

            int numberOfGuesses = 0;
            int numPlayerGuess;
            string typePlayerGuess; //convert to .toInt();
            Random rng = new Random();
            int randomNum = rng.Next(0, 30); //program's guess

            game();

            void game()
            {

                spacer(3);
                Console.Write("Alright Player, what's your guess? ");

                typePlayerGuess = Console.ReadLine();

                spacer(1);
                while(!Int32.TryParse(typePlayerGuess, out numPlayerGuess)){

                    spacer(2);
                    Console.WriteLine("Please type a number not letters/symbols");
                    game();

                }

                if (numPlayerGuess == randomNum)
                {
                    Console.WriteLine("Congratualtions Player! Your guess matched the program's number!");
                    Console.WriteLine("Your number of guesses were...{0}!", numberOfGuesses);

                    playAgain();
    
                } 
                else if (numPlayerGuess > 30 || numPlayerGuess < 0) 
                {
                    Console.WriteLine("You need to guess a number b e t w e e n 1 to 30, nothing more, nothing less.");
                    game();
                }
                else if (numPlayerGuess > randomNum)
                {
                    Console.WriteLine("Your guess was too high, c'mon you go this!");
                    numberOfGuesses++;
                    game();
                } 
                else if (numPlayerGuess < randomNum)
                {
                    Console.WriteLine("Your guess was lower than what the program had. Keep trying!");
                    numberOfGuesses++;
                    game();
                }
    
            }
            
            void playAgain()
            {

                spacer(2);
                Console.Write("Would you like to play again? [ y, n ]");
                string restart = Console.ReadLine();
                spacer(2);

                switch (restart.ToLower())
                {

                    case "y":
                        Console.WriteLine("Alrighty! Good Luck!");
                        game();
                        break;
                    case "n":
                        Console.WriteLine("Alright! Thanks for playing!");
                        breaker();
                        break;
                    default:
                        Console.WriteLine("Sorry but could you type that again? (type y for yes and n for no)");
                        playAgain();
                        break;
                }

            }

            void breaker()
            {

                while (true)
                {
                    break;
                }

            }

        }
    }
}
