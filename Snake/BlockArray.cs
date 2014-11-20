using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class BlockArray
    {

       static int x;
       static int y;
       public Block[,] blockArray;

        public BlockArray(int numberOfXRows, int numberOfYRows)
        {
            x = numberOfXRows;
            y = numberOfYRows;

            blockArray = new Block[x, y];
        }

      
    }
}
