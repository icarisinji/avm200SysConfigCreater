using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace createSysConf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboModel.SelectedIndex = 0;
            comboLanguage.SelectedIndex = 0;
            comboPGLD.SelectedIndex = 0;
            comboQuickView.SelectedIndex = 0;
            comboCVBS.SelectedIndex = 0;
            comboDefView.SelectedIndex = 0;
        }
        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
        public unsafe struct SystemConfig
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
            [FieldOffset(0)]
            public fixed byte data[56];



            [FieldOffset(0)]
            public UInt32 magic;

            [FieldOffset(4)]
            public UInt32 version;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            [FieldOffset(8)]
            public fixed byte nameArray[32];
            /*
            [FieldOffset(8)]
            public Byte model_name;
            */
            [FieldOffset(40)]
            public UInt32 dummy;

            [FieldOffset(44)]
            public UInt32 bitMask;

            [FieldOffset(48)]
            public Byte language;
            [FieldOffset(49)]
            public Byte screen_off_time;
            [FieldOffset(50)]
            public Byte cvbs_output;
            [FieldOffset(51)]
            public Byte default_view_mode;
            [FieldOffset(52)]
            public Byte lut_mode;
            [FieldOffset(53)]
            public Byte dummy1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void readSysConfig(string _filename)
        {
            var sysconfig = new SystemConfig();
            var sysbuf = new byte[56];
            string ModelName;

            using (BinaryReader reader = new BinaryReader(File.Open(_filename, FileMode.Open)))
            {
                reader.Read(sysbuf, 0, 56);

                unsafe
                {
                    Marshal.Copy(sysbuf, 0, new IntPtr(sysconfig.data), 56);

                    byte* fixedPtr = sysconfig.nameArray;
                    ModelName = new string((sbyte*)fixedPtr);
                }
                
                comboModel.SelectedIndex = comboModel.Items.IndexOf(ModelName);
                comboLanguage.SelectedIndex = sysconfig.language;
                comboPGLD.SelectedIndex = (int)(sysconfig.bitMask&0x02);
                comboQuickView.SelectedIndex = sysconfig.screen_off_time;
                comboCVBS.SelectedIndex = sysconfig.cvbs_output;
                comboDefView.SelectedIndex = sysconfig.default_view_mode;
                var version = (sysconfig.version >> 24) & 0xff;
                textModel.Text = version.ToString();
                version = (sysconfig.version >> 16) & 0xff;
                textMajor.Text = version.ToString();
                version = (sysconfig.version >> 8) & 0xff;
                textMinor.Text = version.ToString();
                version = sysconfig.version & 0xff;
                textPatch.Text = version.ToString();
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "bin|*.bin";
            openFileDialog1.Title = "Select a ConfigData.bin";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                readSysConfig(openFileDialog1.FileName);
            }
        }
        private void saveSysConfig(string _filename)
        {
            var sysconfig = new SystemConfig();
            var sysbuf = new byte[56];
            byte[] ModelName  = new byte[32];
            //byte[] versionArray = new byte[128];

            using (BinaryWriter writer = new BinaryWriter(File.Open(_filename, FileMode.Create)))
            {
                ModelName = Encoding.ASCII.GetBytes((string)comboModel.SelectedItem);

                sysconfig.language = (Byte)comboLanguage.SelectedIndex;
                sysconfig.bitMask = (uint)((comboPGLD.SelectedIndex == 0) ? 0 : 0x02);
                sysconfig.screen_off_time = (Byte)comboQuickView.SelectedIndex;
                sysconfig.cvbs_output = (Byte)comboCVBS.SelectedIndex;
                sysconfig.default_view_mode = (Byte)comboDefView.SelectedIndex;
                sysconfig.version = (uint.Parse(textModel.Text) << 24);
                sysconfig.version |= (uint.Parse(textMajor.Text) << 16);
                sysconfig.version |= (uint.Parse(textMinor.Text) << 8);
                sysconfig.version |= uint.Parse(textPatch.Text) ;
                sysconfig.magic = 0x46802694;
                //uint version = (uint)Encoding.ASCII.GetBytes(textModel.Text, 0, Encoding.ASCII.GetByteCount(textModel.Text), versionArray, 0);

                unsafe
                {
                    //byte* fixedPtr = sysconfig.nameArray;
                    //ModelName = new string((sbyte*)fixedPtr);
                    Marshal.Copy(ModelName, 0, new IntPtr(sysconfig.nameArray), Encoding.ASCII.GetByteCount((string)comboModel.SelectedItem));
                    Marshal.Copy(new IntPtr(sysconfig.data), sysbuf, 0, 56);
                }
                writer.Write(sysbuf, 0, 56);
                MessageBox.Show("Save OK");
            }
        }

        private void textModel_KeyPress(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "bin|*.bin";
            saveFileDialog1.Title = "Save an System Config File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                saveSysConfig(saveFileDialog1.FileName);
            }
        }

        private void textModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void textMajor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void textMinor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void textPatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
