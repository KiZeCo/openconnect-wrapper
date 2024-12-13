using System;

namespace libopenconnect;

public interface ICredentialManager {
    public IVpnCredentials? AskForCredentials(String url, String messageText);
    public IVpnCredentials? ForceAskForCredentials(String url, String messageText);
}