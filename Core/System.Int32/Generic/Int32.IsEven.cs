﻿public static partial class Extension
{
    /// <summary>
    ///     An Int32 extension method that query if '@this' is even.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if even, false if not.</returns>
    public static bool IsEven(this int @this)
    {
        return @this % 2 == 0;
    }
}