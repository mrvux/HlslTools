﻿namespace ShaderTools.CodeAnalysis.Host.Mef
{
    /// <summary>
    /// This interface is provided purely to enable some shared logic that handles multiple kinds of 
    /// metadata that share the Language property. It should not be used to find exports via MEF,
    /// use LanguageMetadata instead.
    /// </summary>
    internal interface ILanguageMetadata
    {
        string Language { get; }
    }
}
