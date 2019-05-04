using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Drawing.Printing;
using System.Net.NetworkInformation;

namespace MyProject
{
    public partial class frmMian : Form
    {
        public frmMian()
        {
            InitializeComponent();
        }

        public static string FBDialogFolderPath;  //Select target path

        private void Particulars_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString())
            {
                case "GPU":
                    string strGPU = string.Empty;
                    ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_VideoController");
                    foreach (ManagementObject mo in mos.Get())
                    {
                        strGPU += mo["Name"].ToString() + "   ";
                    }
                    rtxtContent.AppendText("GPU:" + strGPU + Environment.NewLine);
                    break;
                case "HardDrive":
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    StringBuilder sr = new StringBuilder();
                    foreach (DriveInfo drive in drives)
                    {
                        if (drive.IsReady)
                        {
                            var val1 = (double)drive.TotalSize / 1024 / 1024;
                            var val2 = (double)drive.TotalFreeSpace / 1024 / 1024;
                            sr.AppendFormat("Name:{0}\t Format:{2}\tTotal:{3}MB\tLeft:{4}MB\tUsable Percent:{1}%\r\n",
                                drive.Name,
                                string.Format("{0:F2}", val2 / val1 * 100),
                                drive.DriveFormat,
                                (long)val1,
                                (long)val2);
                        }
                    }
                    rtxtContent.AppendText("HardDrive:\r\n" + sr.ToString() + Environment.NewLine);
                    break;

                case "Processor":
                    string strProcessor = "";
                    ManagementObjectSearcher driveID = new ManagementObjectSearcher("Select * from Win32_Processor");
                    foreach (ManagementObject mo in driveID.Get())
                    {
                        strProcessor = mo["Name"].ToString();
                    }
                    rtxtContent.AppendText("Processor:" + strProcessor + Environment.NewLine);
                    break;

                case "OS":
                    rtxtContent.AppendText("OS:" + Environment.OSVersion + Environment.NewLine);
                    break;

                case "Printers":
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        rtxtContent.AppendText("Printers:" + PrinterSettings.InstalledPrinters[i] + "   " + Environment.NewLine);
                    }
                    rtxtContent.AppendText(Environment.NewLine);
                    break;

                case "NetworkAdapters":
                    NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                    StringBuilder sb = new StringBuilder();
                    foreach (NetworkInterface adapter in adapters)
                    {
                        sb.AppendFormat("Description:{0}\r\nId:{1}\r\nName:{2}\r\nNetworkInterfaceType:{3}\r\nSpeed:{4}\r\nOperationalStatus:{5}\r\nPhysicalAddress:{6}\r\n",
                            adapter.Description,
                            adapter.Id,
                            adapter.Name,
                            adapter.NetworkInterfaceType,
                            adapter.Speed * 0.001 * 0.001 + "M",
                            adapter.OperationalStatus,
                            adapter.GetPhysicalAddress()
                            );
                        sb.AppendFormat("\r\n");
                    }
                    rtxtContent.AppendText("NetworkAdapters:" + Environment.NewLine + sb.ToString());
                    break;

                case "CacheMemory":
                    string strCacheMemory = "";
                    ManagementObjectSearcher cacheMemory = new ManagementObjectSearcher("Select * from Win32_Processor");
                    var test = cacheMemory.Get();
                    foreach (ManagementObject mo in cacheMemory.Get())
                    {
                        strCacheMemory = "L2CacheSize:" + mo["L2CacheSize"].ToString() + "KB\tL3CacheSize:" + mo["L3CacheSize"].ToString() + "KB";
                    }
                    rtxtContent.AppendText("CacheMemory:" + strCacheMemory + Environment.NewLine);
                    break;
                case "DeviceBus":
                    string strDeviceBus = "";
                    ManagementObjectSearcher deviceBus = new ManagementObjectSearcher("Select * from Win32_Bus");
                    foreach (ManagementObject mo in deviceBus.Get())
                    {
                        strDeviceBus += mo["DeviceID"].ToString() + "\r\n";
                    }
                    rtxtContent.AppendText("DeviceBus:\r\n" + strDeviceBus + Environment.NewLine);
                    break;

