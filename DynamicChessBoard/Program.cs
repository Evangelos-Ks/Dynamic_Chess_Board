using System;

namespace ChessMasterBoard
{
    class Program
    {
        static string UserInput()  //UserInput
        {
            Console.Write("\n\tGive a word: ");
            return Console.ReadLine();
        }

        static void Main(string[] args)  //====================================MAIN==============================================================
        {
            string word = UserInput();
            int wordLength = word.Length;
            Bord mainBoard = new Bord(wordLength, wordLength);
            Bord downMainBoard = new Bord(1, wordLength);
            Bord oneColumnBoard = new Bord(wordLength, 1);
            char[] lettersArray = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] arrOfRandomNums;

            for (int i = 0; i < wordLength; i++) // Insert characters in columns of downMainBoard
            {
                downMainBoard.getBord()[0, i] = lettersArray[i];
            }

            mainBoard.SetALetterAtDiagonal('X');
            arrOfRandomNums = mainBoard.SetLettersAtRandomColumns(word);

            oneColumnBoard.CounterOfRows(wordLength);

            //Print mainBoard and oneColumnBoard
            Console.WriteLine();

            for (int i = 0; i < wordLength; i++)
            {
                mainBoard.Separator();
                Console.Write("\t");
                Console.Write(oneColumnBoard.getBord()[i, 0]);
                Console.Write("\t");
                for (int j = 0; j < wordLength; j++)
                {
                    if (mainBoard.getBord()[i, j] != null)
                    {
                        Console.Write($"| {mainBoard.getBord()[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"|   ");
                    }
                }
                Console.Write("|");
                Console.WriteLine($"\t\t{word[i]} : ({lettersArray[arrOfRandomNums[i]]}, {oneColumnBoard.getBord()[i, 0]})");
            }
            mainBoard.Separator();

            //print downMainBoard
            Console.Write("\t\t");
            for (int i = 0; i < wordLength; i++)
            {
                Console.Write($"  {downMainBoard.getBord()[0, i]} ");
            }

            Console.ReadKey();
        }
    }
}
