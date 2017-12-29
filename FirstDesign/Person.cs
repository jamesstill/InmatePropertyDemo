using System.Collections.Generic;

namespace FirstDesign
{
    public class Person
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
