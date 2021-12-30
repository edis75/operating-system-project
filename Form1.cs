using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace isletim
{
    public partial class PCinfo : Form 
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );

        

        public PCinfo()
        {
            InitializeComponent();
        }

        private void resourceButton_Click(object sender, EventArgs e)
        {
            system_resource hello = new system_resource();
            hello.Show();
        }

        private void cpu_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    txtCpu.Text += string.Format("AddressWidth: {0}" + Environment.NewLine, queryObj["AddressWidth"]);

                    txtCpu.Text += string.Format("Name: {0}", queryObj["Name"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        private void hdd_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_LogicalDisk");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Size"] != null)
                    {
                        txtHdd.Text += string.Format("FileSystem: {0} ", queryObj["FileSystem"]);
                        txtHdd.Text += string.Format("FreeSpace: {0}", queryObj["FreeSpace"]);
                        txtHdd.Text += string.Format("Name: {0}", queryObj["Name"]);
                        txtHdd.Text += string.Format("Size: {0}", queryObj["Size"]);
                    }
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }

        }

        private void ram_Click(object sender, EventArgs e)
        {

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    txtRam.Text += string.Format("Capacity: {0}", queryObj["Capacity"]);
                    txtRam.Text += string.Format("Manufacturer: {0}", queryObj["Manufacturer"]);
                    txtRam.Text += string.Format("Speed: {0}", queryObj["Speed"]);
                    txtRam.Text += string.Format("TotalWidth: {0}", queryObj["TotalWidth"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        private void pc_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    txtInfo.Text += string.Format("Model: {0}", queryObj["Model"]);
                    txtInfo.Text += string.Format("Name: {0}", queryObj["Name"]);
                    txtInfo.Text += string.Format("TotalPhysicalMemory: {0}", queryObj["TotalPhysicalMemory"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
                //yorum
            }
        }

        private void txtCpu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // BORDER RADİUS KODLARI 
        }

        private void PCinfo_Load(object sender, EventArgs e)
        {
            cpu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cpu.Width, cpu.Height, 30, 30));
            hdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hdd.Width, hdd.Height, 30, 30));
            ram.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ram.Width, ram.Height, 30, 30));
            pc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pc.Width, pc.Height, 30, 30));
            resourceButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resourceButton.Width, resourceButton.Height, 60, 60));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 60, 60));

            txtCpu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCpu.Width, txtCpu.Height, 30, 30));
            txtHdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtHdd.Width, txtHdd.Height, 30, 30));
            txtRam.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtRam.Width, txtRam.Height, 30, 30));
            txtInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtInfo.Width, txtInfo.Height, 30, 30));




        }
    }
    }