                case "DiskDrive":
                    string strDiskDrive = "";
                    ManagementObjectSearcher diskDrive = new ManagementObjectSearcher("Select * from Win32_DiskDrive");

                    foreach (ManagementObject mo in diskDrive.Get())
                    {
                        strDiskDrive += mo["Name"].ToString() + "   ";
                    }
                    rtxtContent.AppendText("DiskDrive:" + strDiskDrive + Environment.NewLine);
                    break;

                case "DiskPartition":
                    DriveInfo[] diskPartition = DriveInfo.GetDrives();
                    StringBuilder sbDiskPartition = new StringBuilder();
                    foreach (DriveInfo di in diskPartition)
                    {
                        sbDiskPartition.Append(di + "   ");
                    }
                    rtxtContent.AppendText("DiskPartition:" + sbDiskPartition.ToString().Trim() + Environment.NewLine);
                    break;

                case "IDEController":
                    string strIDEController = "";
                    ManagementObjectSearcher ideController = new ManagementObjectSearcher("Select * from Win32_IDEController");
                    var h = ideController.Get();
                    foreach (ManagementObject mo in ideController.Get())
                    {
                        strIDEController += mo["Name"].ToString() + "   ";
                    }
                    rtxtContent.AppendText("IDEController:" + strIDEController + Environment.NewLine);
                    break;
                case "IRQResources":
                    string strIRQResources = "";
                    ManagementObjectSearcher irqResources = new ManagementObjectSearcher("Select * from Win32_IRQResource");

                    foreach (ManagementObject mo in irqResources.Get())
                    {
                        strIRQResources += mo["Name"].ToString() + "   ";
                    }
                    rtxtContent.AppendText("IRQResources:" + strIRQResources + Environment.NewLine);
                    break;

