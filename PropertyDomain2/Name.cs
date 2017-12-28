using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain2
{
    public class Name : ValueObjectBase<Name>
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public Name(string firstName, string middleName, string lastName)
        {
            Check.That(firstName.IsNotNullOrEmpty()).OnFailure(() => throw new ArgumentException("You must specify a first name."));
            Check.That(lastName.IsNotNullOrEmpty()).OnFailure(() => throw new ArgumentException("You must specify a last name."));

            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        protected override IEnumerable<object> GetEqualityAttributes()
        {
            return new[] { FirstName, MiddleName, LastName };
        }
    }
}
