using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System;

class clsDispose_safe
{

    bool bDisposed = false;

    SafeHandle objSafeHandle = new SafeFileHandle(IntPtr.Zero, true)

    public void Dispose1()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool bDispose)
    {
        if (bDisposed)
            return;

        if (bDispose)
        {
            objSafeHandle.Dispose();

        }
        bDisposed = true;
    }
}