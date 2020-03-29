using System;
namespace money
{
    public class Money : Expression
    {
        protected int _amount;
        protected string _currency;

        public Expression times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
        public Expression plus(Expression addend)
        {
            return new Sum(this, addend);
        }
        public Money reduce(Bank bank, string to)
        {
            int rate = bank.rate(currency, to);
            return new Money(amount / rate, to);
        }
        public string currency
        {
            get { return _currency; }
        }
        public int amount
        {
            get { return _amount; }
        }
        public Money(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }
        public override bool Equals(object arg_object)
        {
            Money money = (Money)arg_object;
            return amount == money.amount
                && currency.Equals(money.currency);
        }
        public override int GetHashCode()
        {
            return _amount.GetHashCode() ^ _currency.GetHashCode();
        }
        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }
        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
