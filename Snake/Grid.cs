using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Snake
{
    class Grid
    {

        BlockArray theBlockArrayClass;
      

       // List<Block> blockList = new List<Block>();

        public void createBlock(int x, int y, string status, Block[,] blockArray)
        {
            Block newBlock = new Block(x, y, status);
            blockArray[newBlock.X, newBlock.Y] = newBlock;
        }

        public void updateBlock(int x, int y, string status, Block[,] blockArray)
        {
            blockArray[x, y].Status = status;
        }

        public void createGrid(string input, int numberOfXRows, int numberOfYRows, List<string> inputRowList)
        {
            theBlockArrayClass = new BlockArray(numberOfXRows, numberOfYRows);
            theBlockArrayClass.blockArray = new Block[numberOfXRows, numberOfYRows];

            for (int x = 0; x < numberOfXRows; x++)
            {
                for (int y = 0; y < numberOfYRows; y++)
                {
                    createBlock(x, y, "free", theBlockArrayClass.blockArray);
                }
            }

            string[] takenRows = new string[inputRowList.Count()];

            for (int i = 1; i < inputRowList.Count(); i++)
            {
                takenRows[i] = inputRowList[i];

                string[] busyBlockData = takenRows[i].Split(',');

                int x = Int32.Parse(busyBlockData[0]);
                int y = Int32.Parse(busyBlockData[1]);

                updateBlock(x, y, "red", theBlockArrayClass.blockArray);


                //  MessageBox.Show(takenRows[i]);
            }

        }

        public int Count()
        {
            int numOfElements = 0;

            for (int row = 0; row < theBlockArrayClass.blockArray.GetLength(0); row++)  // Rad 
            {

                for (int col = 0; col < theBlockArrayClass.blockArray.GetLength(1); col++) // Kolumn
                   {

                       if (theBlockArrayClass.blockArray[row, col] != null)
                       {
                           if ((theBlockArrayClass.blockArray[row, col].Status == "free") || (theBlockArrayClass.blockArray[row, col].Status == "red"))
                           {
                               numOfElements++;
                           }
                       }
                   }
            }
            return numOfElements;
        }

        public void StartSnake()
        {
           // Snake theSnake = new Snake(blockArray); // Börjar läsa av gridden
        }


    }
}
