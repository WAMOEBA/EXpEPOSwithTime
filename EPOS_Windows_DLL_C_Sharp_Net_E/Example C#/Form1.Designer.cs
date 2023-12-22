namespace Demo_EposCmd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNodeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAOM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAbsoluteMove = new System.Windows.Forms.RadioButton();
            this.radioButtonRelativeMode = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTargetPosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxProfileVelosity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxProfileAcceleration = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxProfileDeceleration = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPositionActualValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPositionStart = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonHalt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNodeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAOM);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EPOS_Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "NodeID:";
            // 
            // textBoxNodeId
            // 
            this.textBoxNodeId.Location = new System.Drawing.Point(138, 71);
            this.textBoxNodeId.Name = "textBoxNodeId";
            this.textBoxNodeId.Size = new System.Drawing.Size(57, 19);
            this.textBoxNodeId.TabIndex = 0;
            this.textBoxNodeId.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Operation Mode:";
            // 
            // textBoxAOM
            // 
            this.textBoxAOM.Location = new System.Drawing.Point(138, 33);
            this.textBoxAOM.Name = "textBoxAOM";
            this.textBoxAOM.ReadOnly = true;
            this.textBoxAOM.Size = new System.Drawing.Size(170, 19);
            this.textBoxAOM.TabIndex = 0;
            this.textBoxAOM.Text = "Unknown";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAbsoluteMove);
            this.groupBox2.Controls.Add(this.radioButtonRelativeMode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTargetPosition);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxProfileVelosity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxProfileAcceleration);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxProfileDeceleration);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Position Mode";
            // 
            // radioButtonAbsoluteMove
            // 
            this.radioButtonAbsoluteMove.AutoSize = true;
            this.radioButtonAbsoluteMove.Location = new System.Drawing.Point(103, 37);
            this.radioButtonAbsoluteMove.Name = "radioButtonAbsoluteMove";
            this.radioButtonAbsoluteMove.Size = new System.Drawing.Size(68, 16);
            this.radioButtonAbsoluteMove.TabIndex = 2;
            this.radioButtonAbsoluteMove.TabStop = true;
            this.radioButtonAbsoluteMove.Text = "&Absolute";
            this.radioButtonAbsoluteMove.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelativeMode
            // 
            this.radioButtonRelativeMode.AutoSize = true;
            this.radioButtonRelativeMode.Location = new System.Drawing.Point(208, 37);
            this.radioButtonRelativeMode.Name = "radioButtonRelativeMode";
            this.radioButtonRelativeMode.Size = new System.Drawing.Size(65, 16);
            this.radioButtonRelativeMode.TabIndex = 1;
            this.radioButtonRelativeMode.TabStop = true;
            this.radioButtonRelativeMode.Text = "&Relative";
            this.radioButtonRelativeMode.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "qc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Position:";
            // 
            // textBoxTargetPosition
            // 
            this.textBoxTargetPosition.Location = new System.Drawing.Point(138, 16);
            this.textBoxTargetPosition.Name = "textBoxTargetPosition";
            this.textBoxTargetPosition.ReadOnly = true;
            this.textBoxTargetPosition.Size = new System.Drawing.Size(82, 19);
            this.textBoxTargetPosition.TabIndex = 0;
            this.textBoxTargetPosition.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "rpm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Profile Velosity:";
            // 
            // textBoxProfileVelosity
            // 
            this.textBoxProfileVelosity.Location = new System.Drawing.Point(138, 59);
            this.textBoxProfileVelosity.Name = "textBoxProfileVelosity";
            this.textBoxProfileVelosity.ReadOnly = true;
            this.textBoxProfileVelosity.Size = new System.Drawing.Size(82, 19);
            this.textBoxProfileVelosity.TabIndex = 0;
            this.textBoxProfileVelosity.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "rpm/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "Profile Acceleration:";
            // 
            // textBoxProfileAcceleration
            // 
            this.textBoxProfileAcceleration.Location = new System.Drawing.Point(138, 89);
            this.textBoxProfileAcceleration.Name = "textBoxProfileAcceleration";
            this.textBoxProfileAcceleration.ReadOnly = true;
            this.textBoxProfileAcceleration.Size = new System.Drawing.Size(82, 19);
            this.textBoxProfileAcceleration.TabIndex = 0;
            this.textBoxProfileAcceleration.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "rpm/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "Profile Deceleration:";
            // 
            // textBoxProfileDeceleration
            // 
            this.textBoxProfileDeceleration.Location = new System.Drawing.Point(138, 121);
            this.textBoxProfileDeceleration.Name = "textBoxProfileDeceleration";
            this.textBoxProfileDeceleration.ReadOnly = true;
            this.textBoxProfileDeceleration.Size = new System.Drawing.Size(82, 19);
            this.textBoxProfileDeceleration.TabIndex = 0;
            this.textBoxProfileDeceleration.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPositionActualValue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxPositionStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 105);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual Values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "qc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position Actual Value:";
            // 
            // textBoxPositionActualValue
            // 
            this.textBoxPositionActualValue.Location = new System.Drawing.Point(144, 63);
            this.textBoxPositionActualValue.Name = "textBoxPositionActualValue";
            this.textBoxPositionActualValue.ReadOnly = true;
            this.textBoxPositionActualValue.Size = new System.Drawing.Size(164, 19);
            this.textBoxPositionActualValue.TabIndex = 8;
            this.textBoxPositionActualValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "qc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position Start:";
            // 
            // textBoxPositionStart
            // 
            this.textBoxPositionStart.Location = new System.Drawing.Point(144, 39);
            this.textBoxPositionStart.Name = "textBoxPositionStart";
            this.textBoxPositionStart.ReadOnly = true;
            this.textBoxPositionStart.Size = new System.Drawing.Size(164, 19);
            this.textBoxPositionStart.TabIndex = 2;
            this.textBoxPositionStart.Text = "0";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(403, 32);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(146, 26);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Device &Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Enabled = false;
            this.buttonEnable.Location = new System.Drawing.Point(403, 76);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(146, 26);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "&Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Enabled = false;
            this.buttonDisable.Location = new System.Drawing.Point(403, 107);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(146, 26);
            this.buttonDisable.TabIndex = 2;
            this.buttonDisable.Text = "&Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(403, 171);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(146, 26);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move and Sampling";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonHalt
            // 
            this.buttonHalt.Enabled = false;
            this.buttonHalt.Location = new System.Drawing.Point(403, 202);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(146, 26);
            this.buttonHalt.TabIndex = 4;
            this.buttonHalt.Text = "&Halt";
            this.buttonHalt.UseVisualStyleBackColor = true;
            this.buttonHalt.Click += new System.EventHandler(this.buttonHalt_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(403, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 26);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exi&t";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 553);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo EposCmd.Net / .NET Framework 2.0 / C# example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTargetPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNodeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAOM;
        private System.Windows.Forms.RadioButton radioButtonRelativeMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonAbsoluteMove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPositionActualValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPositionStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProfileVelosity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxProfileAcceleration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxProfileDeceleration;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonHalt;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
    }
}