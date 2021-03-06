﻿public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is in the past.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if the value is in the past, false if not.</returns>
    public static bool IsPast(this System.DateTimeOffset @this)
    {
        return @this < System.DateTimeOffset.Now;
    }
}