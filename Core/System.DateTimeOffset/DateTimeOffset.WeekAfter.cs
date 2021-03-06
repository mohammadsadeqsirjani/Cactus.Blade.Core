﻿using System;
public static partial class Extension
{
    /// <summary>
    /// Increases supplied <see cref="DateTime"/> for 7 days ie returns the Next Week.
    /// </summary>
    public static DateTimeOffset WeekAfter(this DateTimeOffset @this)
    {
        return @this + 1.Weeks();
    }
}
