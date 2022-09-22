using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wes.RandomNameGenerator
{
    internal static class Extensions
    {
        public static T GetOneRandomly<T>(this IEnumerable<T> collection, Random random = null)
        {
            random ??= new Random();

            var randomIndex = random.Next(collection.Count());

            return collection.ElementAt(randomIndex);
        }
    }
}
