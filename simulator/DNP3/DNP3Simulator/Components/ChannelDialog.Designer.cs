﻿namespace Automatak.Simulator.DNP3.Components
{
    partial class ChannelDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelDialog));
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.tabControlChannelType = new System.Windows.Forms.TabControl();
            this.tabPageTCPClient = new System.Windows.Forms.TabPage();
            this.clientEnableTls = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.serverEnableTls = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownServerPort = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxServerHost = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownDataBits = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBaud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSerialDeviceName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMaxRetryMS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinRetryMS = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logLevelControl1 = new Automatak.Simulator.DNP3.Components.LogLevelControl();
            this.clientTLSOptionsControl = new Automatak.Simulator.DNP3.TLSOptionsControl();
            this.serverTLSOptionsControl = new Automatak.Simulator.DNP3.TLSOptionsControl();
            this.groupBoxButtons.SuspendLayout();
            this.tabControlChannelType.SuspendLayout();
            this.tabPageTCPClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.tabPageServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServerPort)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaud)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRetryMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRetryMS)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonCancel);
            this.groupBoxButtons.Controls.Add(this.buttonADD);
            this.groupBoxButtons.Location = new System.Drawing.Point(19, 550);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxButtons.Size = new System.Drawing.Size(805, 96);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(631, 23);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 52);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADD.Location = new System.Drawing.Point(468, 23);
            this.buttonADD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(155, 52);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // tabControlChannelType
            // 
            this.tabControlChannelType.Controls.Add(this.tabPageTCPClient);
            this.tabControlChannelType.Controls.Add(this.tabPageServer);
            this.tabControlChannelType.Controls.Add(this.tabPage1);
            this.tabControlChannelType.Location = new System.Drawing.Point(19, 15);
            this.tabControlChannelType.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlChannelType.Name = "tabControlChannelType";
            this.tabControlChannelType.SelectedIndex = 0;
            this.tabControlChannelType.Size = new System.Drawing.Size(811, 359);
            this.tabControlChannelType.TabIndex = 2;
            // 
            // tabPageTCPClient
            // 
            this.tabPageTCPClient.Controls.Add(this.clientTLSOptionsControl);
            this.tabPageTCPClient.Controls.Add(this.clientEnableTls);
            this.tabPageTCPClient.Controls.Add(this.label5);
            this.tabPageTCPClient.Controls.Add(this.numericUpDownPort);
            this.tabPageTCPClient.Controls.Add(this.label4);
            this.tabPageTCPClient.Controls.Add(this.textBoxHost);
            this.tabPageTCPClient.Location = new System.Drawing.Point(4, 25);
            this.tabPageTCPClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTCPClient.Name = "tabPageTCPClient";
            this.tabPageTCPClient.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTCPClient.Size = new System.Drawing.Size(803, 330);
            this.tabPageTCPClient.TabIndex = 0;
            this.tabPageTCPClient.Text = "TCP Client";
            this.tabPageTCPClient.UseVisualStyleBackColor = true;
            // 
            // clientEnableTls
            // 
            this.clientEnableTls.AutoSize = true;
            this.clientEnableTls.Location = new System.Drawing.Point(20, 91);
            this.clientEnableTls.Margin = new System.Windows.Forms.Padding(4);
            this.clientEnableTls.Name = "clientEnableTls";
            this.clientEnableTls.Size = new System.Drawing.Size(104, 21);
            this.clientEnableTls.TabIndex = 9;
            this.clientEnableTls.Text = "Enable TLS";
            this.clientEnableTls.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(20, 53);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownPort.TabIndex = 7;
            this.numericUpDownPort.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Host";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(17, 20);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(90, 22);
            this.textBoxHost.TabIndex = 0;
            this.textBoxHost.Text = "127.0.0.1";
            // 
            // tabPageServer
            // 
            this.tabPageServer.Controls.Add(this.serverTLSOptionsControl);
            this.tabPageServer.Controls.Add(this.serverEnableTls);
            this.tabPageServer.Controls.Add(this.label12);
            this.tabPageServer.Controls.Add(this.numericUpDownServerPort);
            this.tabPageServer.Controls.Add(this.label13);
            this.tabPageServer.Controls.Add(this.textBoxServerHost);
            this.tabPageServer.Location = new System.Drawing.Point(4, 25);
            this.tabPageServer.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageServer.Size = new System.Drawing.Size(803, 330);
            this.tabPageServer.TabIndex = 1;
            this.tabPageServer.Text = "TCP Server";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // serverEnableTls
            // 
            this.serverEnableTls.AutoSize = true;
            this.serverEnableTls.Location = new System.Drawing.Point(17, 84);
            this.serverEnableTls.Margin = new System.Windows.Forms.Padding(4);
            this.serverEnableTls.Name = "serverEnableTls";
            this.serverEnableTls.Size = new System.Drawing.Size(104, 21);
            this.serverEnableTls.TabIndex = 13;
            this.serverEnableTls.Text = "Enable TLS";
            this.serverEnableTls.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Port";
            // 
            // numericUpDownServerPort
            // 
            this.numericUpDownServerPort.Location = new System.Drawing.Point(17, 54);
            this.numericUpDownServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownServerPort.Name = "numericUpDownServerPort";
            this.numericUpDownServerPort.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownServerPort.TabIndex = 11;
            this.numericUpDownServerPort.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bind To Adapter";
            // 
            // textBoxServerHost
            // 
            this.textBoxServerHost.Location = new System.Drawing.Point(17, 21);
            this.textBoxServerHost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServerHost.Name = "textBoxServerHost";
            this.textBoxServerHost.Size = new System.Drawing.Size(89, 22);
            this.textBoxServerHost.TabIndex = 9;
            this.textBoxServerHost.Text = "127.0.0.1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBoxFlowControl);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.comboBoxParity);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.comboBoxStopBits);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.numericUpDownDataBits);
            this.tabPage1.Controls.Add(this.numericUpDownBaud);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBoxSerialDeviceName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(803, 330);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Flow Control";
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Location = new System.Drawing.Point(332, 154);
            this.comboBoxFlowControl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(127, 24);
            this.comboBoxFlowControl.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Parity";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(332, 85);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(127, 24);
            this.comboBoxParity.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Stop Bits";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(332, 118);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(127, 24);
            this.comboBoxStopBits.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data Bits";
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.Location = new System.Drawing.Point(332, 48);
            this.numericUpDownDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDataBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDataBits.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(128, 22);
            this.numericUpDownDataBits.TabIndex = 17;
            this.numericUpDownDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownBaud
            // 
            this.numericUpDownBaud.Increment = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownBaud.Location = new System.Drawing.Point(332, 16);
            this.numericUpDownBaud.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownBaud.Maximum = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.numericUpDownBaud.Minimum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownBaud.Name = "numericUpDownBaud";
            this.numericUpDownBaud.Size = new System.Drawing.Size(128, 22);
            this.numericUpDownBaud.TabIndex = 16;
            this.numericUpDownBaud.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Port";
            // 
            // comboBoxSerialDeviceName
            // 
            this.comboBoxSerialDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialDeviceName.FormattingEnabled = true;
            this.comboBoxSerialDeviceName.Location = new System.Drawing.Point(35, 16);
            this.comboBoxSerialDeviceName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSerialDeviceName.Name = "comboBoxSerialDeviceName";
            this.comboBoxSerialDeviceName.Size = new System.Drawing.Size(171, 24);
            this.comboBoxSerialDeviceName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownMaxRetryMS);
            this.groupBox1.Controls.Add(this.numericUpDownMinRetryMS);
            this.groupBox1.Location = new System.Drawing.Point(19, 382);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(399, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alias";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(21, 34);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(116, 22);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.Text = "channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Retry (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min Retry (ms)";
            // 
            // numericUpDownMaxRetryMS
            // 
            this.numericUpDownMaxRetryMS.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownMaxRetryMS.Location = new System.Drawing.Point(21, 111);
            this.numericUpDownMaxRetryMS.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxRetryMS.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownMaxRetryMS.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMaxRetryMS.Name = "numericUpDownMaxRetryMS";
            this.numericUpDownMaxRetryMS.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownMaxRetryMS.TabIndex = 1;
            this.numericUpDownMaxRetryMS.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDownMinRetryMS
            // 
            this.numericUpDownMinRetryMS.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMinRetryMS.Location = new System.Drawing.Point(21, 73);
            this.numericUpDownMinRetryMS.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMinRetryMS.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownMinRetryMS.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMinRetryMS.Name = "numericUpDownMinRetryMS";
            this.numericUpDownMinRetryMS.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownMinRetryMS.TabIndex = 0;
            this.numericUpDownMinRetryMS.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 664);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(845, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logLevelControl1);
            this.groupBox2.Location = new System.Drawing.Point(425, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(399, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Certificates | *.crt; *.key";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // logLevelControl1
            // 
            this.logLevelControl1.Location = new System.Drawing.Point(63, 23);
            this.logLevelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.logLevelControl1.Name = "logLevelControl1";
            this.logLevelControl1.Size = new System.Drawing.Size(224, 130);
            this.logLevelControl1.TabIndex = 0;
            // 
            // clientTLSOptionsControl
            // 
            this.clientTLSOptionsControl.Location = new System.Drawing.Point(255, 0);
            this.clientTLSOptionsControl.Name = "clientTLSOptionsControl";
            this.clientTLSOptionsControl.Size = new System.Drawing.Size(527, 320);
            this.clientTLSOptionsControl.TabIndex = 10;
            // 
            // serverTLSOptionsControl
            // 
            this.serverTLSOptionsControl.Location = new System.Drawing.Point(255, 0);
            this.serverTLSOptionsControl.Name = "serverTLSOptionsControl";
            this.serverTLSOptionsControl.Size = new System.Drawing.Size(527, 320);
            this.serverTLSOptionsControl.TabIndex = 14;
            // 
            // ChannelDialog
            // 
            this.AcceptButton = this.buttonADD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(845, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControlChannelType);
            this.Controls.Add(this.groupBoxButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChannelDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add DNP3 Channel";
            this.TopMost = true;
            this.groupBoxButtons.ResumeLayout(false);
            this.tabControlChannelType.ResumeLayout(false);
            this.tabPageTCPClient.ResumeLayout(false);
            this.tabPageTCPClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.tabPageServer.ResumeLayout(false);
            this.tabPageServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServerPort)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRetryMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRetryMS)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TabControl tabControlChannelType;
        private System.Windows.Forms.TabPage tabPageTCPClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinRetryMS;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRetryMS;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private LogLevelControl logLevelControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxFlowControl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownDataBits;
        private System.Windows.Forms.NumericUpDown numericUpDownBaud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSerialDeviceName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownServerPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxServerHost;
        private System.Windows.Forms.CheckBox clientEnableTls;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox serverEnableTls;
        private TLSOptionsControl clientTLSOptionsControl;
        private TLSOptionsControl serverTLSOptionsControl;
    }
}