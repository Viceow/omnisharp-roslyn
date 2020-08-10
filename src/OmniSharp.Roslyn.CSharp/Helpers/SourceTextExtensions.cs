﻿#nullable enable

using Microsoft.CodeAnalysis.Text;
using OmniSharp.Models;

namespace OmniSharp.Roslyn.CSharp.Helpers
{
    internal static class SourceTextExtensions
    {
        public static int GetTextPosition(this SourceText sourceText, Request request)
            => sourceText.Lines.GetPosition(new LinePosition(request.Line, request.Column));
    }
}
