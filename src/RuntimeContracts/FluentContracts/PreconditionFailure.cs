﻿#nullable enable

namespace System.Diagnostics.FluentContracts
{
    /// <summary>
    /// Represents a precondition violation.
    /// </summary>
    public readonly struct PreconditionFailure
    {
        internal string Path { get; }
        internal int LineNumber { get; }

        internal PreconditionFailure(string path, int lineNumber)
        {
            Path = path;
            LineNumber = lineNumber;
        }
    }

    /// <summary>
    /// Represents a precondition violation.
    /// </summary>
    public readonly struct PreconditionDebugFailure
    {
        internal string Path { get; }
        internal int LineNumber { get; }

        internal PreconditionDebugFailure(string path, int lineNumber)
        {
            Path = path;
            LineNumber = lineNumber;
        }
    }

    /// <summary>
    /// Represents a precondition violation.
    /// </summary>
    public readonly struct PreconditionForAllFailure
    {
        internal string Path { get; }
        internal int LineNumber { get; }

        internal PreconditionForAllFailure(string path, int lineNumber)
        {
            Path = path;
            LineNumber = lineNumber;
        }
    }
}
