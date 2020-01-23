using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMasterBoard
{
    public class Bord //============================MainBoard=======================================================
    {
        //Fields
        private int rows;
        private dynamic[,] board;

        //Properties
        private int columns { get; set; }

        //Constructors
        public Bord() { }

        public Bord(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            board = new dynamic[rows, columns];
        }


        //getters + setters
        public dynamic[,] getBord()  //return the board
        {
            return board;
        }

        //Methods
        public void SetALetterAtDiagonal(char letter)//set a 'letter' at diagonal
        {
            for (int i = 0; i < rows; i++)
            {
                int j = i;

                if (i == j)
                {
                    board[i, j] = letter;
                }
            }
        }

        public int[] SetLettersAtRandomColumns(string word)//set a letter of "word" in a random column of a row and return an array with random numbers.
        {
            Random randomNum = new Random();
            int[] randomNums = new int[word.Length];

            for (int i = 0; i < rows; i++)
            {
                int randomRowNum = randomNum.Next(0, rows);
                int j = i;

                while (randomRowNum == j)
                {
                    randomRowNum = randomNum.Next(0, rows);
                }

                board[i, randomRowNum] = word[i];
                randomNums[i] = randomRowNum;
            }

            return randomNums;
        }

        public void CounterOfRows(int rows)// Give numbers at row of one column array
        {

            for (int i = 0; i < rows; i++) // Give numbers at row
            {
                board[i, 0] = (rows - i);
            }
        }

        public void Separator() //Print Separator --------------
        {
            Console.Write("\t\t");

            for (int i = 0; i < columns; i++)
            {
                Console.Write("----");
            }

            Console.WriteLine("-");
        }
    }
}
