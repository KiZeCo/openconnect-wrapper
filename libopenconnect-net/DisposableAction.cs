using System;

namespace libopenconnect;

public class DisposableAction(Action action) : IDisposable {
    public static DisposableAction Noop { get; } = new DisposableAction(() => {
    });

    private Boolean _hasRun;

    public void Dispose() {
        if (!_hasRun) {
            _hasRun = true;
            action();
        }
    }
}