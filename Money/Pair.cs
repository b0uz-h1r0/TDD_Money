using System;
namespace money
{
    public class Pair
    {
        private string from;
        private string to;
        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }
        public override bool Equals(Object inOject)
        {
            Pair pair = inOject as Pair;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }
        public override int GetHashCode()
        {
            return from.GetHashCode() ^
                to.GetHashCode();
        }
    }
}
