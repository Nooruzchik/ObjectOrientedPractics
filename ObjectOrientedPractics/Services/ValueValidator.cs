using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services;

public static class ValueValidator
{
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength)
        {
            throw new ArgumentException($"Длинна {propertyName} может быть не больше {maxLength} символов");
        }
    }
}

