using HidLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExternalProjectorsSwitch
{

    public class SSRSwitch
    {
        public static bool On = true;
        public static bool Off = false;

        readonly HidDevice device;
        readonly byte deviceId = 1;

        public SSRSwitch()
        {
            short vid = 0x5131, pid = 0x2007;

            HidDevice device = HidDevices.Enumerate(vid, pid).FirstOrDefault() ?? throw new Exception($"Could not find an HID device with vid=0x{vid:X}, pid=0x{pid:X}");

            this.device = device;
            this.device.OpenDevice();
            Console.WriteLine($"\nDevice: VID={device.Attributes.VendorId:X4}, PID={device.Attributes.ProductId:X4}, Description={device.Description}, Path={device.DevicePath}");
        }

        public void Turn(bool onoff)
        {
            byte[] buf = new byte[65];

            buf[0] = 0;
            buf[1] = 0xa0;
            buf[2] = this.deviceId;
            buf[3] = Convert.ToByte( onoff );
            buf[4] = Convert.ToByte(buf[0] + buf[1] + buf[2] + buf[3]);

            bool success = this.device.Write(buf);
            if (! success)
                Console.WriteLine("failed to write");
        }

        public static void OnReport(HidReport report)
        {
            // Used with device.ReadReport(OnReport);
            Console.WriteLine(" IN: " + BitConverter.ToString(report.Data));
        }


        ~SSRSwitch()
        {
            this.device.CloseDevice();
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SSRSwitch ssr = new SSRSwitch();

            ssr.Turn(SSRSwitch.Off);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SwitchForm(ssr));
        }
    }
}
