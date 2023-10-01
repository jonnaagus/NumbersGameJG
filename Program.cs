using System;

// Skapad av: Jonna Gustafsson  
// Klass: .NET23

namespace NumbersGameJG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator
            var generator = new Random();

            // Generate a random number between 1 and 50
            int r = generator.Next(1, 51);

            // Initialize the number of guesses and the maximum allowed guesses
            int guesses = 0;
            int maxGuesses = 8;

            // Display a welcome message to the user
            Console.WriteLine("Hej och välkommen till Gissa Talet!");
            Console.WriteLine("Du ska nu gissa på ett tal mellan 1 och 50. Du har 8 gissningar på dig. Skriv in din gissning och tryck på enter: ");

            int guessedNumber;
            bool gameOver = false;

            // Start a loop to allow the player to make guesses
            do
            {
                // Get the player's guessed number
                guessedNumber = GetGuessedNumber();
                guesses++;

                // Check if the guessed number is too low
                if (guessedNumber < r)
                {
                    Console.WriteLine("Du gissade tyvärr för lågt. Gissa på ett högre tal.");
                }
                // Check if the guessed number is too high
                else if (guessedNumber > r)
                {
                    Console.WriteLine("Du gissade tyvärr för högt. Gissa på ett lägre tal.");
                }
                // The player guessed the correct number
                else
                {
                    Console.WriteLine("GRATTIS!!! Du gissade på rätt tal och har därmed vunnit spelet!");
                    Console.WriteLine("Du använde " + guesses + " antal gissningar!");
                    gameOver = true;
                }

            } while (!gameOver && guesses < maxGuesses);

            // If the game is not over, display a message about reaching the maximum allowed guesses
            if (!gameOver)
            {
                Console.WriteLine("Du har tyvärr nått MAX antal gissningar och spelet är nu slut!");
                Console.WriteLine("Rätt svar var: " + r);
            }

            // Thank the player for playing and wait for user input before exiting
            Console.WriteLine("Tack för att du spelade Gissa Talet, spela gärna igen!");
            Console.ReadLine();
        }

        // A function to get the player's guessed number and validate it
        static int GetGuessedNumber()
        {
            int guessedNumber;
            while (!int.TryParse(Console.ReadLine(), out guessedNumber) || guessedNumber < 1 || guessedNumber > 50)
            {
                Console.WriteLine("Var god och skriv in ett heltal mellan 1 och 50: ");
            }
            return guessedNumber;
        }
    }
}