using System;

namespace SharedKernel
{
    public abstract class EntityBase<T> : IEquatable<EntityBase<T>>
    {
        public T Id { get; private set; }

        public EntityBase(T id)
        {
            Id = id;
        }

        public override bool Equals(object entity)
        {
            return entity != null
                   && entity is EntityBase<T>
                   && this == (EntityBase<T>)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase<T> entity1, EntityBase<T> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1.Id.ToString() == entity2.Id.ToString())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(EntityBase<T> entity1, EntityBase<T> entity2)
        {
            return (!(entity1 == entity2));
        }

        public bool Equals(EntityBase<T> other)
        {
            return other != null && Id.Equals(other.Id);
        }
    }
}
