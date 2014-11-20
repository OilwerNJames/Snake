using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Block
    {

        int x;
        int y;
        string status;
        bool change;
        string changeDirection;
        bool visited;

        public Block(int x, int y, string status, bool visited)
        {
            this.x = x;
            this.y = y;
            this.status = status;
            this.visited = visited;
        }

        public int X
        {
            get {return x;}
            set {x = value;}
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        public int[] somethingHappens()
        {

            int[] theArray = new int[] { 1, 2,3 };

     //       int nextX = 0;
       //     int nextY = 0;


            return theArray;
        }


    }
}
