using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Peche
{
    public partial class Form1 : Form
    {
        [DllImport("ImageSearchDLL.dll")]
        private static extern IntPtr ImageSearch(int x, int y, int right, int bottom, [MarshalAs(UnmanagedType.LPStr)] string imagePath);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);


        string image_path = Path.Combine(Directory.GetCurrentDirectory(), "image", "interact.png");
        static int[] search_region = { 800, 720, 1000, 760 };

        const byte VK_E = 0x45;
        const byte VK_F = 0x46;
        const uint KEYUP = 0x0002;

        static byte peche_hotkey = VK_E;
        static byte interact_key = VK_F;

        bool searchImage(int[] region)
        {
            IntPtr result = ImageSearch(region[0], region[1], region[2], region[3], "*Trans0 " + image_path);
            var res = Marshal.PtrToStringAnsi(result);
            if (res != null && res[0] != '0')
            {
                return true;
            }
            return false;
        }

        void peche()
        {
            while (true)
            {
                if (searchImage(search_region))
                {
                    Console.Beep(440, 100);
                    keybd_event(interact_key, 0, 0, 0);
                    Thread.Sleep(1000);
                    keybd_event(interact_key, 0, KEYUP, 0);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread FISH = new Thread(peche) { IsBackground = true };
            FISH.Start();
        }
    }
}


