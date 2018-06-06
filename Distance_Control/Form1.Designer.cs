namespace Distance_Control
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Connection_Groupbox = new System.Windows.Forms.GroupBox();
            this.ComPort_combobox = new System.Windows.Forms.ComboBox();
            this.ComPort_label = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.ReceivedData_groupbox = new System.Windows.Forms.GroupBox();
            this.ClearReceived_button = new System.Windows.Forms.Button();
            this.ReceivedData_textbox = new System.Windows.Forms.TextBox();
            this.Calibrate06_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Connection_Groupbox.SuspendLayout();
            this.ReceivedData_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection_Groupbox
            // 
            this.Connection_Groupbox.Controls.Add(this.Disconnect_button);
            this.Connection_Groupbox.Controls.Add(this.Connect_button);
            this.Connection_Groupbox.Controls.Add(this.ComPort_combobox);
            this.Connection_Groupbox.Controls.Add(this.ComPort_label);
            this.Connection_Groupbox.Location = new System.Drawing.Point(12, 21);
            this.Connection_Groupbox.Name = "Connection_Groupbox";
            this.Connection_Groupbox.Size = new System.Drawing.Size(176, 137);
            this.Connection_Groupbox.TabIndex = 0;
            this.Connection_Groupbox.TabStop = false;
            this.Connection_Groupbox.Text = "Connection";
            // 
            // ComPort_combobox
            // 
            this.ComPort_combobox.FormattingEnabled = true;
            this.ComPort_combobox.Location = new System.Drawing.Point(24, 36);
            this.ComPort_combobox.Name = "ComPort_combobox";
            this.ComPort_combobox.Size = new System.Drawing.Size(121, 21);
            this.ComPort_combobox.TabIndex = 1;
            // 
            // ComPort_label
            // 
            this.ComPort_label.AutoSize = true;
            this.ComPort_label.Location = new System.Drawing.Point(21, 20);
            this.ComPort_label.Name = "ComPort_label";
            this.ComPort_label.Size = new System.Drawing.Size(58, 13);
            this.ComPort_label.TabIndex = 0;
            this.ComPort_label.Text = "Serial Port:";
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(24, 63);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(121, 23);
            this.Connect_button.TabIndex = 2;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.Location = new System.Drawing.Point(24, 93);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(121, 23);
            this.Disconnect_button.TabIndex = 3;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            // 
            // ReceivedData_groupbox
            // 
            this.ReceivedData_groupbox.Controls.Add(this.ReceivedData_textbox);
            this.ReceivedData_groupbox.Controls.Add(this.ClearReceived_button);
            this.ReceivedData_groupbox.Location = new System.Drawing.Point(12, 192);
            this.ReceivedData_groupbox.Name = "ReceivedData_groupbox";
            this.ReceivedData_groupbox.Size = new System.Drawing.Size(776, 205);
            this.ReceivedData_groupbox.TabIndex = 1;
            this.ReceivedData_groupbox.TabStop = false;
            this.ReceivedData_groupbox.Text = "Received Data";
            // 
            // ClearReceived_button
            // 
            this.ClearReceived_button.Location = new System.Drawing.Point(24, 159);
            this.ClearReceived_button.Name = "ClearReceived_button";
            this.ClearReceived_button.Size = new System.Drawing.Size(103, 23);
            this.ClearReceived_button.TabIndex = 1;
            this.ClearReceived_button.Text = "Clear Window";
            this.ClearReceived_button.UseVisualStyleBackColor = true;
            // 
            // ReceivedData_textbox
            // 
            this.ReceivedData_textbox.Location = new System.Drawing.Point(27, 31);
            this.ReceivedData_textbox.Multiline = true;
            this.ReceivedData_textbox.Name = "ReceivedData_textbox";
            this.ReceivedData_textbox.Size = new System.Drawing.Size(722, 122);
            this.ReceivedData_textbox.TabIndex = 2;
            // 
            // Calibrate06_button
            // 
            this.Calibrate06_button.Location = new System.Drawing.Point(280, 30);
            this.Calibrate06_button.Name = "Calibrate06_button";
            this.Calibrate06_button.Size = new System.Drawing.Size(95, 48);
            this.Calibrate06_button.TabIndex = 2;
            this.Calibrate06_button.Text = "calibrate 0.6";
            this.Calibrate06_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calibrate06_button);
            this.Controls.Add(this.ReceivedData_groupbox);
            this.Controls.Add(this.Connection_Groupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Connection_Groupbox.ResumeLayout(false);
            this.Connection_Groupbox.PerformLayout();
            this.ReceivedData_groupbox.ResumeLayout(false);
            this.ReceivedData_groupbox.PerformLayout();
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
        private System.Windows.Forms.Button Calibrate06_button;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

