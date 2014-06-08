using System;
using System.Collections.Generic;

namespace BlocCrusier.ObjectPooling
{
    class ObjectPoolStack : Dictionary<Type, Stack<object>>
    {
        public Stack<object> For<T>()
        {
            if (!ContainsKey(typeof (T))) Add(typeof (T), new Stack<object>());
            return this[typeof (T)];
        }
    }
}