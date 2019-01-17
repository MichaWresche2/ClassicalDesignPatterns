using System;

namespace ClassicalDesignPatternsInCSharp.NullObject
{
    public class Person
    {

        public Person(string name)
        {
            Name = name;
            Account = Account.Empty;
        }

        public string Name { get; }

        private Account AccountValue;
        public Account Account
        {
            get => AccountValue;
            set => AccountValue = value ?? throw new ArgumentNullException();
        }
    }
}