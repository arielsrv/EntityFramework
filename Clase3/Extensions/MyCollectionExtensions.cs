using Collections;

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
    }
}
