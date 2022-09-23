using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.NameGenerator
{
    public interface INameGenerator
    {
        (string first, string last) Generate();

        string GenerateFullName();

        string GenerateFirstName();

        string GenerateLastName();
    }
}
