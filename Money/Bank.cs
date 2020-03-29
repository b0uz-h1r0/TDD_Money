using System;
using System.Collections.Generic;
namespace money
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();
        public Bank()
        {
        }
        public Money reduce(Expression source, string to)
        {
            return source.reduce(this, to);
        }
        public void addRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
        public int rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            // オブジェクトが同じと判定するにはハッシュコードがひつよう
            // http://mocotan.hatenablog.com/entry/2017/10/31/064738
            return rates[new Pair(from, to)];
        }
    }
}
