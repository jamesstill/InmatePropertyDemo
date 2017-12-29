using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain3
{
    public class LockerCompartment : ValueObjectBase<LockerCompartment>
    {
        public LockerCompartment(int lockerNumber)
        {
            Check.That(lockerNumber.IsGreaterThanZero()).OnFailure(() => throw new ArgumentException("You must specify a locker number."));
            LockerNumber = lockerNumber;
        }

        public int LockerNumber { get; }

        protected override IEnumerable<object> GetEqualityAttributes()
        {
            return new List<object>()
            {
                LockerNumber
            };
        }
    }
}
