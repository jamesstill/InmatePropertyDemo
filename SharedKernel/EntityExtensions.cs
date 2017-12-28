using System;

namespace SharedKernel
{
    public static class EntityExtensions
    {
        public static bool IsNotNull(this EntityBase<Guid> self)
        {
            return self != null;
        }
    }
}
