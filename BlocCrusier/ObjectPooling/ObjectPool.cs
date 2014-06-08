using System.Linq;
using SystemDot.Core;

namespace BlocCrusier.ObjectPooling
{
    public static class ObjectPool
    {
        static readonly ObjectPoolStack Stack;

        static ObjectPool()
        {
            Stack = new ObjectPoolStack();
        }

        public static T Get<T>() where T : new()
        {
            if(!Stack.For<T>().Any())
                Return(new T());

            return Stack.For<T>().Pop().As<T>();
        }

        public static void Return<T>(T item)
        {
            Stack.For<T>().Push(item);
        }
    }
}