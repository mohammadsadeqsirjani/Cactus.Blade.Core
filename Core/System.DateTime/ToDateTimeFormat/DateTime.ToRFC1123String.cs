﻿using System.Globalization;

public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that converts this object to a rfc 1123 string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToRfc1123String(this System.DateTime @this)
    {
        return @this.ToString("r", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a rfc 1123 string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToRfc1123String(this System.DateTime @this, string culture)
    {
        return @this.ToString("r", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a rfc 1123 string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToRfc1123String(this System.DateTime @this, CultureInfo culture)
    {
        return @this.ToString("r", culture);
    }
}