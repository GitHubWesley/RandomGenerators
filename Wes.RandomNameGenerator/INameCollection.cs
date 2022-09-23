using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.NameGenerator
{
    public interface INameCollection
    {
        public IEnumerable<string> FirstNames { get; }

        public IEnumerable<string> LastNames { get; }

    }
}
