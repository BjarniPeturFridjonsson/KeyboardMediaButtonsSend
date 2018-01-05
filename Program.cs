using System;

namespace MediaButtonsSend
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args== null || args.Length == 0 )
                {
                    ShowHelp();
                    return;
                }

                var success = Enum.TryParse(args[0],true, out AppCommandValues action);
                if (success)
                {
                    TrackKeys(action);
                    return;
                }
                ShowHelp();
               
            }
            catch
            {
                ShowHelp();
            }
        }

        private static void ShowHelp()
        {
            var hlp = new FrmHelp();
            hlp.ShowDialog();
        }

        private static void TrackKeys(AppCommandValues cmd)
        {
            //this does not work when running as admin
            //byte msg = trackMove == TrackMove.Previous ? (byte)0xB1 : (byte)0xB0;
            //keybd_event(msg, 0x45, 0, IntPtr.Zero);
            AppCommand.Send(cmd);
        }
    }
}