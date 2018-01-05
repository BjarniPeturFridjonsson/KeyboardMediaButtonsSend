using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MediaButtonsSend
{
    //http://msdn.microsoft.com/en-us/library/dd375731%28v=VS.85%29.aspx
   
    public static class AppCommand
    {
        private static ManualResetEvent _mre = new ManualResetEvent(false);
        private static Form _frm;

        public static void Send(AppCommandValues cmd)
        {
            if (_frm == null) Initialize();
            _frm?.Invoke(new MethodInvoker(() => SendMessage(_frm.Handle, WM_APPCOMMAND, _frm.Handle, (IntPtr)((int)cmd << 16))));
            Cleanup();
        }

        private static void Initialize()
        {
            // to be able to vork in visual studio (and other similar) running as admin we have to emulate a windows form app.
            //the UAC UIPI (User Interface Privilege Isolation) kills our keybd_event when running as admin
            // Run the message loop on another thread so we're compatible with a console mode app
            var t = new Thread(() =>
            {
                _frm = new Form
                {
                    ShowInTaskbar = false,
                    Visible = false,
                };

                var dummy = _frm.Handle;
                _frm.BeginInvoke(new MethodInvoker(() => _mre.Set()));
                Application.Run();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            _mre.WaitOne();
            
        }

        public static void Cleanup()
        {
            if (_frm != null)
            {
                _frm.BeginInvoke(new MethodInvoker(() =>
                {
                    _frm.Close();
                    Application.ExitThread();
                    _mre.Set();
                }));
                _mre.WaitOne();
                _frm = null;
            }
        }

        

        // Pinvoke
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}