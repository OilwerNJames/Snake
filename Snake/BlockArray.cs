using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class BlockArray
    {
       //Variabler
       static int x;
       static int y;
       public Block[,] blockArray;

        /// <summary>
        /// Konstruktör för storleken av 2d arrayn av typen block. Initiera blockarray. 
        /// </summary>
        /// <param name="numberOfXRows">Hur många block i x axis</param>
        /// <param name="numberOfYRows">Hur många block i y axis</param>
        public BlockArray(int numberOfXRows, int numberOfYRows)
        {
            x = numberOfXRows;
            y = numberOfYRows;

            blockArray = new Block[x, y];
        }

      
    }
}
