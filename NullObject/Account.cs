using System.Collections.Generic;
using System.Linq;

namespace ClassicalDesignPatternsInCSharp.NullObject
{
    public class Account
    {
        private IList<decimal> Bookings { get; }

        public Account()
        {
            Bookings = new List<decimal>();
        }

        public readonly Account Empty = new AccountEmpty();

        public void Book(decimal amount)
        {
            Bookings.Add(amount);
        }

        public virtual decimal Balance()
        {
            return Bookings.Sum();
        }
    }
}