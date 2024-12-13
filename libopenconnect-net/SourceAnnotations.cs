using System;

namespace libopenconnect;

/// <summary>
///   This attribute has no runtime functionality. It only exists to keep track
///   of the original C and C++ types from external headers and documentation.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public class SourceTypeAttribute(String value) : Attribute {
}

/// <summary>
///   This attribute has no runtime functionality. It only exists to keep track
///   of the original C and C++ types from external headers and documentation.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
internal class SourceReference : Attribute {
    public SourceReference(String filename, Int32 value) {}
    public SourceReference(String filename, Int32 start, Int32 end) {}
}