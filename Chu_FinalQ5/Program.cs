using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chu_FinalQ5
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
    public class Node : IComparable<Node>
    {
        public int nState;
        public List<Edge> edges = new List<Edge>();
        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;
        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }
        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }
        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }
    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;
        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }
        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }
    internal class Program
    {
        static List<Node> colorNodes = new List<Node>();
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
        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node>();
            shortestPath.Add(colorNodes[7]);
            BuildShortestPath(shortestPath, colorNodes[7]);
            shortestPath.Reverse();
            return (shortestPath);
        }
        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }
            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }
        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }
        static private void DijkstraSearch()
        {
            Node start = colorNodes[0];
            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);
            Func<Node, int> nodeOrderBy = NodeOrderBy;
            do
            {
                prioQueue.Sort();
                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in node.edges.OrderBy(delegate (Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }
                    if (childNode.minCostToStart == int.MaxValue || node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }
                node.visited = true;
                if (node == colorNodes[7])
                {
                    return;
                }
            } while (prioQueue.Any());
        }
        static void Main(string[] args)
        {
            Node node;
            foreach(EColor color in Enum.GetValues(typeof(EColor)))
            {
                node = new Node((int)color);
                colorNodes.Add(node);
            }
            colorNodes[0].AddEdge(1, colorNodes[1]);
            colorNodes[0].AddEdge(5, colorNodes[4]);
            colorNodes[0].edges.Sort(); //red
            colorNodes[1].AddEdge(8, colorNodes[2]);
            colorNodes[1].AddEdge(1, colorNodes[3]);
            colorNodes[1].edges.Sort(); //blue
            colorNodes[2].AddEdge(6, colorNodes[7]);
            colorNodes[2].edges.Sort(); //yellow
            colorNodes[3].AddEdge(1, colorNodes[1]);
            colorNodes[3].AddEdge(0, colorNodes[4]);
            colorNodes[3].edges.Sort(); //cyan
            colorNodes[4].AddEdge(0, colorNodes[3]);
            colorNodes[4].AddEdge(1, colorNodes[6]);
            colorNodes[4].edges.Sort(); //gray
            colorNodes[5].AddEdge(1, colorNodes[2]);
            colorNodes[5].edges.Sort(); //purple
            colorNodes[6].AddEdge(1, colorNodes[5]);
            colorNodes[6].edges.Sort(); //orange
            colorNodes[7].edges.Sort(); //green
            List<Node> shortestPath = GetShortestPathDijkstra();
            foreach(Node color in shortestPath)
            {
                Console.Write((EColor)color.nState + " ");
            }
        }
    }
}