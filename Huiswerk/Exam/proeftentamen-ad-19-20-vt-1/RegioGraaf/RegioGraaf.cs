using System;
using System.Collections.Generic;
using System.Linq;

namespace AD
{
    public partial class Graph
    {
        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented during exam
        //----------------------------------------------------------------------
        public void RegioClearAll() // Calls Vertex.RegionReset() for all vertices
        {
            foreach (Vertex vortex in vertexMap.Values)
            {
                vortex.RegioReset();
            }
        }

        public string AllPaths()
        {
            string turnToString = "";
            foreach(Vertex vertex in vertexMap.Select(x => x.Value))
            {
                turnToString += vertex.name + ";";
            }

            return turnToString;
        }

        public void AddUndirectedEdge(string source, string dest, double cost)
        {
            Vertex sourceVertex = GetVertex(source);
            Vertex destinationVertex = GetVertex(dest);
            sourceVertex.adj.AddLast(new Edge(destinationVertex, cost));
            destinationVertex.adj.AddLast(new Edge(sourceVertex, cost));
        }


        public void AddVertex(string name, string regio)
        {
            if (!vertexMap.ContainsKey(name))
            {
                vertexMap.Add(name, new Vertex(name, regio));
            }
        }


        public void RegioDijkstra(string name)
        {
            RegioClearAll();

            Vertex startingVertex = GetVertex(name);
            PriorityQueue<Vertex> priorityQueue = new PriorityQueue<Vertex>();

            startingVertex.distance = 0;
            priorityQueue.AddFreely(startingVertex);

            while (priorityQueue.size != 0)
            {
                startingVertex = GetAndRemoveLowestVertex(priorityQueue);

                if (startingVertex.known)
                {
                    continue; // Will make you start at the beginning of the while loop again.
                }

                startingVertex.known = true;
                foreach (Edge e in startingVertex.adj)
                {
                    Vertex adjacentVertex = e.dest;
                    if (startingVertex.distance + e.cost < adjacentVertex.distance && !adjacentVertex.known)
                    {
                        adjacentVertex.distance = startingVertex.distance + e.cost;
                        adjacentVertex.prev = startingVertex;
                    }
                    priorityQueue.AddFreely(adjacentVertex);
                }
            }
        }
    }
}
