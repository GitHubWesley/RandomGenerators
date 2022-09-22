using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.RandomNameGenerator
{
    public interface INameGenerator
    {
        (string first, string last) Generate();

        string GenerateFullName();

        string GenerateFirstName();

        string GenerateLastName();
    }
}
