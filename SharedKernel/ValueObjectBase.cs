using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedKernel
{
    public abstract class ValueObjectBase<T> : IEquatable<T> where T : ValueObjectBase<T>
    {
        protected abstract IEnumerable<object> GetEqualityAttributes();

        public override bool Equals(object obj)
        {
            return Equals(obj as T);
        }

        public bool Equals(T obj)
        {
            return obj != null && GetEqualityAttributes().SequenceEqual(obj.GetEqualityAttributes());
        }

        public static bool operator ==(ValueObjectBase<T> left, ValueObjectBase<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueObjectBase<T> left, ValueObjectBase<T> right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return GetEqualityAttributes().Aggregate(17, (current, obj) => current * 31 + (obj == null ? 0 : obj.GetHashCode()));
        }
    }
}
