
using libopenconnect;

namespace ConnectToUrl;

#pragma warning disable CA1416 // Validate platform compatibility

internal static class Platform {
    static Platform() {
#if WINDOWS
        libopenconnect.Platform.CredentialManager = new Windows.WindowsCredentialManager();

#if WEBVIEW
        libopenconnect.Platform.WebView = new Windows.WindowsWebView();
#endif

#elif MACOS
        libopenconnect.Platform.CredentialManager = new OSX.OSXCredentialManager();
#else
        throw new System.PlatformNotSupportedException();
#endif

        libopenconnect.Platform.ChangeConsoleTitle = ConsoleTitle.Change;
    }

    // ReSharper disable MemberInitializerValueIgnored
    // ReSharper disable RedundantDefaultMemberInitializer
    // ReSharper disable ReplaceAutoPropertyWithComputedProperty
    public static IOSFunctionality OSFunctionality => libopenconnect.Platform.OSFunctionality;
    internal static ICredentialManager CredentialManager => libopenconnect.Platform.CredentialManager;
    internal static IWebView? WebView => libopenconnect.Platform.WebView;
}