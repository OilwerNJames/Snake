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

        //Ny objekt av blockarray och Snake
        BlockArray theBlockArrayObject;
        Snake theSnake;
      

       // List<Block> blockList = new List<Block>();

        /// <summary>
        /// Metod att skapa en ny block med valuterna av inparametranar, 
        /// </summary>
        /// <param name="x">x värdet</param>
        /// <param name="y">y värdet</param>
        /// <param name="status">Om det är röd eller inte</param>
        /// <param name="blockArray">2d array och platsen av x och y värdet är där den nya block läggs</param>
        public void createBlock(int x, int y, string status, Block[,] blockArray)
        {
            Block newBlock = new Block(x, y, status, false);
            blockArray[newBlock.X, newBlock.Y] = newBlock;
        }

        /// <summary>
        /// Samma som create block utan denna updatera så man ändra statusen på en block med de x och y koordinater i parameter. 
        /// </summary>
        /// <param name="x"> x värdet</param>
        /// <param name="y"> y värdet</param>
        /// <param name="status">röd eller inte</param>
        /// <param name="blockArray">arrayn där det ligger</param>
        public void updateBlock(int x, int y, string status, Block[,] blockArray)
        {
            blockArray[x, y].Status = status;
        }

        /// <summary>
        /// Metoden att create en grid, får en input av string från main klassen, den har en antal av x och y värdet bestämms hur många
        /// gånger de två for loopen ska görs. 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="numberOfXRows"></param>
        /// <param name="numberOfYRows"></param>
        /// <param name="inputRowList">Vilka platser ska vara röd</param>
        public void createGrid(string input, int numberOfXRows, int numberOfYRows, List<string> inputRowList)
        {
            theBlockArrayObject = new BlockArray(numberOfXRows, numberOfYRows);
            theBlockArrayObject.blockArray = new Block[numberOfXRows, numberOfYRows];
            //For loop för x axis
            for (int x = 0; x < numberOfXRows; x++)
            {   //for loop för y axis, så för värje värdet av x det loopar genom y axis på den x koordinat.
                for (int y = 0; y < numberOfYRows; y++)
                {
                    //kör metod createblock för att sätta in en block på den x,y plats
                    createBlock(x, y, "free", theBlockArrayObject.blockArray);
                }
            }

            string[] takenRows = new string[inputRowList.Count()];

            //For loop at tar inputRowList, bryter up det vid "," tecken för att få de x och y koordinater av en röd block
            for (int i = 1; i < inputRowList.Count(); i++)
            {
                takenRows[i] = inputRowList[i];

                string[] busyBlockData = takenRows[i].Split(',');

                int x = Int32.Parse(busyBlockData[0]);
                int y = Int32.Parse(busyBlockData[1]);
                //kör update block att göra en block till röd
                updateBlock(x, y, "red", theBlockArrayObject.blockArray);


                //  MessageBox.Show(takenRows[i]);
            }

        }

        /// <summary>
        /// Count metoden räknar hur mångar skapad blocks finns genom for loop på värja axis, x,y.
        /// </summary>
        /// <returns>En int med värdet, hur många blocks finns</returns>
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

        /// <summary>
        /// Börjar läsa av gridden med objekt snake
        /// </summary>
        public void StartSnake()
        {
            theSnake = new Snake(theBlockArrayObject); 
        }

        /// <summary>
        /// Kör snake objekt metod getresult Som kollar om snake lyckades
        /// </summary>
        /// <returns></returns>
        public int getResult()
        {
            return theSnake.getResult();
        }

        /// <summary>
        /// Resultaten av alla besökta blocks, detta är en lista av koordinater.
        /// </summary>
        /// <returns></returns>
        public List<Block> getVisitedBlockList()
        {
            return theSnake.getVisitedBlockList();
        }


    }
}
