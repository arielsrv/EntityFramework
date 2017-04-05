using Collections;
using System;

namespace Collections
{
    public static class MyCollectionExtensions
    {
        public static T First<T>(this MyCollection<T> collection)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                result = item;
                break;
            }

            return result;
        }

        public static T Last<T>(this MyCollection<T> collection)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                result = item;
            }

            return result;
        }

        public static MyCollection<T> From<T>(this MyCollection<T> collection, int from)
        {
            MyCollection<T> result = new MyCollection<T>();

            int current = 0;
            foreach (var item in collection)
            {
                if (current++ < from)
                    continue;
                result.Add(item);
            }

            return result;
        }

        public static MyCollection<T> Map<T>(this MyCollection<T> collection, Func<T, T> predicate)
        {
            MyCollection<T> result = new MyCollection<T>();

            foreach (var item in collection)
            {
                T output = predicate(item);
                result.Add(output);
            }

            return result;
        }

        public static T Reduce<T>(this MyCollection<T> collection, Func<T, T, T> predicate)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                result = predicate(result, item);
            }

            return result;
        }

        public static MyCollection<T> Find<T>(this MyCollection<T> collection, Func<T, bool> predicate)
        {
            MyCollection<T> result = new MyCollection<T>();

            foreach (var item in collection)
            {
                if (predicate(item))
                    result.Add(item);
            }

            return result;
        }
    }
}
