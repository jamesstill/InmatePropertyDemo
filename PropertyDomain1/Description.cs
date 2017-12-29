using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain1
{
    public class Description : ValueObjectBase<Description>
    {
        public string ShortDescription { get; }

        public string LongDescription { get; }

        public Description(string shortDescription, string longDescription)
        {
            ShortDescription = shortDescription;
            LongDescription = longDescription;
        }

        protected override IEnumerable<object> GetEqualityAttributes()
        {
            return new[] { ShortDescription, LongDescription };
        }
    }
}
