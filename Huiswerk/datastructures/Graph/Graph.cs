using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        public Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Adds a vertex to the graph. If a vertex with the given name
        ///    already exists, no action is performed.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public void AddVertex(string name)
        {
            if (!vertexMap.ContainsKey(name))
            {
                vertexMap.Add(name, new Vertex(name));
            }
        }


        /// <summary>
        ///    Gets a vertex from the graph by name. If no such vertex exists,
        ///    a new vertex will be created and returned.
        /// </summary>
        /// <param name="name">The name of the vertex</param>
        /// <returns>The vertex withe the given name</returns>
        public Vertex GetVertex(string name)
        {
            AddVertex(name);
            return vertexMap[name];
        }


        /// <summary>
        ///    Creates an edge between two vertices. Vertices that are non existing
        ///    will be created before adding the edge.
        ///    There is no check on multiple edges!
        /// </summary>
        /// <param name="source">The name of the source vertex</param>
        /// <param name="dest">The name of the destination vertex</param>
        /// <param name="cost">cost of the edge</param>
        public void AddEdge(string source, string dest, double cost = 1)
        {
            Vertex sourceVertex = GetVertex(source);
            Vertex destinationVertex = GetVertex(dest);
            sourceVertex.adj.AddLast(new Edge(destinationVertex, cost));
        }


        /// <summary>
        ///    Clears all info within the vertices. This method will not remove any
        ///    vertices or edges.
        /// </summary>
        public void ClearAll()
        {
            foreach (Vertex vortex in vertexMap.Values)
            {
                vortex.Reset();
            }
        }

        /// <summary>
        ///    Performs the Breatch-First algorithm for unweighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Unweighted(string name)
        {
            ClearAll();

            Vertex beginVertex = GetVertex(name);

            Queue<Vertex> q = new Queue<Vertex>();
            beginVertex.distance = 0;
            q.Enqueue(beginVertex);

            while (q.Count > 0)
            {
                Vertex oldVertex = q.Dequeue();

                foreach (Edge edge in oldVertex.adj)
                {
                    Vertex adjacentVertex = edge.dest;
                    if(adjacentVertex.distance == INFINITY)
                    {
                        adjacentVertex.distance = oldVertex.distance + 1;
                        adjacentVertex.prev = oldVertex;
                        q.Enqueue(adjacentVertex);
                    }
                }
            }
        }

        /// <summary>
        ///    Performs the Dijkstra algorithm for weighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Dijkstra(string name)
        {
            PriorityQueue<Edge> priorityQueue = new PriorityQueue<Edge>();
            int nodesSeen = 0;

            Vertex startVertex = GetVertex(name);
            startVertex.distance = 0;
            priorityQueue.Add(new Edge(startVertex, 0));

            while(priorityQueue.Size() > 0 && nodesSeen < vertexMap.Count)
            {
                Edge oldEdge = priorityQueue.Remove();
                Vertex oldVertex = oldEdge.dest;
                nodesSeen++;

                foreach (var edge in oldVertex.adj)
                {
                    Vertex adjacentVertex = edge.dest;

                    if(oldVertex.distance > adjacentVertex.distance + edge.cost)
                    {
                        oldVertex.distance = adjacentVertex.distance + edge.cost;
                        oldVertex.prev = adjacentVertex;
                        priorityQueue.Add(new Edge(oldVertex, oldVertex.distance));
                    }
                }
            }
        }

        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Graph to its string representation.
        ///    It will call the ToString method of each Vertex. The output is
        ///    ascending on vertex name.
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns>
        public override string ToString()
        {
            string turnToString = "";
            foreach (Vertex vertex in vertexMap.OrderBy(x => x.Value.name).Select(x => x.Value))
            {
                turnToString += vertex.ToString();
            }
            return turnToString;
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------



        public bool IsConnected()
        {
            throw new System.NotImplementedException();
        }

    }
}