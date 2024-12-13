
namespace libopenconnect;

public unsafe interface IWebView {
    void Attach(OpenConnect.openconnect_info* vpninfo);
}