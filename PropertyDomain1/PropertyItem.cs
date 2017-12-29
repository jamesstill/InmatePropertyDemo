using System;
using SharedKernel;

namespace PropertyDomain1
{
    public class PropertyItem : EntityBase<Guid>
    {
        public Description Description { get; }

        public PropertyItem(Guid id, Description description) : base(id)
        {
            Description = description;
        }
    }
}
