using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_FinalQ3
{
    enum EColor
    {
        red,
        blue,
        yellow,
        cyan,
        gray,
        purple,
        orange,
        green
    }
    internal class Program
    {
        static int[,] colorMGraph = new[,]
        {
            {-1,1,-1,-1,5,-1,-1,-1}, //red
            {-1,1,8,1,-1,-1,-1,-1}, //blue
            {-1,-1,-1,-1,-1,-1,-1,6}, //yellow
            {-1,1,-1,-1,0,-1,-1,-1}, //cyan
            {-1,-1,-1,0,-1,-1,1,-1}, //gray
            {-1,-1,1,-1,-1,-1,-1,-1}, //purple
            {-1,-1,-1,-1,-1,1,-1,-1}, //orange
            {-1,-1,-1,-1,-1,-1,-1,-1}, //green
        };
        static int[][] colorAGraph = new int[][]
        {
            new int[] {(int)EColor.blue, (int)EColor.gray}, //red
            new int[] {(int)EColor.yellow, (int)EColor.cyan}, //blue
            new int[] {(int)EColor.green}, //yellow
            new int[] {(int)EColor.blue, (int)EColor.gray}, //cyan
            new int[] {(int)EColor.cyan, (int)EColor.orange}, //gray
            new int[] {(int)EColor.yellow}, //purple
            new int[] {(int)EColor.purple}, //orange
            null //green
        };
        static int[][] colorWGraph = new int[][]
        {
            new int[] {1, 5}, //red
            new int[] {8, 1}, //blue
            new int[] {6}, //yellow
            new int[] {1, 0}, //cyan
            new int[] {0, 1}, //gray
            new int[] {1}, //purple
            new int[] {1}, //orange
            null //green
        };
        static void Main(string[] args)
        {

        }
    }
}