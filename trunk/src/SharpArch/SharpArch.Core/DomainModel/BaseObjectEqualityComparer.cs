﻿using System.Collections.Generic;

namespace SharpArch.Core.DomainModel
{
    /// <summary>
    /// Provides a comparer for supporting LINQ methods such as Intersect, Union and Distinct
    /// </summary>
    public class BaseObjectEqualityComparer : IEqualityComparer<BaseObject>
    {
        public bool Equals(BaseObject firstObject, BaseObject secondObject) {
            if (firstObject == null && secondObject == null)
                return true;

            if (firstObject == null ^ secondObject == null)
                return false;

            return firstObject.Equals(secondObject);
        }

        public int GetHashCode(BaseObject obj) {
            return obj.GetHashCode();
        }
    }
}
