using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class posionXY
    {
        public int x;
        public int y;
    }
    class sudoku
    {
        public static int[,] sudukoObj = new int[9, 9];
        private static posionXY positionProp = new posionXY();
        private static Random random = new Random();

        public static void sudokuProgram()
        {
            //prepareSodukuBox();
            printSuduko();
            Console.WriteLine("***********************************************************************************");
            solveSoduku();
            printSuduko();
        }

        private static void solveSoduku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // if box is empty
                    if (sudukoObj[i, j] == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            var possibleInSqure = !isExistInSqure(i, j, k);
                            var possibleInRow = !isExistInRow(i, j, k);
                            var possibleInColumn = !isExistInColumn(i, j, k);
                            if (possibleInSqure && possibleInRow && possibleInColumn)
                            {
                                sudukoObj[i, j] = k;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void prepareSodukuBox()
        {
            // assign random numner from 1 to 9 in empty box in 20 cells
            for (int i = 0; i < 20; i++)
            {
                int cell = findRandamCell();
                int ranNum = findRandamNumner();
                var position = getPositionXY(cell);
                int x = position.x;
                int y = position.y;
                var possibleInSqure = !isExistInSqure(x, y, ranNum);
                var possibleInRow = !isExistInRow(x, y, ranNum);
                var possibleInColumn = !isExistInColumn(x, y, ranNum);
                if (possibleInSqure && possibleInRow && possibleInColumn)
                {
                    sudukoObj[x, y] = ranNum;
                }
            }
        }

        private static bool isExistInRow(int x, int y, int num)
        {
            bool result = false;
            for (int i = 0; i < 9; i++)
            {
                if (sudukoObj[x, i] == num)
                {
                    result = true;
                }
            }
            return result;
        }

        private static bool isExistInColumn(int x, int y, int num)
        {
            bool result = false;
            for (int i = 0; i < 9; i++)
            {
                if (sudukoObj[i, y] == num)
                {
                    result = true;
                }
            }
            return result;
        }

        private static bool isExistInSqure(int x, int y, int num)
        {
            if (x >= 0 && x < 3)
            {
                x = 0;
            }
            else if (x >= 3 && x < 6)
            {
                x = 3;
            }
            else if (x >= 6 && x < 9)
            {
                x = 6;
            }

            if (y >= 0 && y < 3)
            {
                y = 0;
            }
            else if (y >= 3 && y < 6)
            {
                y = 3;
            }
            else if (y >= 6 && y < 9)
            {
                y = 6;
            }
            bool isExist = false;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (sudukoObj[i, j] == num)
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;

        }

        private static posionXY getPositionXY(int cell)
        {
            int count = 1;
            var obj = new posionXY();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (count == cell)
                    {

                        obj.x = i;
                        obj.y = j;

                    }
                    count++;
                }
            }
            return obj;
        }

        private static int findRandamCell()
        {
            return random.Next(1, 81);
        }

        private static int findRandamNumner()
        {
            return random.Next(1, 9);
        }

        private static void printSuduko()
        {
            // print sudoku
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    //sudukoObj[i, j] = 9;
                    Console.Write(sudukoObj[i, j].ToString() + "|");
                }
                Console.WriteLine();
                for (int k = 0; k < 9; k++)
                {
                    Console.Write("__");
                }
                Console.WriteLine();
            }
        }
    }
}
