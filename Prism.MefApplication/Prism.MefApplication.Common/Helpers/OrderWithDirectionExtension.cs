using System;
using System.Collections.Generic;
using System.Linq;

namespace Prism.MefApplication.Common.Helpers
{
    public static class OrderWithDirectionExtension
    {
        public static IOrderedEnumerable<TSource> OrderByWithDirection<TSource, TKey>(
            this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, bool descending = false)
        {
            return descending
                ? source.OrderByDescending(keySelector)
                : source.OrderBy(keySelector);
        }
    }
}
