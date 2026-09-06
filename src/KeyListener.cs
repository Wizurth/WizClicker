using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WizClicker
{

//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

public class KeyListener
{
    public KeyListener()
    {
        OnKeyDownEvent += OnKeyDown;
    }

//#############################################################################
//##--------------------------------- FIELDS --------------------------------##
//#############################################################################

//==== Delegates ====\\.
    public delegate void OnListeningStoppedType(bool bIsKeyListened, Keys KeyListened);
    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
    private delegate void OnKeyDownType(Keys Key);

//==== Events ====\\.
    public event OnListeningStoppedType OnListeningStoppedEvent;
    private static event OnKeyDownType OnKeyDownEvent;

//==== Properties ====\\.
    private bool bIsListeningKey { get; set; } = false;
    private static readonly LowLevelKeyboardProc Proc = HookCallback;
    List<IntPtr> HookHandles = new List<IntPtr>();

    private const int WH_KEYBOARD_LL = 13;
    private const int WH_MOUSE_LL = 14;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;

    private const int WM_LBUTTONDOWN = 0x0201;
    private const int WM_LBUTTONUP = 0x0202;

    private const int WM_RBUTTONDOWN = 0x0204;
    private const int WM_RBUTTONUP = 0x0205;

    private const int WM_MBUTTONDOWN = 0x0207;
    private const int WM_MBUTTONUP = 0x0208;

    private const int WM_XBUTTONDOWN = 0x020B;
    private const int WM_XBUTTONUP = 0x020C;

//#############################################################################
//##-------------------------------- METHODS --------------------------------##
//#############################################################################

//==== Imported ====\\.
    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hHook);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    private struct KBDLLHOOKSTRUCT
    {
        public uint vkCode;
        public uint scanCode;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public uint mouseData;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

//==== Methods ====\\.
    public static void SetHooks(out IntPtr KB_Handle, out IntPtr Mouse_Handle)
    {
        using Process process = Process.GetCurrentProcess();
        using ProcessModule module = process.MainModule;

        KB_Handle = SetWindowsHookEx(WH_KEYBOARD_LL, Proc, GetModuleHandle(module?.ModuleName), 0);
        Mouse_Handle = SetWindowsHookEx(WH_MOUSE_LL, Proc, GetModuleHandle(module?.ModuleName), 0);
    }

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        // Keyboard Key
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
        {
            KBDLLHOOKSTRUCT info = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
            Keys key = (Keys)info.vkCode;

            OnKeyDownEvent?.Invoke(key);
        }

        // Mouse Key
        if (nCode >= 0)
        {
            Keys Key = wParam.ToInt32() switch
            {
                WM_LBUTTONUP => Keys.LButton,
                WM_RBUTTONUP => Keys.RButton,
                WM_MBUTTONUP => Keys.MButton,

                WM_XBUTTONUP => (Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam).mouseData >> 16) switch
                {
                    1 => Keys.XButton1,
                    2 => Keys.XButton2,
                    _ => Keys.None
                },

                _ => Keys.None
            };

            if (Key != Keys.None)
            {
                OnKeyDownEvent?.Invoke(Key);
            }
        }

        return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
    }

    public void StartListenKey()
    {
        if (HookHandles.Count == 0)
        {
            SetHooks(out IntPtr KB_Handle, out IntPtr Mouse_Handle);

            HookHandles.Add(KB_Handle);
            HookHandles.Add(Mouse_Handle);
        }

        bIsListeningKey = true;
    }

    public void StopListenKey()
    {
        Internal_StopListenKey();
        OnListeningStoppedEvent?.Invoke(false, 0);
    }

    private void OnKeyDown(Keys Key)
    {
        Internal_StopListenKey();
        OnListeningStoppedEvent?.Invoke(true, Key);
    }

    #region Internals
    private void Internal_StopListenKey()
    {
        if (HookHandles.Count != 0)
        {
            UnhookWindowsHookEx(HookHandles[0]);
            UnhookWindowsHookEx(HookHandles[1]);
        }
        
        HookHandles.Clear();

        bIsListeningKey = false;
    }
    #endregion // Internals
}
}