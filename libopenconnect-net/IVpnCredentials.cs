using System;

namespace libopenconnect;

public interface IVpnCredentials {
    String Username { get; }
    String Password { get; }
    void Fail();
    void Success();
}