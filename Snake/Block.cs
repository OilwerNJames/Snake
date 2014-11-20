using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Block
    {
        //Variabler för en individ block, x och y för coordinater och sen status om den är en "röd" block. Sen en bool visited för att kolla om det har varit besökt av snaken
        int x;
        int y;
        string status;
        bool change;
        string changeDirection;
        bool visited;

        //Konstruktör för block
        public Block(int x, int y, string status, bool visited)
        {
            this.x = x;
            this.y = y;
            this.status = status;
            this.visited = visited;
        }

        /// <summary>
        /// Property så man kan komma åt x värdet
        /// </summary>
        public int X
        {
            get {return x;}
            set {x = value;}
        }

        /// <summary>
        /// Property så man kan komma åt y värdet
        /// </summary>
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Property så man kan komma åt status värdet
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Property så man kan komma åt visited värdet
        /// </summary>
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
