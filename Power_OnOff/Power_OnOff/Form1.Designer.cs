namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGetTime = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOFFcounter = new System.Windows.Forms.Label();
            this.lblRUNcounter = new System.Windows.Forms.Label();
            this.cmdClean = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtOff_time = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRun_time = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmbportname = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.GetTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UItmr = new System.Windows.Forms.Timer(this.components);
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGetTime
            // 
            this.lblGetTime.AutoSize = true;
            this.lblGetTime.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGetTime.Location = new System.Drawing.Point(295, 28);
            this.lblGetTime.Name = "lblGetTime";
            this.lblGetTime.Size = new System.Drawing.Size(45, 12);
            this.lblGetTime.TabIndex = 7;
            this.lblGetTime.Text = "GetTime";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lblOFFcounter);
            this.GroupBox3.Controls.Add(this.lblRUNcounter);
            this.GroupBox3.Controls.Add(this.cmdClean);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Location = new System.Drawing.Point(12, 188);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(388, 70);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Counter";
            // 
            // lblOFFcounter
            // 
            this.lblOFFcounter.AutoSize = true;
            this.lblOFFcounter.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOFFcounter.Location = new System.Drawing.Point(117, 47);
            this.lblOFFcounter.Name = "lblOFFcounter";
            this.lblOFFcounter.Size = new System.Drawing.Size(11, 12);
            this.lblOFFcounter.TabIndex = 10;
            this.lblOFFcounter.Text = "0";
            // 
            // lblRUNcounter
            // 
            this.lblRUNcounter.AutoSize = true;
            this.lblRUNcounter.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRUNcounter.Location = new System.Drawing.Point(117, 21);
            this.lblRUNcounter.Name = "lblRUNcounter";
            this.lblRUNcounter.Size = new System.Drawing.Size(11, 12);
            this.lblRUNcounter.TabIndex = 9;
            this.lblRUNcounter.Text = "0";
            // 
            // cmdClean
            // 
            this.cmdClean.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClean.Location = new System.Drawing.Point(305, 21);
            this.cmdClean.Name = "cmdClean";
            this.cmdClean.Size = new System.Drawing.Size(75, 25);
            this.cmdClean.TabIndex = 8;
            this.cmdClean.Text = "Clean";
            this.cmdClean.UseVisualStyleBackColor = true;
            this.cmdClean.Click += new System.EventHandler(this.cmdClean_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label8.Location = new System.Drawing.Point(11, 47);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 12);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Power Off Counter :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label7.Location = new System.Drawing.Point(11, 21);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(98, 12);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Power On Counter :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.txtOff_time);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.cmdStop);
            this.GroupBox2.Controls.Add(this.cmdStart);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtRun_time);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(12, 99);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(388, 83);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Run/Off Interval";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(148, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(132, 12);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "second, and then Power On";
            // 
            // txtOff_time
            // 
            this.txtOff_time.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOff_time.Location = new System.Drawing.Point(75, 21);
            this.txtOff_time.MaxLength = 10;
            this.txtOff_time.Name = "txtOff_time";
            this.txtOff_time.Size = new System.Drawing.Size(67, 22);
            this.txtOff_time.TabIndex = 11;
            this.txtOff_time.Text = "1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label3.Location = new System.Drawing.Point(15, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 12);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Off Time :";
            // 
            // cmdStop
            // 
            this.cmdStop.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStop.Location = new System.Drawing.Point(305, 49);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 25);
            this.cmdStop.TabIndex = 7;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(305, 18);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 25);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(146, 55);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(134, 12);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "second, and then Power Off";
            // 
            // txtRun_time
            // 
            this.txtRun_time.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRun_time.Location = new System.Drawing.Point(75, 52);
            this.txtRun_time.MaxLength = 10;
            this.txtRun_time.Name = "txtRun_time";
            this.txtRun_time.Size = new System.Drawing.Size(67, 22);
            this.txtRun_time.TabIndex = 2;
            this.txtRun_time.Text = "1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(11, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 12);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Run Time :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmdConnect);
            this.GroupBox1.Controls.Add(this.cmbportname);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(388, 50);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "PC Com Port";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConnect.Location = new System.Drawing.Point(273, 15);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(107, 25);
            this.cmdConnect.TabIndex = 1;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmbportname
            // 
            this.cmbportname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbportname.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbportname.FormattingEnabled = true;
            this.cmbportname.Location = new System.Drawing.Point(88, 18);
            this.cmbportname.Name = "cmbportname";
            this.cmbportname.Size = new System.Drawing.Size(116, 20);
            this.cmbportname.TabIndex = 1;
            this.cmbportname.SelectedIndexChanged += new System.EventHandler(this.cmbportname_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(11, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 12);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Port Number :";
            // 
            // GetTimer
            // 
            this.GetTimer.Tick += new System.EventHandler(this.GetTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UItmr
            // 
            this.UItmr.Enabled = true;
            this.UItmr.Tick += new System.EventHandler(this.UItmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 278);
            this.Controls.Add(this.lblGetTime);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Power On/Off Control_v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblGetTime;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblOFFcounter;
        internal System.Windows.Forms.Label lblRUNcounter;
        internal System.Windows.Forms.Button cmdClean;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button cmdStop;
        internal System.Windows.Forms.Button cmdStart;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtRun_time;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer GetTimer;
        public System.Windows.Forms.ComboBox cmbportname;
        internal System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtOff_time;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Timer UItmr;

    }
}

