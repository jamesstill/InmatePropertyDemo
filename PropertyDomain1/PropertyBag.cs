using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain1
{
    public class PropertyBag : EntityBase<Guid>
    {
        private readonly Person _person;
        private readonly IList<PropertyItem> _propertyItems = new List<PropertyItem>();

        public PropertyBag(Guid id, Person person) : base(id)
        {
            _person = person;
        }

        public IEnumerable<PropertyItem> PropertyItems => _propertyItems;

        internal void AddPropertyItem(PropertyItem item)
        {
            _propertyItems.Add(item);
        }
    }
}
