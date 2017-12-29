using System;
using SharedKernel;

namespace PropertyDomain3
{
    public class Person : EntityBase<Guid>
    {
        public Person(Guid id, Name name) : base(id)
        {
            Name = name;
        }

        public Name Name { get; }
    }
}
