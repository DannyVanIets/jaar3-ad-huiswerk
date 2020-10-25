using System;
using System.Collections.Generic;

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
            RegioClearAll();

            return "";
        }

        public void AddUndirectedEdge(string source, string dest, double cost)
        {
            throw new System.NotImplementedException();
        }


        public void AddVertex(string name, string regio)
        {
            throw new System.NotImplementedException();
        }


        public void RegioDijkstra(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
