using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
//EPOS用
using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;
using EposCmd.Net.DeviceCmdSet.DataRecorder;

namespace Demo_EposCmd
{
    public partial class Form1 : Form
    {
        private DeviceManager _mConnector;
        private Device _mEpos;
        // serial number about filename
        private int times = 0;
        
        //public const int samplingNum = 1; //試行回数
        //  private int fileCount = 0;

        //Profile Position用
        uint ProfileVelocity = 3000, ProfileAcceleration = 10000, ProfileDeceleration = 10000;

        //EPOS2 DataRecorder用
        byte chNum = 1;
        ushort samplingPeriod = 0;
        ushort pNbOfPrecedingSamples = 0;

        //PositionTable用 储位置数据的数据结构
        List<int> positionList = new List<int>();
        int[] positionArray;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_mConnector != null)
            {
                _mConnector.Dispose();
            }

            Close();
        }
        private void buttonSettings_Click(object sender, EventArgs ea)
        {
            try
            {
                _mConnector = new DeviceManager("EPOS2", "MAXON SERIAL V2", "USB", "USB0");

                //set connection properties
                uint b = _mConnector.Baudrate;  //get baudrate info
                _mConnector.Baudrate = b;   //set baudrate info
                _mConnector.Timeout = 500;

                //buttonEnable.Enabled = true;

                _mEpos = _mConnector.CreateDevice(Convert.ToUInt16(textBoxNodeId.Text));
                if (_mEpos == null)
                {
                    // Handle the error or try re-initializing
                    MessageBox.Show("Error initializing EPOS device.");
                    return; // Or retry logic
                }


                textBoxAOM.Text = _mEpos.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                sm.SetEnableState();

                buttonMove.Enabled = true;

                timer1.Enabled = true;

                //原点移動
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;
                ppm.ActivateProfilePositionMode();
                ppm.MoveToPosition(0, true, false);

                // Profile Position Modeのパラメータ取得
                ppm.SetPositionProfile(ProfileVelocity, ProfileAcceleration, ProfileDeceleration);
                ppm.GetPositionProfile(ref ProfileVelocity, ref ProfileAcceleration, ref ProfileDeceleration);
                textBoxProfileVelosity.Text = String.Format("{0}", ProfileVelocity);
                textBoxProfileAcceleration.Text = String.Format("{0}", ProfileAcceleration);
                textBoxProfileDeceleration.Text = String.Format("{0}", ProfileDeceleration);

                //EPOS2 DataRecorder用
                Epos2DataRecorderSetup();
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonEnable_Click(object sender, EventArgs ea)
        {
            try
            {
                _mEpos = _mConnector.CreateDevice(Convert.ToUInt16(textBoxNodeId.Text));

                textBoxAOM.Text = _mEpos.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                sm.SetEnableState();

                buttonSettings.Enabled = false;
                buttonEnable.Enabled = false;
                buttonDisable.Enabled = true;
                buttonMove.Enabled = true;
                buttonHalt.Enabled = true;

                timer1.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonDisable_Click(object sender, EventArgs ea)
        {
            try
            {
                StateMachine sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                if (!sm.GetDisableState())
                    sm.SetDisableState();

                buttonSettings.Enabled = true;
                buttonEnable.Enabled = true;
                buttonDisable.Enabled = false;
                buttonMove.Enabled = false;
                buttonHalt.Enabled = false;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }
        private void buttonMove_Click(object sender, EventArgs ea)
        {
           
            try
            {
                buttonMove.Enabled = false;

                // 初始化EPOS数据记录器
                DataRecorder EPOSDataRecorder = _mEpos.DataRecording;
                Data EPOSdata = EPOSDataRecorder.Data;  // 用于数据获取和保存的Data类
                byte[] dataVector = new byte[1024]; // 数据存储数组
                
                //实行回数
                int samplingNum = 1;
                // 每转500单位
                int unitsPerRevolution = 500;

                // 移动到30度所需的单位数
                int unitsDegrees = (int)(unitsPerRevolution * (60.0 / 360.0));

                // 初始化
                positionList = new List<int> { 0, unitsDegrees, 0 };
                positionArray = positionList.ToArray();

                // 设置第一个目标位置到文本框
                textBoxTargetPosition.Text = positionArray[0].ToString();

                // 激活位置控制模式
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;
                ppm.ActivateProfilePositionMode();
                // 设置运动参数
                ppm.SetPositionProfile(ProfileVelocity, ProfileAcceleration, ProfileDeceleration);
                
                times++;
                // 循环执行移动和数据记录操作
                for (int i = 0; i < samplingNum; i++)
                {
                    // 设置EPOS2数据记录器的触发
                    EPOSDataRecorder.Setup.EnableTrigger(EDataRecorderTriggerType.DrMovementTrigger);
                    bool trig = false;
                    EPOSDataRecorder.Status.IsRecorderTriggered(ref trig);
                    if (trig)
                    {
                        Console.WriteLine("Data recorder triggered");
                    }
                    EPOSDataRecorder.Status.StartRecorder();

                    // 显示当前操作模式和起始位置
                    textBoxAOM.Text = _mEpos.Operation.OperationMode.GetOperationModeAsString();
                    textBoxPositionStart.Text = _mEpos.Operation.MotionInfo.GetPositionIs().ToString();
                    textBoxPositionStart.Refresh();

                    ppm.MoveToPosition(0, true, false);
                    ppm.MoveToPosition(500 * 60, false, false);
                    //System.Threading.Thread.Sleep(1000);
                    //ppm.MoveToPosition(-500 * 30, false, false);

                    // 保存EPOS数据记录器数据
                    EPOSdata.ReadChannelDataVector(chNum, ref dataVector);
                    // string EPOSdataCSV = @"C:\Users\WAMOEBA_SHARE\Desktop\EPOS_Windows_6346_C_Sharp\SAMPLE_DATA\EPOS2_DATA " + $"{i + 1}" + ".csv";
                    string EPOSdataCSV = @"C:\Users\WAMOEBA_SHARE\Desktop\EPOS_Windows_6346_C_Sharp\SAMPLE_DATA\EPOS2_DATA " + times + ".csv";
                    EPOSdata.ExportChannelDataToFile(EPOSdataCSV);
                    EPOSdata.ExportChannelDataToFile(EPOSdataCSV);

                    ExportDataAsAngle(EPOSdataCSV, dataVector);


                    // 更新目标位置和实际位置
                    textBoxTargetPosition.Text = positionArray[i].ToString();
                    textBoxTargetPosition.Refresh();
                    textBoxPositionActualValue.Text = _mEpos.Operation.MotionInfo.GetPositionIs().ToString();
                    textBoxPositionActualValue.Refresh();
                }
            }
            catch (DeviceException e)
            {
                // 设备异常处理
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                // 其他异常处理
                StopRefresh();
                MessageBox.Show(e.Message);
            }
            finally
            {
                // 重新启用移动按钮
                buttonMove.Enabled = true;
            }
        }

        private void buttonHalt_Click(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM.Text = _mEpos.Operation.OperationMode.GetOperationModeAsString();

                ppm.HaltPositionMovement();
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }
        private void StopRefresh()
        {
            try
            {
                timer1.Enabled = false;

                if (_mEpos != null) _mEpos = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonRelativeMode.Checked = true;
            timer1.Interval = 500;
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs ea)
        {
            try
            {
                if (_mEpos != null)
                {
                    textBoxPositionActualValue.Text = String.Format("{0}", _mEpos.Operation.MotionInfo.GetPositionIs());

                    if (_mEpos.Operation.StateMachine.GetEnableState())
                    {
                        buttonSettings.Enabled = false;
                        buttonEnable.Enabled = false;
                        buttonDisable.Enabled = true;
                        buttonMove.Enabled = true;
                        buttonHalt.Enabled = true;
                    }
                    else
                    {
                        buttonSettings.Enabled = true;
                        buttonEnable.Enabled = true;
                        buttonDisable.Enabled = false;
                        buttonMove.Enabled = false;
                        buttonHalt.Enabled = false;
                    }
                }
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }
        private void ShowMessageBox(string text, uint errorCode)
        {
            string msg;

            msg = String.Format("{0}\nErrorCode: {1:X8}", text, errorCode);
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Epos2DataRecorderSetup()
        {
            DataRecorder eposDataRecorder = _mEpos.DataRecording;

            eposDataRecorder.Setup.ActivateChannel(chNum, 0x6064, 0x00, 4);
            Console.WriteLine($"EPOS Recorder Ch_{chNum} Ready");

            eposDataRecorder.Setup.GetRecorderParameter(ref samplingPeriod, ref pNbOfPrecedingSamples);
            Console.WriteLine($"Current samplingPeriod: {samplingPeriod * 0.1} ms, PrecedingSamples: {pNbOfPrecedingSamples}");

            samplingPeriod = 100; // 设定新的采样周期
            eposDataRecorder.Setup.SetRecorderParameter(samplingPeriod, pNbOfPrecedingSamples);
            Console.WriteLine($"Updated samplingPeriod to {samplingPeriod * 0.1} ms");
        }
        // 转换角度
        private void ExportDataAsAngle(string filePath, byte[] data, double[] timestamps)
        {
            // 编码器分辨率为 500 * 360 步每圈
            int unitsPerRevolution = 500 * 360;

            // 每单位代表的角度
            double degreesPerUnit = 360.0 / unitsPerRevolution;

            // 使用StreamWriter写入文件
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // 首先写入列标题
                sw.WriteLine("angle,timestamp (s)");

                // 写入实际数据，每行都包含角度值和时间戳
                int dataPoints = Math.Min(data.Length / 4, timestamps.Length);
                for (int i = 0; i < dataPoints * 4; i += 4) // 每次递增4个字节
                {
                    // 字节转换为整数（假设这是编码器的原始数据）
                    int positionCount = BitConverter.ToInt32(data, i);

                    // 将位置计数转换为角度
                    double angle = Math.Round(positionCount * degreesPerUnit, 2);

                    // 使用EPOS记录的原始时间戳
                    double timestamp = timestamps[i / 4];

                    // 将角度值和时间戳添加到文件
                    sw.WriteLine($"{angle},{timestamp}");
                }
            }
        }







    }
}