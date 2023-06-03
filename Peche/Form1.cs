using System;
using System.Collections.Generic;
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
        static extern short GetKeyState(Keys vKeys);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        const uint KEYUP = 0x0002;
        static string dir = Path.GetDirectoryName(Application.ExecutablePath);

        static int[] search_region = { 800, 720, 1000, 760 };

        static string intkey;
        static Dictionary<string, byte> intkeys = new Dictionary<string, byte>(){
            {"E", 0x45},
            {"F", 0x46}
        };

        static Keys hotkey = Keys.F2;
        static bool is_fishing = false;
        static bool beep = true;
         

        bool searchImage(int[] region)
        {
            string image_path = Path.Combine(dir, "image", intkey + ".png");
            IntPtr result = ImageSearch(region[0], region[1], region[2], region[3], image_path);
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
                if (is_fishing)
                {
                    if (searchImage(search_region))
                    {
                        if (beep)
                        {
                            Console.Beep(440, 100);
                        } 
                        byte key = intkeys[intkey];
                        keybd_event(key, 0, 0, 0);
                        Thread.Sleep(1000);
                        keybd_event(key, 0, KEYUP, 0);
                    }
                }
                if (GetKeyState(hotkey) < 0)
                {
                    hotkey_checkBox.Invoke((MethodInvoker)delegate {
                        hotkey_checkBox.Checked = !hotkey_checkBox.Checked;
                    });
                    Thread.Sleep(500);
                }
            }
        }

        void intkey_comboBox_init()
        {
            foreach (var intkey in intkeys)
            {
                intkey_comboBox.Items.Add(intkey.Key);
            }
            intkey_comboBox.SelectedIndex = 0;
            intkey = intkey_comboBox.SelectedItem.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intkey_comboBox_init();
            Thread FISH = new Thread(peche) { IsBackground = true };
            FISH.Start();
        }

        private void intkey_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intkey = intkey_comboBox.SelectedItem.ToString();
        }

        private void hotkey_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotkey_checkBox.Checked)
            {
                is_fishing = true;
                fishStatus.Text = "Fishing in Progress";
                fishStatus.ForeColor = System.Drawing.Color.Aqua;
                if (beep)
                {
                    Console.Beep(261, 70);
                    Console.Beep(329, 70);
                    Console.Beep(392, 70);
                }
                
            } else
            {
                is_fishing = false;
                fishStatus.Text = "Pas de Peche :(";
                fishStatus.ForeColor = System.Drawing.Color.Red;
                if (beep)
                {
                    Console.Beep(392, 70);
                    Console.Beep(329, 70);
                    Console.Beep(261, 70);
                }
            }
        }

        private void beep_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (beep_checkBox.Checked)
            {
                beep = true;
            }
            else
            {
                beep = false;
            }
        }
    }
}


