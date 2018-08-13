namespace Distance_Control
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connection_Groupbox = new System.Windows.Forms.GroupBox();
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.ComPort_combobox = new System.Windows.Forms.ComboBox();
            this.ComPort_label = new System.Windows.Forms.Label();
            this.ReceivedData_groupbox = new System.Windows.Forms.GroupBox();
            this.ReceivedData_textbox = new System.Windows.Forms.TextBox();
            this.ClearReceived_button = new System.Windows.Forms.Button();
            this.OpenStallMonitor_button = new System.Windows.Forms.Button();
            this.ResetHardware_button = new System.Windows.Forms.Button();
            this.Stallvalue_trackbar = new System.Windows.Forms.TrackBar();
            this.Sensitivity_groupbox = new System.Windows.Forms.GroupBox();
            this.Sensitivity_checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetSensitivity_button = new System.Windows.Forms.Button();
            this.setCurrent_groupbox = new System.Windows.Forms.GroupBox();
            this.setCurrent_label = new System.Windows.Forms.Label();
            this.setCurrent_button = new System.Windows.Forms.Button();
            this.setCurrent_textbox = new System.Windows.Forms.TextBox();
            this.Calibration_groupbox = new System.Windows.Forms.GroupBox();
            this.Calibration_button = new System.Windows.Forms.Button();
            this.HighE_button = new System.Windows.Forms.RadioButton();
            this.LowE_button = new System.Windows.Forms.RadioButton();
            this.Position_groupbox = new System.Windows.Forms.GroupBox();
            this.setAngle_button = new System.Windows.Forms.Button();
            this.setAngle_label = new System.Windows.Forms.Label();
            this.setAngle_textbox = new System.Windows.Forms.TextBox();
            this.Angletomm_label = new System.Windows.Forms.Label();
            this.Connection_Groupbox.SuspendLayout();
            this.ReceivedData_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stallvalue_trackbar)).BeginInit();
            this.Sensitivity_groupbox.SuspendLayout();
            this.setCurrent_groupbox.SuspendLayout();
            this.Calibration_groupbox.SuspendLayout();
            this.Position_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection_Groupbox
            // 
            this.Connection_Groupbox.Controls.Add(this.Disconnect_button);
            this.Connection_Groupbox.Controls.Add(this.Connect_button);
            this.Connection_Groupbox.Controls.Add(this.ComPort_combobox);
            this.Connection_Groupbox.Controls.Add(this.ComPort_label);
            this.Connection_Groupbox.Location = new System.Drawing.Point(12, 12);
            this.Connection_Groupbox.Name = "Connection_Groupbox";
            this.Connection_Groupbox.Size = new System.Drawing.Size(153, 146);
            this.Connection_Groupbox.TabIndex = 0;
            this.Connection_Groupbox.TabStop = false;
            this.Connection_Groupbox.Text = "Connection";
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.Location = new System.Drawing.Point(15, 99);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(121, 23);
            this.Disconnect_button.TabIndex = 3;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(15, 70);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(121, 23);
            this.Connect_button.TabIndex = 2;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // ComPort_combobox
            // 
            this.ComPort_combobox.FormattingEnabled = true;
            this.ComPort_combobox.Location = new System.Drawing.Point(15, 41);
            this.ComPort_combobox.Name = "ComPort_combobox";
            this.ComPort_combobox.Size = new System.Drawing.Size(121, 21);
            this.ComPort_combobox.TabIndex = 1;
            // 
            // ComPort_label
            // 
            this.ComPort_label.AutoSize = true;
            this.ComPort_label.Location = new System.Drawing.Point(12, 25);
            this.ComPort_label.Name = "ComPort_label";
            this.ComPort_label.Size = new System.Drawing.Size(58, 13);
            this.ComPort_label.TabIndex = 0;
            this.ComPort_label.Text = "Serial Port:";
            // 
            // ReceivedData_groupbox
            // 
            this.ReceivedData_groupbox.Controls.Add(this.ReceivedData_textbox);
            this.ReceivedData_groupbox.Controls.Add(this.ClearReceived_button);
            this.ReceivedData_groupbox.Location = new System.Drawing.Point(12, 192);
            this.ReceivedData_groupbox.Name = "ReceivedData_groupbox";
            this.ReceivedData_groupbox.Size = new System.Drawing.Size(897, 205);
            this.ReceivedData_groupbox.TabIndex = 1;
            this.ReceivedData_groupbox.TabStop = false;
            this.ReceivedData_groupbox.Text = "Received Data";
            // 
            // ReceivedData_textbox
            // 
            this.ReceivedData_textbox.Location = new System.Drawing.Point(27, 31);
            this.ReceivedData_textbox.Multiline = true;
            this.ReceivedData_textbox.Name = "ReceivedData_textbox";
            this.ReceivedData_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedData_textbox.Size = new System.Drawing.Size(821, 122);
            this.ReceivedData_textbox.TabIndex = 2;
            // 
            // ClearReceived_button
            // 
            this.ClearReceived_button.Location = new System.Drawing.Point(24, 159);
            this.ClearReceived_button.Name = "ClearReceived_button";
            this.ClearReceived_button.Size = new System.Drawing.Size(103, 23);
            this.ClearReceived_button.TabIndex = 1;
            this.ClearReceived_button.Text = "Clear Window";
            this.ClearReceived_button.UseVisualStyleBackColor = true;
            this.ClearReceived_button.Click += new System.EventHandler(this.ClearReceived_button_Click);
            // 
            // OpenStallMonitor_button
            // 
            this.OpenStallMonitor_button.Location = new System.Drawing.Point(12, 417);
            this.OpenStallMonitor_button.Name = "OpenStallMonitor_button";
            this.OpenStallMonitor_button.Size = new System.Drawing.Size(119, 39);
            this.OpenStallMonitor_button.TabIndex = 4;
            this.OpenStallMonitor_button.Text = "Open Stall Monitor";
            this.OpenStallMonitor_button.UseVisualStyleBackColor = true;
            this.OpenStallMonitor_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetHardware_button
            // 
            this.ResetHardware_button.Location = new System.Drawing.Point(161, 417);
            this.ResetHardware_button.Name = "ResetHardware_button";
            this.ResetHardware_button.Size = new System.Drawing.Size(119, 39);
            this.ResetHardware_button.TabIndex = 5;
            this.ResetHardware_button.Text = "Reset Hardware";
            this.ResetHardware_button.UseVisualStyleBackColor = true;
            this.ResetHardware_button.Click += new System.EventHandler(this.ResetHardware_button_Click);
            // 
            // Stallvalue_trackbar
            // 
            this.Stallvalue_trackbar.LargeChange = 1;
            this.Stallvalue_trackbar.Location = new System.Drawing.Point(26, 51);
            this.Stallvalue_trackbar.Maximum = 15;
            this.Stallvalue_trackbar.Minimum = 9;
            this.Stallvalue_trackbar.Name = "Stallvalue_trackbar";
            this.Stallvalue_trackbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stallvalue_trackbar.Size = new System.Drawing.Size(228, 45);
            this.Stallvalue_trackbar.TabIndex = 7;
            this.Stallvalue_trackbar.Value = 11;
            this.Stallvalue_trackbar.ValueChanged += new System.EventHandler(this.Stallvalue_trackbar_ValueChanged);
            // 
            // Sensitivity_groupbox
            // 
            this.Sensitivity_groupbox.Controls.Add(this.Sensitivity_checkbox);
            this.Sensitivity_groupbox.Controls.Add(this.label2);
            this.Sensitivity_groupbox.Controls.Add(this.label1);
            this.Sensitivity_groupbox.Controls.Add(this.SetSensitivity_button);
            this.Sensitivity_groupbox.Controls.Add(this.Stallvalue_trackbar);
            this.Sensitivity_groupbox.Location = new System.Drawing.Point(326, 12);
            this.Sensitivity_groupbox.Name = "Sensitivity_groupbox";
            this.Sensitivity_groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sensitivity_groupbox.Size = new System.Drawing.Size(281, 146);
            this.Sensitivity_groupbox.TabIndex = 8;
            this.Sensitivity_groupbox.TabStop = false;
            this.Sensitivity_groupbox.Text = "Motor Stall Sensitivity";
            // 
            // Sensitivity_checkbox
            // 
            this.Sensitivity_checkbox.AutoSize = true;
            this.Sensitivity_checkbox.Checked = true;
            this.Sensitivity_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sensitivity_checkbox.Location = new System.Drawing.Point(157, 106);
            this.Sensitivity_checkbox.Name = "Sensitivity_checkbox";
            this.Sensitivity_checkbox.Size = new System.Drawing.Size(96, 17);
            this.Sensitivity_checkbox.TabIndex = 11;
            this.Sensitivity_checkbox.Text = "Default Setting";
            this.Sensitivity_checkbox.UseVisualStyleBackColor = true;
            this.Sensitivity_checkbox.CheckedChanged += new System.EventHandler(this.Sensitivity_checkbox_CheckedChanged);
            this.Sensitivity_checkbox.Click += new System.EventHandler(this.Sensitivity_checkbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "High";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Low";
            // 
            // SetSensitivity_button
            // 
            this.SetSensitivity_button.Location = new System.Drawing.Point(26, 100);
            this.SetSensitivity_button.Name = "SetSensitivity_button";
            this.SetSensitivity_button.Size = new System.Drawing.Size(89, 23);
            this.SetSensitivity_button.TabIndex = 8;
            this.SetSensitivity_button.Text = "Set Limit";
            this.SetSensitivity_button.UseVisualStyleBackColor = true;
            this.SetSensitivity_button.Click += new System.EventHandler(this.SetSensitivity_button_Click);
            // 
            // setCurrent_groupbox
            // 
            this.setCurrent_groupbox.Controls.Add(this.setCurrent_label);
            this.setCurrent_groupbox.Controls.Add(this.setCurrent_button);
            this.setCurrent_groupbox.Controls.Add(this.setCurrent_textbox);
            this.setCurrent_groupbox.Location = new System.Drawing.Point(183, 12);
            this.setCurrent_groupbox.Name = "setCurrent_groupbox";
            this.setCurrent_groupbox.Size = new System.Drawing.Size(124, 146);
            this.setCurrent_groupbox.TabIndex = 10;
            this.setCurrent_groupbox.TabStop = false;
            this.setCurrent_groupbox.Text = "Motor Current RMS";
            // 
            // setCurrent_label
            // 
            this.setCurrent_label.AutoSize = true;
            this.setCurrent_label.Location = new System.Drawing.Point(23, 33);
            this.setCurrent_label.Name = "setCurrent_label";
            this.setCurrent_label.Size = new System.Drawing.Size(74, 13);
            this.setCurrent_label.TabIndex = 2;
            this.setCurrent_label.Text = "Current Value:";
            // 
            // setCurrent_button
            // 
            this.setCurrent_button.Location = new System.Drawing.Point(26, 100);
            this.setCurrent_button.Name = "setCurrent_button";
            this.setCurrent_button.Size = new System.Drawing.Size(75, 23);
            this.setCurrent_button.TabIndex = 1;
            this.setCurrent_button.Text = "Set Current";
            this.setCurrent_button.UseVisualStyleBackColor = true;
            this.setCurrent_button.Click += new System.EventHandler(this.setCurrent_button_Click);
            // 
            // setCurrent_textbox
            // 
            this.setCurrent_textbox.Location = new System.Drawing.Point(26, 49);
            this.setCurrent_textbox.Name = "setCurrent_textbox";
            this.setCurrent_textbox.Size = new System.Drawing.Size(76, 20);
            this.setCurrent_textbox.TabIndex = 0;
            this.setCurrent_textbox.TextChanged += new System.EventHandler(this.setCurrent_textbox_TextChanged);
            // 
            // Calibration_groupbox
            // 
            this.Calibration_groupbox.Controls.Add(this.Calibration_button);
            this.Calibration_groupbox.Controls.Add(this.HighE_button);
            this.Calibration_groupbox.Controls.Add(this.LowE_button);
            this.Calibration_groupbox.Location = new System.Drawing.Point(627, 12);
            this.Calibration_groupbox.Name = "Calibration_groupbox";
            this.Calibration_groupbox.Size = new System.Drawing.Size(128, 146);
            this.Calibration_groupbox.TabIndex = 11;
            this.Calibration_groupbox.TabStop = false;
            this.Calibration_groupbox.Text = "Calibration";
            // 
            // Calibration_button
            // 
            this.Calibration_button.Location = new System.Drawing.Point(25, 89);
            this.Calibration_button.Name = "Calibration_button";
            this.Calibration_button.Size = new System.Drawing.Size(75, 34);
            this.Calibration_button.TabIndex = 2;
            this.Calibration_button.Text = "Calibration";
            this.Calibration_button.UseVisualStyleBackColor = true;
            this.Calibration_button.Click += new System.EventHandler(this.Calibration_button_Click);
            // 
            // HighE_button
            // 
            this.HighE_button.AutoSize = true;
            this.HighE_button.Location = new System.Drawing.Point(6, 52);
            this.HighE_button.Name = "HighE_button";
            this.HighE_button.Size = new System.Drawing.Size(120, 17);
            this.HighE_button.TabIndex = 1;
            this.HighE_button.TabStop = true;
            this.HighE_button.Text = "High Energy Device";
            this.HighE_button.UseVisualStyleBackColor = true;
            this.HighE_button.CheckedChanged += new System.EventHandler(this.HighE_button_CheckedChanged);
            // 
            // LowE_button
            // 
            this.LowE_button.AutoSize = true;
            this.LowE_button.Location = new System.Drawing.Point(6, 29);
            this.LowE_button.Name = "LowE_button";
            this.LowE_button.Size = new System.Drawing.Size(118, 17);
            this.LowE_button.TabIndex = 0;
            this.LowE_button.TabStop = true;
            this.LowE_button.Text = "Low Energy Device";
            this.LowE_button.UseVisualStyleBackColor = true;
            this.LowE_button.CheckedChanged += new System.EventHandler(this.LowE_button_CheckedChanged);
            // 
            // Position_groupbox
            // 
            this.Position_groupbox.Controls.Add(this.Angletomm_label);
            this.Position_groupbox.Controls.Add(this.setAngle_button);
            this.Position_groupbox.Controls.Add(this.setAngle_label);
            this.Position_groupbox.Controls.Add(this.setAngle_textbox);
            this.Position_groupbox.Location = new System.Drawing.Point(776, 12);
            this.Position_groupbox.Name = "Position_groupbox";
            this.Position_groupbox.Size = new System.Drawing.Size(133, 146);
            this.Position_groupbox.TabIndex = 12;
            this.Position_groupbox.TabStop = false;
            this.Position_groupbox.Text = "Free Positioning";
            // 
            // setAngle_button
            // 
            this.setAngle_button.Location = new System.Drawing.Point(17, 98);
            this.setAngle_button.Name = "setAngle_button";
            this.setAngle_button.Size = new System.Drawing.Size(91, 25);
            this.setAngle_button.TabIndex = 2;
            this.setAngle_button.Text = "Move Electrode";
            this.setAngle_button.UseVisualStyleBackColor = true;
            this.setAngle_button.Click += new System.EventHandler(this.setAngle_button_Click);
            // 
            // setAngle_label
            // 
            this.setAngle_label.AutoSize = true;
            this.setAngle_label.Location = new System.Drawing.Point(14, 33);
            this.setAngle_label.Name = "setAngle_label";
            this.setAngle_label.Size = new System.Drawing.Size(80, 13);
            this.setAngle_label.TabIndex = 1;
            this.setAngle_label.Text = "Rotation Angle:";
            // 
            // setAngle_textbox
            // 
            this.setAngle_textbox.Location = new System.Drawing.Point(17, 49);
            this.setAngle_textbox.Name = "setAngle_textbox";
            this.setAngle_textbox.Size = new System.Drawing.Size(91, 20);
            this.setAngle_textbox.TabIndex = 0;
            this.setAngle_textbox.TextChanged += new System.EventHandler(this.setAngle_textbox_TextChanged);
            // 
            // Angletomm_label
            // 
            this.Angletomm_label.AutoSize = true;
            this.Angletomm_label.Location = new System.Drawing.Point(17, 73);
            this.Angletomm_label.Name = "Angletomm_label";
            this.Angletomm_label.Size = new System.Drawing.Size(0, 13);
            this.Angletomm_label.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 471);
            this.Controls.Add(this.Position_groupbox);
            this.Controls.Add(this.Calibration_groupbox);
            this.Controls.Add(this.setCurrent_groupbox);
            this.Controls.Add(this.Sensitivity_groupbox);
            this.Controls.Add(this.ResetHardware_button);
            this.Controls.Add(this.OpenStallMonitor_button);
            this.Controls.Add(this.ReceivedData_groupbox);
            this.Controls.Add(this.Connection_Groupbox);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Distance Control";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Connection_Groupbox.ResumeLayout(false);
            this.Connection_Groupbox.PerformLayout();
            this.ReceivedData_groupbox.ResumeLayout(false);
            this.ReceivedData_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stallvalue_trackbar)).EndInit();
            this.Sensitivity_groupbox.ResumeLayout(false);
            this.Sensitivity_groupbox.PerformLayout();
            this.setCurrent_groupbox.ResumeLayout(false);
            this.setCurrent_groupbox.PerformLayout();
            this.Calibration_groupbox.ResumeLayout(false);
            this.Calibration_groupbox.PerformLayout();
            this.Position_groupbox.ResumeLayout(false);
            this.Position_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Connection_Groupbox;
        private System.Windows.Forms.ComboBox ComPort_combobox;
        private System.Windows.Forms.Label ComPort_label;
        private System.Windows.Forms.Button Disconnect_button;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.GroupBox ReceivedData_groupbox;
        private System.Windows.Forms.Button ClearReceived_button;
        private System.Windows.Forms.TextBox ReceivedData_textbox;
        private System.Windows.Forms.Button OpenStallMonitor_button;
        private System.Windows.Forms.Button ResetHardware_button;
        private System.Windows.Forms.TrackBar Stallvalue_trackbar;
        private System.Windows.Forms.GroupBox Sensitivity_groupbox;
        private System.Windows.Forms.Button SetSensitivity_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Sensitivity_checkbox;
        private System.Windows.Forms.GroupBox setCurrent_groupbox;
        private System.Windows.Forms.Label setCurrent_label;
        private System.Windows.Forms.Button setCurrent_button;
        private System.Windows.Forms.TextBox setCurrent_textbox;
        private System.Windows.Forms.GroupBox Calibration_groupbox;
        private System.Windows.Forms.RadioButton HighE_button;
        private System.Windows.Forms.RadioButton LowE_button;
        private System.Windows.Forms.Button Calibration_button;
        private System.Windows.Forms.GroupBox Position_groupbox;
        private System.Windows.Forms.Button setAngle_button;
        private System.Windows.Forms.Label setAngle_label;
        private System.Windows.Forms.TextBox setAngle_textbox;
        private System.Windows.Forms.Label Angletomm_label;
    }
}

