
using System.Collections.Generic;
using System.Numerics;
namespace graphedBoard {

    class Graph
    {
        private Dictionary<int, List<int>> adjList;

        public Graph()
        {
            adjList = new Dictionary<int, List<int>>();
        }

        public void addEdge(int u, int v)
        {
            if (!adjList.ContainsKey(u))
            {
                adjList[u] = new List<int> { v };
            }

            if(!adjList.ContainsKey(v))
            {
                adjList[v] = new List<int> { u };
            }

            if (!adjList[u].Contains(v))
                adjList[u].Add(v);
            if (!adjList[v].Contains(u))
                adjList[v].Add(u);
        }

        public void PrintGraph()
        {
            foreach (var kvp in adjList)
            {
                Console.Write(kvp.Key + " -> ");
                foreach (var neighbor in kvp.Value)
                    Console.Write(neighbor + " ");
                Console.WriteLine();
            }
        }

        public void traverse(int initial, int depth = 0)
        {
            List<bool> visited = new List<bool>(new bool[26]);

            Queue<int> check = new Queue<int>();
            check.Enqueue(initial);
            visited[initial] = true;

            while(check.Count()>0)
            {
                int pos = check.Dequeue(); // Say 1 ayo then 1->2,6,7
                Console.WriteLine(pos);
                List<int> adjcent_nodes = adjList[pos]; // adject_nodes now have 2,6,7
                foreach(int p in adjcent_nodes)
                {
                    if (visited[p] == false)
                    {
                        check.Enqueue(p); // 2,6,7 are now in queue 7,6,2
                        visited[p] = true; // now 2,6,7 are marked visited
                    }

                }
            }
        }
    }
    
    class Board
    {
        Graph boardGraph = new Graph();
        public Board()
        {
            // Horizontal edges
            for (int i = 1; i <= 25; i += 5) { 
                for (int j = i; j < i + 4; j++) { 
                    
                        boardGraph.addEdge(j, j + 1 );
                    
                }
            }
            // Vertical edges
            for (int i = 1; i <= 5; i++) { 
                for (int j = i; j <= 20; j += 5) { 
                    
                        boardGraph.addEdge(j, j + 5);
                    
                }
            }
            // Diagonal edges
            boardGraph.addEdge(1, 7); boardGraph.addEdge(7, 13); boardGraph.addEdge(13, 19); boardGraph.addEdge(19, 25);  // Left-to-right diagonal
            boardGraph.addEdge(5, 9); boardGraph.addEdge(9, 13); boardGraph.addEdge(13, 17); boardGraph.addEdge(17, 21);  // Right-to-left diagonal

            // Diamond edges (3, 11, 15, 23)
            boardGraph.addEdge(3, 11); boardGraph.addEdge(11, 23); boardGraph.addEdge(23, 15); boardGraph.addEdge(15, 3);
            boardGraph.PrintGraph();

        }
        public void boardMain()
        {
            Console.WriteLine("Board main");
        }

        public Graph getGraph()
        {
            return boardGraph;
        }
    }


}
/*
    Store the current state of the board
    Provide methods to place markers (bag or veda) 
    Check for empty spaces and stuff
    Display the board
*/
