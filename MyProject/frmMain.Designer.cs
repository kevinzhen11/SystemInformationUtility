namespace MyProject
{
    partial class frmMian
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.tbx_View = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDisk = new System.Windows.Forms.Button();
            this.btnDiskDrive = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnCache = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.btnPrinters = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnProcessor = new System.Windows.Forms.Button();
            this.btnHardDrive = new System.Windows.Forms.Button();
            this.btnGPU = new System.Windows.Forms.Button();
            this.page3 = new System.Windows.Forms.TabPage();
            this.btn_Move = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lbo_Files = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.page1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.page3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page1);
            this.tabControl1.Controls.Add(this.page3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 752);
            this.tabControl1.TabIndex = 2;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.panel2);
            this.page1.Controls.Add(this.panel1);
            this.page1.Location = new System.Drawing.Point(4, 25);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(1041, 723);
            this.page1.TabIndex = 0;
            this.page1.Text = "Hardware Infomation";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtContent);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 540);
            this.panel2.TabIndex = 1;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtContent.Location = new System.Drawing.Point(0, 0);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(893, 540);
            this.rtxtContent.TabIndex = 2;
            this.rtxtContent.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SaveToFile);
            this.panel4.Controls.Add(this.btn_Clear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(893, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 540);
            this.panel4.TabIndex = 1;
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(22, 134);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(105, 41);
            this.btn_SaveToFile.TabIndex = 0;
            this.btn_SaveToFile.Text = "SaveToFile";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(22, 49);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 42);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Controls.Add(this.tbx_View);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 177);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory Path:";
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(915, 122);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(105, 40);
            this.btn_View.TabIndex = 3;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // tbx_View
            // 
            this.tbx_View.Location = new System.Drawing.Point(148, 132);
            this.tbx_View.Name = "tbx_View";
            this.tbx_View.Size = new System.Drawing.Size(745, 25);
            this.tbx_View.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.btnDisk);
            this.groupBox1.Controls.Add(this.btnDiskDrive);
            this.groupBox1.Controls.Add(this.btnDevice);
            this.groupBox1.Controls.Add(this.btnCache);
            this.groupBox1.Controls.Add(this.btnNet);
            this.groupBox1.Controls.Add(this.btnPrinters);
            this.groupBox1.Controls.Add(this.btnOS);
            this.groupBox1.Controls.Add(this.btnProcessor);
            this.groupBox1.Controls.Add(this.btnHardDrive);
            this.groupBox1.Controls.Add(this.btnGPU);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Button Command";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(761, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(132, 33);
            this.button12.TabIndex = 4;
            this.button12.Tag = "VideoSettings";
            this.button12.Text = "Video Settings";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(610, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(132, 33);
            this.button11.TabIndex = 3;
            this.button11.Tag = "IRQResources";
            this.button11.Text = "IRQ Resources";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(449, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 33);
            this.button10.TabIndex = 4;
            this.button10.Tag = "IDEController";
            this.button10.Text = "IDE Controller";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnDisk
            // 
            this.btnDisk.Location = new System.Drawing.Point(307, 68);
            this.btnDisk.Name = "btnDisk";
            this.btnDisk.Size = new System.Drawing.Size(119, 33);
            this.btnDisk.TabIndex = 3;
            this.btnDisk.Tag = "DiskPartition";
            this.btnDisk.Text = "DiskPartition";
            this.btnDisk.UseVisualStyleBackColor = true;
            this.btnDisk.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnDiskDrive
            // 
            this.btnDiskDrive.Location = new System.Drawing.Point(167, 68);
            this.btnDiskDrive.Name = "btnDiskDrive";
            this.btnDiskDrive.Size = new System.Drawing.Size(114, 33);
            this.btnDiskDrive.TabIndex = 4;
            this.btnDiskDrive.Tag = "DiskDrive";
            this.btnDiskDrive.Text = "DiskDrive";
            this.btnDiskDrive.UseVisualStyleBackColor = true;
            this.btnDiskDrive.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.Location = new System.Drawing.Point(18, 68);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(124, 33);
            this.btnDevice.TabIndex = 1;
            this.btnDevice.Tag = "DeviceBus";
            this.btnDevice.Text = "Device Bus";
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnCache
            // 
            this.btnCache.Location = new System.Drawing.Point(904, 23);
            this.btnCache.Name = "btnCache";
            this.btnCache.Size = new System.Drawing.Size(116, 33);
            this.btnCache.TabIndex = 2;
            this.btnCache.Tag = "CacheMemory";
            this.btnCache.Text = "Cache Memory";
            this.btnCache.UseVisualStyleBackColor = true;
            this.btnCache.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnNet
            // 
            this.btnNet.Location = new System.Drawing.Point(761, 23);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(132, 33);
            this.btnNet.TabIndex = 1;
            this.btnNet.Tag = "NetworkAdapters";
            this.btnNet.Text = "Network Adapters";
            this.btnNet.UseVisualStyleBackColor = true;
            this.btnNet.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnPrinters
            // 
            this.btnPrinters.Location = new System.Drawing.Point(610, 23);
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(132, 33);
            this.btnPrinters.TabIndex = 2;
            this.btnPrinters.Tag = "Printers";
            this.btnPrinters.Text = "Printers";
            this.btnPrinters.UseVisualStyleBackColor = true;
            this.btnPrinters.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnOS
            // 
            this.btnOS.Location = new System.Drawing.Point(449, 23);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(132, 33);
            this.btnOS.TabIndex = 1;
            this.btnOS.Tag = "OS";
            this.btnOS.Text = "OS";
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnProcessor
            // 
            this.btnProcessor.Location = new System.Drawing.Point(307, 23);
            this.btnProcessor.Name = "btnProcessor";
            this.btnProcessor.Size = new System.Drawing.Size(119, 33);
            this.btnProcessor.TabIndex = 2;
            this.btnProcessor.Tag = "Processor";
            this.btnProcessor.Text = "Processor";
            this.btnProcessor.UseVisualStyleBackColor = true;
            this.btnProcessor.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnHardDrive
            // 
            this.btnHardDrive.Location = new System.Drawing.Point(167, 23);
            this.btnHardDrive.Name = "btnHardDrive";
            this.btnHardDrive.Size = new System.Drawing.Size(114, 33);
            this.btnHardDrive.TabIndex = 1;
            this.btnHardDrive.Tag = "HardDrive";
            this.btnHardDrive.Text = "HardDrive";
            this.btnHardDrive.UseVisualStyleBackColor = true;
            this.btnHardDrive.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // btnGPU
            // 
            this.btnGPU.Location = new System.Drawing.Point(18, 23);
            this.btnGPU.Name = "btnGPU";
            this.btnGPU.Size = new System.Drawing.Size(122, 33);
            this.btnGPU.TabIndex = 2;
            this.btnGPU.Tag = "GPU";
            this.btnGPU.Text = "GPU";
            this.btnGPU.UseVisualStyleBackColor = true;
            this.btnGPU.Click += new System.EventHandler(this.Particulars_Click);
            // 
            // page3
            // 
            this.page3.Controls.Add(this.button1);
            this.page3.Controls.Add(this.txtPath2);
            this.page3.Controls.Add(this.label2);
            this.page3.Controls.Add(this.btn_Move);
            this.page3.Controls.Add(this.btn_Copy);
            this.page3.Controls.Add(this.btn_Delete);
            this.page3.Controls.Add(this.btn_Select);
            this.page3.Controls.Add(this.lbo_Files);
            this.page3.Location = new System.Drawing.Point(4, 25);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(1041, 723);
            this.page3.TabIndex = 2;
            this.page3.Text = "File Operator";
            this.page3.UseVisualStyleBackColor = true;
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(459, 437);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(97, 42);
            this.btn_Move.TabIndex = 4;
            this.btn_Move.Text = "Move";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(459, 353);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(97, 44);
            this.btn_Copy.TabIndex = 3;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(459, 275);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(97, 43);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(577, 36);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(90, 35);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Browse";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbo_Files
            // 
            this.lbo_Files.FormattingEnabled = true;
            this.lbo_Files.ItemHeight = 15;
            this.lbo_Files.Location = new System.Drawing.Point(28, 107);
            this.lbo_Files.Name = "lbo_Files";
            this.lbo_Files.Size = new System.Drawing.Size(398, 589);
            this.lbo_Files.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory path:";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(158, 46);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(268, 25);
            this.txtPath2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMian";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.page3.ResumeLayout(false);
            this.page3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.TextBox tbx_View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDisk;
        private System.Windows.Forms.Button btnDiskDrive;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnCache;
        private System.Windows.Forms.Button btnNet;
        private System.Windows.Forms.Button btnPrinters;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnProcessor;
        private System.Windows.Forms.Button btnHardDrive;
        private System.Windows.Forms.Button btnGPU;
        private System.Windows.Forms.TabPage page3;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ListBox lbo_Files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

