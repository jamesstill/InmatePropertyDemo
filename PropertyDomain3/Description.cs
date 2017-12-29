using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain3
{
    public class Description : ValueObjectBase<Description>
    {
        public string ShortDescription { get; }

        public string LongDescription { get; }

        public Description(string shortDescription, string longDescription)
        {
            Check.That(shortDescription.IsNotNullOrEmpty()).OnFailure(() => throw new ArgumentException("You must specify a short description."));

            ShortDescription = shortDescription;
            LongDescription = longDescription;
        }

        public Description FromShortDescription(string shortDescription)
        {
            return new Description(shortDescription, LongDescription);
        }

        public Description FromLongDescription(string longDescription)
        {
            return new Description(ShortDescription, longDescription);
        }

        protected override IEnumerable<object> GetEqualityAttributes()
        {
            return new[] { ShortDescription, LongDescription };
        }
    }
}
