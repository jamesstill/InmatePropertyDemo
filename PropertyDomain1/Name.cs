using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain1
{
    public class Name : ValueObjectBase<Name>
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public Name(string firstName, string middleName, string lastName)
        {
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
