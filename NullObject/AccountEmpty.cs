namespace ClassicalDesignPatternsInCSharp.NullObject
{
    internal sealed class AccountEmpty : Account
    {
        public override decimal Balance()
        {
            return 0;
        }
    }
}