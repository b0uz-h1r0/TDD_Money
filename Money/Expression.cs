using System;
namespace money
{
    public interface Expression
    {
        Expression times(int multiplier);
        Expression plus(Expression addend);
        Money reduce(Bank bank, string to);
    }
}