                case "VideoSettings":
                    string strVideoSettings = "";
                    ManagementObjectSearcher videoSettings = new ManagementObjectSearcher("Select * from Win32_VideoController");
                    var h2 = videoSettings.Get();
                    foreach (ManagementObject mo in videoSettings.Get())
                    {
                        strVideoSettings += mo["Name"].ToString() + "   ";
                    }
                    rtxtContent.AppendText("VideoSettings:" + strVideoSettings + Environment.NewLine);
                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            rtxtContent.Clear();
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sdDialog = new SaveFileDialog() { DefaultExt = "txt", Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*", FilterIndex = 1 };
                if (sdDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (FileStream fs = File.Open(sdDialog.FileName, FileMode.Create))
                    {
                        byte[] bs = Encoding.Default.GetBytes(rtxtContent.Text);
                        fs.Write(bs, 0, bs.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Save Files Exception:", ex.Message), "Error");
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_View.Text.Trim()))
            {
                MessageBox.Show(string.Format("Please enter a valid path."), "Warning");
                return;
            }

            if (!Directory.Exists(tbx_View.Text.Trim()))
            {
                MessageBox.Show(string.Format("Folder does not exist."), "Warning");
                return;
            }

            list.Clear();
            var result = getPath(tbx_View.Text.Trim());
            foreach (var item in result)
            {
                rtxtContent.AppendText(item + Environment.NewLine);
            }
        }

        static List<string> list = new List<string>();
        public static List<string> getPath(string path)
        {

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                list.Add(string.Format("Name:{0} CreationTime:{1} Length:{2}Bytes", f.Name, f.CreationTime, f.Length));
            }
            foreach (DirectoryInfo d in dii)
            {
                getPath(d.FullName);
            }
            return list;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                lbo_Files.Items.Clear();
                FolderBrowserDialog fbDialog = new FolderBrowserDialog();
                if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FBDialogFolderPath = fbDialog.SelectedPath;

                    DirectoryInfo TheFolder = new DirectoryInfo(FBDialogFolderPath);
                    foreach (FileInfo NextFile in TheFolder.GetFiles())
                    {
                        lbo_Files.Items.Add(NextFile);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lbo_Files.Items.Count == 0)
            {
                MessageBox.Show(string.Format("Please select the folder first."), "Warning");
                return;
            }
            if (lbo_Files.SelectedItem == null)
            {
                MessageBox.Show(string.Format("Please select the item first."), "Warning");
                return;
            }

            try
            {
                DirectoryInfo TheFolder = new DirectoryInfo(FBDialogFolderPath);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    if (lbo_Files.SelectedItem.ToString().Equals(NextFile.Name))
                    {
                        File.Delete(NextFile.FullName);
                        lbo_Files.Items.Remove(lbo_Files.SelectedItem);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (lbo_Files.Items.Count == 0)
            {
                MessageBox.Show(string.Format("Please select the folder first."), "Warning");
                return;
            }
            if (lbo_Files.SelectedItem == null)
            {
                MessageBox.Show(string.Format("Please select the item first."), "Warning");
                return;
            }

            try
            {
                FolderBrowserDialog fbDialog = new FolderBrowserDialog();
                if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DirectoryInfo TheFolder = new DirectoryInfo(FBDialogFolderPath);
                    foreach (FileInfo NextFile in TheFolder.GetFiles())
                    {
                        if (lbo_Files.SelectedItem.ToString().Equals(NextFile.Name) && (FBDialogFolderPath != fbDialog.SelectedPath))
                        {
                            File.Copy(NextFile.FullName, Path.Combine(fbDialog.SelectedPath, NextFile.Name));
                        }

                        if (lbo_Files.SelectedItem.ToString().Equals(NextFile.Name) && (FBDialogFolderPath == fbDialog.SelectedPath))
                        {
                            string str = Path.GetFileNameWithoutExtension(NextFile.FullName) + DateTime.Now.ToString("yyyyMMdd HHmmss") + Path.GetExtension(NextFile.FullName);
                            File.Copy(NextFile.FullName, FBDialogFolderPath + @"\" + str);
                            lbo_Files.Items.Add(str);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            if (lbo_Files.Items.Count == 0)
            {
                MessageBox.Show(string.Format("Please select the folder first."), "Warning");
                return;
            }
            if (lbo_Files.SelectedItem == null)
            {
                MessageBox.Show(string.Format("Please select the item first."), "Warning");
                return;
            }

            try
            {
                FolderBrowserDialog fbDialog = new FolderBrowserDialog();
                if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DirectoryInfo TheFolder = new DirectoryInfo(FBDialogFolderPath);
                    foreach (FileInfo NextFile in TheFolder.GetFiles())
                    {
                        if (lbo_Files.SelectedItem.ToString().Equals(NextFile.Name) && (FBDialogFolderPath != fbDialog.SelectedPath))
                        {
                            File.Move(NextFile.FullName, Path.Combine(fbDialog.SelectedPath, NextFile.Name));
                            lbo_Files.Items.Remove(lbo_Files.SelectedItem);
                            break;
                        }

                        if (lbo_Files.SelectedItem.ToString().Equals(NextFile.Name) && (FBDialogFolderPath == fbDialog.SelectedPath))
                        {
                            MessageBox.Show(string.Format("Already in the current directory."), "Warning");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            rtxtContent.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPath2.Text.Trim()))
            {
                MessageBox.Show(string.Format("Please enter a valid path."), "Warning");
                return;
            }

            if (!Directory.Exists(txtPath2.Text.Trim()))
            {
                MessageBox.Show(string.Format("Folder does not exist."), "Warning");
                return;
            }

            lbo_Files.Items.Clear();

            FBDialogFolderPath = txtPath2.Text.Trim();

                DirectoryInfo TheFolder = new DirectoryInfo(FBDialogFolderPath);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    lbo_Files.Items.Add(NextFile);
                }
        }
    }
}
