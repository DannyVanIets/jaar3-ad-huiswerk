using System;

namespace AD
{
    public partial class Edge : IComparable<Edge>
    {
        public Vertex dest;
        public double cost;

        public Edge(Vertex d, double c)
        {
            dest = d;
            cost = c;
        }

        int IComparable<Edge>.CompareTo(Edge other)
        {
            // if (cost < other.cost) -1
            // else if (cost > other.cost) 1
            // else 0
            double otherCost;
            if (other == null)
            {
                otherCost = 0;
            }
            else
            {
                otherCost = other.cost;
            }

            return cost < otherCost ? -1 : cost > otherCost ? 1 : 0;
        }
    }
}