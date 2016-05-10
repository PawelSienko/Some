﻿namespace Randomizer.Interfaces
{
    public interface IRandomDigit<in TSeed, TType>
        : IRandomValueType<TSeed, TType>
        where TType : struct
        where TSeed : new()
    {
        TType GeneratePositiveValue(TType min, TType max);

        TType GenerateNegativeValue(TType min, TType max);
    }
}
