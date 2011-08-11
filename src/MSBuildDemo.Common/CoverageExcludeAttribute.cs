using System;

namespace MSBuildDemo.Common
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class CoverageExcludeAttribute : Attribute
    {
    }
}
