using System;

namespace ClassicalDesignPatternsInCSharp.NullObject
{
    /// <summary>
    /// Null Object Pattern avoids null checks by providing a dedicated object for properties which otherwise would be null.
    /// <see cref="AccountEmpty"/>
    /// </summary>
    public class NullObjectSample
    {
        public void Run()
        {
            Person rich = new Person("John"); // has a bank account
            rich.Account = new Account();
            rich.Account.Book(1000);

            Person poor = new Person("Paul"); // has no bank account 

            var persons = new[] { rich, poor };
            foreach (var person in persons)
            {
                // iterate over accounts without null-check
                Console.WriteLine($"{person.Name}: {person.Account.Balance()}");
            }
        }
    }
}