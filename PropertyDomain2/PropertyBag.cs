using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain2
{
    public class PropertyBag : EntityBase<Guid>
    {
        private readonly Person _person;
        private readonly IList<PropertyItem> _propertyItems = new List<PropertyItem>();

        public PropertyBag(Guid id, Person person) : base(id)
        {
            Check.That(person.IsNotNull()).OnFailure(() =>
                throw new ArgumentException("A person cannot be null."));

            _person = person;
        }

        public IEnumerable<PropertyItem> PropertyItems => _propertyItems;

        internal void AddPropertyItem(PropertyItem item)
        {
            Check.That(item.IsNotNull()).OnFailure(() =>
                throw new ArgumentException("Null property item cannot be added to the property bag."));

            _propertyItems.Add(item);
        }
    }
}
