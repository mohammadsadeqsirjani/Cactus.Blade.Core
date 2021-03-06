﻿public static partial class Extension
{
    /// <summary>
    ///     Replaces one or more format items in a specified string with the string representation of a specified object.
    /// </summary>
    /// <param name="this">A composite format string.</param>
    /// <param name="arg0">The object to format.</param>
    /// <returns>A copy of  in which any format items are replaced by the string representation of .</returns>
    public static string Format(this string @this, object arg0)
    {
        return string.Format(@this, arg0);
    }

    /// <summary>
    ///     Replaces the format items in a specified string with the string representation of two specified objects.
    /// </summary>
    /// <param name="this">A composite format string.</param>
    /// <param name="arg0">The first object to format.</param>
    /// <param name="arg1">The second object to format.</param>
    /// <returns>A copy of  in which format items are replaced by the string representations of  and .</returns>
    public static string Format(this string @this, object arg0, object arg1)
    {
        return string.Format(@this, arg0, arg1);
    }

    /// <summary>
    ///     Replaces the format items in a specified string with the string representation of three specified objects.
    /// </summary>
    /// <param name="this">A composite format string.</param>
    /// <param name="arg0">The first object to format.</param>
    /// <param name="arg1">The second object to format.</param>
    /// <param name="arg2">The third object to format.</param>
    /// <returns>
    ///     A copy of  in which the format items have been replaced by the string representations of , , and .
    /// </returns>
    public static string Format(this string @this, object arg0, object arg1, object arg2)
    {
        return string.Format(@this, arg0, arg1, arg2);
    }

    /// <summary>
    ///     Replaces the format item in a specified string with the string representation of a corresponding object in a
    ///     specified array.
    /// </summary>
    /// <param name="this">A composite format string.</param>
    /// <param name="args">An object array that contains zero or more objects to format.</param>
    /// <returns>
    ///     A copy of  in which the format items have been replaced by the string representation of the corresponding
    ///     objects in .
    /// </returns>
    public static string Format(this string @this, object[] args)
    {
        return string.Format(@this, args);
    }
}