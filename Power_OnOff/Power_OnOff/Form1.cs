using System;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string appPATH = Application.StartupPath;    //C#取得主程式路徑(Application Path)
        DateTime ProgramStartTime = DateTime.Now;

        Thread workThread;

        // API: timeGetTime
        [DllImport("winmm")]
        private static extern uint timeGetTime();

        double Savetime = 0;
        double offtimeInterval, runtimeInterval;
        long offCounter, runCounter;
        bool RUNNING;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //獲取計算機有效串口
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    cmbportname.Items.Add(port);
                }
                cmbportname.Sorted = true; ; //排序
                cmbportname.SelectedIndex = 0;

                GetTimer.Start();
                RUNNING = false;
            }
            catch (Exception ex)
            {
                //例外處理
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "確定退出 ？", "退出視窗通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Cancel 取得或設定數值，表示是否應該取消事件。
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

        private void GetTimer_Tick(object sender, EventArgs e)
        {
            lblGetTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + " " + string.Format(DateTime.Now.ToString("HH:mm:ss"));
            //lblGetTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + " " + string.Format(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                cmdConnect.Text = "Disconnect";
            }
            catch (Exception)
            {
                serialPort1.Close();
                cmdConnect.Text = "Connect";
                //MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbportname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbportname.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                serialPort1.Close();
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    runtimeInterval = double.Parse(txtRun_time.Text) * 1000;
                    offtimeInterval = double.Parse(txtOff_time.Text) * 1000;
                    RUNNING = true;
                    if (workThread == null || !workThread.IsAlive)
                    {
                        ThreadStart backgroundThread = new ThreadStart(backgroundWork);
                        workThread = new Thread(backgroundThread);
                        workThread.IsBackground = true;
                        workThread.Start();
                        log_addtime(appPATH, "Start!" + " " + "Set run time:" + txtRun_time.Text + "s" + " and off time:" + txtOff_time.Text + "s");
                    }
                }
                else
                {
                    MessageBox.Show("Com port is disconnected !", "Com port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Com port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (workThread != null && workThread.IsAlive)
                {
                    workThread.Abort();
                    RUNNING = false;
                    log_addtime(appPATH, "Stop!" + " " + "Power on counter=" + runCounter.ToString() + " and Power off counter=" + offCounter.ToString());
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdClean_Click(object sender, EventArgs e)
        {
            log_addtime(appPATH, "Clean Counter!" + " " + "Power on counter=" + runCounter.ToString() + " and Power off counter=" + offCounter.ToString());
            offCounter = 0;
            runCounter = 0;
        }

        private void backgroundWork()
        {
            try
            {
                while (true)
                {
                    // off time
                    Savetime = timeGetTime(); //記下開始時的時間
                    while (timeGetTime() < Savetime + offtimeInterval) //循環等待
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                    }
                    // then power on
                    log_addtime(appPATH, "power on");
                    serialPort1.Write("atop_do 1 1\r\n");
                    runCounter++;
                    // run time
                    Savetime = timeGetTime(); //記下開始時的時間
                    while (timeGetTime() < Savetime + runtimeInterval) //循環等待
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                    }
                    // then power off
                    log_addtime(appPATH, "power off");
                    serialPort1.Write("atop_do 1 0\r\n");
                    offCounter++;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RUNNING = false;
                //log_addtime(appPATH, ex.Message + ex.StackTrace);
            }
        }

        private delegate void myUICallBack(string myStr, Control ctl);

        private void counterUI(string myStr, Control ctl)
        {
            if (this.InvokeRequired)
            {
                myUICallBack myUpdate = new myUICallBack(counterUI);
                this.Invoke(myUpdate, myStr, ctl);
            }
            else
            {
                ctl.Text = myStr;
            }
        }

        private void UItmr_Tick(object sender, EventArgs e)
        {
            lblOFFcounter.Text = offCounter.ToString();
            lblRUNcounter.Text = runCounter.ToString();

            if (RUNNING)
            {
                cmbportname.Enabled = false;
                cmdConnect.Enabled = false;
                txtOff_time.Enabled = false;
                txtRun_time.Enabled = false;
                cmdStart.Enabled = false;
                cmdStop.Enabled = true;
            }
            else
            {
                cmbportname.Enabled = true;
                cmdConnect.Enabled = true;
                txtOff_time.Enabled = true;
                txtRun_time.Enabled = true;
                cmdStart.Enabled = true;
                cmdStop.Enabled = true;
            }
        }

        #region 寫入csv(txt)Log

        private void log_addtime(string SaveFileName, string tmpstr)
        {
            DateTime time = DateTime.Now;
            string tmpLogstr;
            // '\r'是回車，'\n'是換行，前者使游標到行首，後者使游標下移一格。通常用的Enter是兩個加起來。
            tmpLogstr = String.Format("{0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second) + "   " + tmpstr + "\r";
            //tmpLogstr = String.Format("{0:00}/{1:00}/{2:00},{3:00}:{4:00}:{5:00}", time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second) + "," + tmpstr + "\r";
            writeLog_csv(SaveFileName, tmpLogstr);
        }

        private void writeLog_csv(string SaveFilePath, string SaveLogstr)
        {
            // 建立檔案
            FileStream fs = File.Open(SaveFilePath + @"\" + String.Format("{0:00}-{1:00}-{2:00}", ProgramStartTime.Year, ProgramStartTime.Month, ProgramStartTime.Day) + ".txt", FileMode.Append, FileAccess.Write);
            // 建構StreamWriter物件
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                // 寫入
                sw.WriteLine(SaveLogstr);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //例外處理
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
            finally
            {
                // 清除目前寫入器(Writer)的所有緩衝區，並且造成任何緩衝資料都寫入基礎資料流
                sw.Flush();

                // 關閉目前的StreamWriter物件和基礎資料流
                sw.Close();
                fs.Close();
            }
        }

        #endregion 寫入csv(txt)Log
    }
}