
using System.Runtime.InteropServices;
using System;

namespace libopenconnect;

#pragma warning disable CA1416 // Validate platform compatibility

public static class Platform {
    static Platform() {
#if WINDOWS
        OSFunctionality = new Windows.WindowsFunctionality();

#if WEBVIEW
        WebView = new Windows.WindowsWebView();
#endif

#elif MACOS
        OSFunctionality = new OSX.OSXFunctionality();
#else
        throw new System.PlatformNotSupportedException();
#endif
    }

    // ReSharper disable MemberInitializerValueIgnored
    // ReSharper disable RedundantDefaultMemberInitializer
    // ReSharper disable ReplaceAutoPropertyWithComputedProperty
    public static IOSFunctionality OSFunctionality { get; } = default!;
    public static ICredentialManager CredentialManager { get; set;  } = default!;
    public static IWebView? WebView { get; set; } = default;

    public static Func<String, IDisposable> ChangeConsoleTitle = (s) => DisposableAction.Noop;
}