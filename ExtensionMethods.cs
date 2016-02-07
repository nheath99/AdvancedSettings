using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AdvancedSettings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Note: does not work with Nullable types.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attr"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T GetAs<T>(this XAttribute attr, T defaultValue = default(T))
        {
            T ret = defaultValue;

            if (attr != null && !string.IsNullOrEmpty(attr.Value))
            {
                ret = (T)Convert.ChangeType(attr.Value, typeof(T));
            }

            return ret;
        }

        public static T ContainsAttribute<T>(this System.Configuration.SettingsAttributeDictionary dict)
        {
            foreach (var item in dict.Keys)
            {
                var value = dict[item];
                string attributeName = value.GetType().Name;
                if (attributeName == typeof(T).Name)
                {
                    return (T)value;
                }
            }
            return default(T);
        }

        public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.MaxBy(selector, Comparer<TKey>.Default);
        }

        public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector, IComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            using (IEnumerator<TSource> sourceIterator = source.GetEnumerator())
            {
                if (!sourceIterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence is empty");
                }
                TSource max = sourceIterator.Current;
                TKey maxKey = selector(max);
                while (sourceIterator.MoveNext())
                {
                    TSource candidate = sourceIterator.Current;
                    TKey candidateProjected = selector(candidate);
                    if (comparer.Compare(candidateProjected, maxKey) > 0)
                    {
                        max = candidate;
                        maxKey = candidateProjected;
                    }
                }
                return max;
            }
        }
    }
}
