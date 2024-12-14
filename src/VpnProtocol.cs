using System;
using static OpenConnect;

internal class VpnProtocol {
    public String Name;
    public String PrettyName;
    public String Description;
    public OC_PROTO_FLAGS Flags;

    public VpnProtocol(String name, String prettyName, String description, OC_PROTO_FLAGS flags) {
        Name = name;
        PrettyName = prettyName;
        Description = description;
        Flags = flags;
    }

    public override String ToString() => $"{Name}, {PrettyName}, {Description}, {Flags}";
}