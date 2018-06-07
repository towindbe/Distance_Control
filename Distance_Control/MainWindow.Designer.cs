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
            this.CalibrateLF025_button = new System.Windows.Forms.Button();
            this.RemoveElectrode_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetHardware_button = new System.Windows.Forms.Button();
            this.StallValue_groupbox = new System.Windows.Forms.GroupBox();
            this.SetStallValue_button = new System.Windows.Forms.Button();
            this.StallValue_textbox = new System.Windows.Forms.TextBox();
            this.StallValue_label = new System.Windows.Forms.Label();
            this.Stallvalue_trackbar = new System.Windows.Forms.TrackBar();
            this.Sensitivity_groupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetSensitivity_button = new System.Windows.Forms.Button();
            this.Sensitivity_checkbox = new System.Windows.Forms.CheckBox();
            this.Connection_Groupbox.SuspendLayout();
            this.ReceivedData_groupbox.SuspendLayout();
            this.StallValue_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stallvalue_trackbar)).BeginInit();
            this.Sensitivity_groupbox.SuspendLayout();
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
            this.Connection_Groupbox.Size = new System.Drawing.Size(176, 146);
            this.Connection_Groupbox.TabIndex = 0;
            this.Connection_Groupbox.TabStop = false;
            this.Connection_Groupbox.Text = "Connection";
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.Location = new System.Drawing.Point(24, 102);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(121, 23);
            this.Disconnect_button.TabIndex = 3;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(24, 73);
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
            this.ComPort_combobox.Location = new System.Drawing.Point(24, 44);
            this.ComPort_combobox.Name = "ComPort_combobox";
            this.ComPort_combobox.Size = new System.Drawing.Size(121, 21);
            this.ComPort_combobox.TabIndex = 1;
            // 
            // ComPort_label
            // 
            this.ComPort_label.AutoSize = true;
            this.ComPort_label.Location = new System.Drawing.Point(21, 28);
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
            this.ReceivedData_groupbox.Size = new System.Drawing.Size(885, 205);
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
            // CalibrateLF025_button
            // 
            this.CalibrateLF025_button.Location = new System.Drawing.Point(654, 12);
            this.CalibrateLF025_button.Name = "CalibrateLF025_button";
            this.CalibrateLF025_button.Size = new System.Drawing.Size(95, 48);
            this.CalibrateLF025_button.TabIndex = 2;
            this.CalibrateLF025_button.Text = "calibrate LF025";
            this.CalibrateLF025_button.UseVisualStyleBackColor = true;
            this.CalibrateLF025_button.Click += new System.EventHandler(this.CalibrateLF025_button_Click);
            // 
            // RemoveElectrode_button
            // 
            this.RemoveElectrode_button.Location = new System.Drawing.Point(654, 66);
            this.RemoveElectrode_button.Name = "RemoveElectrode_button";
            this.RemoveElectrode_button.Size = new System.Drawing.Size(95, 23);
            this.RemoveElectrode_button.TabIndex = 3;
            this.RemoveElectrode_button.Text = "Remove";
            this.RemoveElectrode_button.UseVisualStyleBackColor = true;
            this.RemoveElectrode_button.Click += new System.EventHandler(this.RemoveElectrode_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetHardware_button
            // 
            this.ResetHardware_button.Location = new System.Drawing.Point(654, 95);
            this.ResetHardware_button.Name = "ResetHardware_button";
            this.ResetHardware_button.Size = new System.Drawing.Size(95, 23);
            this.ResetHardware_button.TabIndex = 5;
            this.ResetHardware_button.Text = "Reset Hardware";
            this.ResetHardware_button.UseVisualStyleBackColor = true;
            this.ResetHardware_button.Click += new System.EventHandler(this.ResetHardware_button_Click);
            // 
            // StallValue_groupbox
            // 
            this.StallValue_groupbox.Controls.Add(this.SetStallValue_button);
            this.StallValue_groupbox.Controls.Add(this.StallValue_textbox);
            this.StallValue_groupbox.Controls.Add(this.StallValue_label);
            this.StallValue_groupbox.Location = new System.Drawing.Point(206, 12);
            this.StallValue_groupbox.Name = "StallValue_groupbox";
            this.StallValue_groupbox.Size = new System.Drawing.Size(124, 146);
            this.StallValue_groupbox.TabIndex = 6;
            this.StallValue_groupbox.TabStop = false;
            this.StallValue_groupbox.Text = "Motor Sensitivity";
            // 
            // SetStallValue_button
            // 
            this.SetStallValue_button.Location = new System.Drawing.Point(24, 72);
            this.SetStallValue_button.Name = "SetStallValue_button";
            this.SetStallValue_button.Size = new System.Drawing.Size(76, 24);
            this.SetStallValue_button.TabIndex = 2;
            this.SetStallValue_button.Text = "Set Value";
            this.SetStallValue_button.UseVisualStyleBackColor = true;
            this.SetStallValue_button.Click += new System.EventHandler(this.SetStallValue_button_Click);
            // 
            // StallValue_textbox
            // 
            this.StallValue_textbox.Location = new System.Drawing.Point(24, 44);
            this.StallValue_textbox.Multiline = true;
            this.StallValue_textbox.Name = "StallValue_textbox";
            this.StallValue_textbox.Size = new System.Drawing.Size(76, 21);
            this.StallValue_textbox.TabIndex = 1;
            this.StallValue_textbox.TextChanged += new System.EventHandler(this.StallValue_textbox_TextChanged);
            // 
            // StallValue_label
            // 
            this.StallValue_label.AutoSize = true;
            this.StallValue_label.Location = new System.Drawing.Point(21, 28);
            this.StallValue_label.Name = "StallValue_label";
            this.StallValue_label.Size = new System.Drawing.Size(79, 13);
            this.StallValue_label.TabIndex = 0;
            this.StallValue_label.Text = "Set Stall Value:";
            // 
            // Stallvalue_trackbar
            // 
            this.Stallvalue_trackbar.LargeChange = 1;
            this.Stallvalue_trackbar.Location = new System.Drawing.Point(26, 51);
            this.Stallvalue_trackbar.Maximum = 21;
            this.Stallvalue_trackbar.Minimum = 13;
            this.Stallvalue_trackbar.Name = "Stallvalue_trackbar";
            this.Stallvalue_trackbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stallvalue_trackbar.Size = new System.Drawing.Size(228, 45);
            this.Stallvalue_trackbar.TabIndex = 7;
            this.Stallvalue_trackbar.Value = 15;
            this.Stallvalue_trackbar.ValueChanged += new System.EventHandler(this.Stallvalue_trackbar_ValueChanged);
            // 
            // Sensitivity_groupbox
            // 
            this.Sensitivity_groupbox.Controls.Add(this.Sensitivity_checkbox);
            this.Sensitivity_groupbox.Controls.Add(this.label2);
            this.Sensitivity_groupbox.Controls.Add(this.label1);
            this.Sensitivity_groupbox.Controls.Add(this.SetSensitivity_button);
            this.Sensitivity_groupbox.Controls.Add(this.Stallvalue_trackbar);
            this.Sensitivity_groupbox.Location = new System.Drawing.Point(350, 12);
            this.Sensitivity_groupbox.Name = "Sensitivity_groupbox";
            this.Sensitivity_groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sensitivity_groupbox.Size = new System.Drawing.Size(281, 146);
            this.Sensitivity_groupbox.TabIndex = 8;
            this.Sensitivity_groupbox.TabStop = false;
            this.Sensitivity_groupbox.Text = "Motor Stall Sensitivity";
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
            this.SetSensitivity_button.Location = new System.Drawing.Point(26, 102);
            this.SetSensitivity_button.Name = "SetSensitivity_button";
            this.SetSensitivity_button.Size = new System.Drawing.Size(89, 23);
            this.SetSensitivity_button.TabIndex = 8;
            this.SetSensitivity_button.Text = "Set Limit";
            this.SetSensitivity_button.UseVisualStyleBackColor = true;
            this.SetSensitivity_button.Click += new System.EventHandler(this.SetSensitivity_button_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.Sensitivity_groupbox);
            this.Controls.Add(this.StallValue_groupbox);
            this.Controls.Add(this.ResetHardware_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveElectrode_button);
            this.Controls.Add(this.CalibrateLF025_button);
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
            this.StallValue_groupbox.ResumeLayout(false);
            this.StallValue_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stallvalue_trackbar)).EndInit();
            this.Sensitivity_groupbox.ResumeLayout(false);
            this.Sensitivity_groupbox.PerformLayout();
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
        private System.Windows.Forms.Button CalibrateLF025_button;
        private System.Windows.Forms.Button RemoveElectrode_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetHardware_button;
        private System.Windows.Forms.GroupBox StallValue_groupbox;
        private System.Windows.Forms.TextBox StallValue_textbox;
        private System.Windows.Forms.Label StallValue_label;
        private System.Windows.Forms.Button SetStallValue_button;
        private System.Windows.Forms.TrackBar Stallvalue_trackbar;
        private System.Windows.Forms.GroupBox Sensitivity_groupbox;
        private System.Windows.Forms.Button SetSensitivity_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Sensitivity_checkbox;
    }
}

