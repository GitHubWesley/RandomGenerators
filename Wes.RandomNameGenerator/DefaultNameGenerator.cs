using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.NameGenerator
{
    public class DefaultNameGenerator : INameGenerator
    {
        private readonly INameCollection _nameCollection;
        private readonly Random _random;

        public DefaultNameGenerator(INameCollection nameCollection, Random random = null)
        {
            _nameCollection = nameCollection;

            _random = random ?? new Random();
        }

        public (string first, string last) Generate()
        {
            string first = GenerateFirstName();
            string last = GenerateLastName();

            return (first, last);
        }

        public string GenerateFullName()
        {
            var (first, last) = Generate();

            return $"{first} {last}";
        }

        public string GenerateFirstName()
        {
            return _nameCollection.FirstNames.GetOneRandomly(_random);
        }

        public string GenerateLastName()
        {
            return _nameCollection.LastNames.GetOneRandomly(_random);
        }
    }
}
