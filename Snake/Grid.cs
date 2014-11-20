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

        BlockArray theBlockArrayObject;
        Snake theSnake;
      

       // List<Block> blockList = new List<Block>();

        public void createBlock(int x, int y, string status, Block[,] blockArray)
        {
            Block newBlock = new Block(x, y, status, false);
            blockArray[newBlock.X, newBlock.Y] = newBlock;
        }

        public void updateBlock(int x, int y, string status, Block[,] blockArray)
        {
            blockArray[x, y].Status = status;
        }

        public void createGrid(string input, int numberOfXRows, int numberOfYRows, List<string> inputRowList)
        {
            theBlockArrayObject = new BlockArray(numberOfXRows, numberOfYRows);
            theBlockArrayObject.blockArray = new Block[numberOfXRows, numberOfYRows];

            for (int x = 0; x < numberOfXRows; x++)
            {
                for (int y = 0; y < numberOfYRows; y++)
                {
                    createBlock(x, y, "free", theBlockArrayObject.blockArray);
                }
            }

            string[] takenRows = new string[inputRowList.Count()];

            for (int i = 1; i < inputRowList.Count(); i++)
            {
                takenRows[i] = inputRowList[i];

                string[] busyBlockData = takenRows[i].Split(',');

                int x = Int32.Parse(busyBlockData[0]);
                int y = Int32.Parse(busyBlockData[1]);

                updateBlock(x, y, "red", theBlockArrayObject.blockArray);


                //  MessageBox.Show(takenRows[i]);
            }

        }

        public int Count()
        {
            int numOfElements = 0;

            for (int row = 0; row < theBlockArrayObject.blockArray.GetLength(0); row++)  // Rad 
            {

                for (int col = 0; col < theBlockArrayObject.blockArray.GetLength(1); col++) // Kolumn
                   {

                       if (theBlockArrayObject.blockArray[row, col] != null)
                       {
                           if ((theBlockArrayObject.blockArray[row, col].Status == "free") || (theBlockArrayObject.blockArray[row, col].Status == "red"))
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
            theSnake = new Snake(theBlockArrayObject); // Börjar läsa av gridden
        }

        public int getResult()
        {
            return theSnake.getResult();
        }

        public List<Block> getVisitedBlockList()
        {
            return theSnake.getVisitedBlockList();
        }


    }
}
