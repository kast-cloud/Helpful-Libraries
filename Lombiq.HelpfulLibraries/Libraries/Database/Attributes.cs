﻿using System;

namespace Lombiq.HelpfulLibraries.Libraries.Database
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ContentItemIdColumnAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UnlimitedLengthAttribute : Attribute
    {
    }
}
