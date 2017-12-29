using System;
using System.Collections.Generic;
using SharedKernel;

namespace PropertyDomain3
{
    /// <summary>
    /// The PropertyBag is the aggregate root.
    /// </summary>
    public class PropertyBag : EntityBase<Guid>
    {
        private readonly Person _person;
        private readonly LockerCompartment _lockerCompartment;
        private readonly IList<PropertyItem> _propertyItems = new List<PropertyItem>();

        public PropertyBag(Guid id, Person person, LockerCompartment lockerCompartment) : base(id)
        {
            Check.That(person.IsNotNull()).OnFailure(() =>
                throw new ArgumentException("A person cannot be null."));

            _person = person;
            _lockerCompartment = lockerCompartment;
        }

        public IEnumerable<PropertyItem> PropertyItems => _propertyItems;

        internal int GetLockerNumber()
        {
            return _lockerCompartment.LockerNumber;
        }

        internal Person GetPerson()
        {
            return _person;
        }

        internal void AddPropertyItem(PropertyItem item)
        {
            Check.That(item.IsNotNull()).OnFailure(() =>
                throw new ArgumentException("Null property item cannot be added to the property bag."));

            _propertyItems.Add(item);
        }
    }
}
