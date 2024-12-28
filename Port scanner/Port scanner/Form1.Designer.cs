namespace Port_scanner
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSingleIP = new System.Windows.Forms.CheckBox();
            this.txtIPEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSinglePort = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortEnd = new System.Windows.Forms.TextBox();
            this.txtPortStart = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtThreadNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkPort80 = new System.Windows.Forms.CheckBox();
            this.chkPort443 = new System.Windows.Forms.CheckBox();
            this.chkPort8000 = new System.Windows.Forms.CheckBox();
            this.chkPort8080 = new System.Windows.Forms.CheckBox();
            this.chkPort135 = new System.Windows.Forms.CheckBox();
            this.chkPort445 = new System.Windows.Forms.CheckBox();
            this.chkPort1025 = new System.Windows.Forms.CheckBox();
            this.chkPort1080 = new System.Windows.Forms.CheckBox();
            this.chkPort21 = new System.Windows.Forms.CheckBox();
            this.chkPort22 = new System.Windows.Forms.CheckBox();
            this.chkPort23 = new System.Windows.Forms.CheckBox();
            this.chkPort69 = new System.Windows.Forms.CheckBox();
            this.chkPort25 = new System.Windows.Forms.CheckBox();
            this.chkPort110 = new System.Windows.Forms.CheckBox();
            this.chkPort993 = new System.Windows.Forms.CheckBox();
            this.chkPort996 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSingleIP);
            this.groupBox1.Controls.Add(this.txtIPEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkSingleIP
            // 
            this.chkSingleIP.AutoSize = true;
            this.chkSingleIP.Location = new System.Drawing.Point(33, 70);
            this.chkSingleIP.Name = "chkSingleIP";
            this.chkSingleIP.Size = new System.Drawing.Size(96, 16);
            this.chkSingleIP.TabIndex = 4;
            this.chkSingleIP.Text = "扫描单个主机";
            this.chkSingleIP.UseVisualStyleBackColor = true;
            this.chkSingleIP.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtIPEnd
            // 
            this.txtIPEnd.Location = new System.Drawing.Point(34, 43);
            this.txtIPEnd.Name = "txtIPEnd";
            this.txtIPEnd.Size = new System.Drawing.Size(128, 21);
            this.txtIPEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // txtIPStart
            // 
            this.txtIPStart.Location = new System.Drawing.Point(34, 17);
            this.txtIPStart.Name = "txtIPStart";
            this.txtIPStart.Size = new System.Drawing.Size(128, 21);
            this.txtIPStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSinglePort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPortEnd);
            this.groupBox2.Controls.Add(this.txtPortStart);
            this.groupBox2.Location = new System.Drawing.Point(5, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扫描端口列表";
            // 
            // chkSinglePort
            // 
            this.chkSinglePort.AutoSize = true;
            this.chkSinglePort.Location = new System.Drawing.Point(6, 44);
            this.chkSinglePort.Name = "chkSinglePort";
            this.chkSinglePort.Size = new System.Drawing.Size(96, 16);
            this.chkSinglePort.TabIndex = 3;
            this.chkSinglePort.Text = "扫描单个端口";
            this.chkSinglePort.UseVisualStyleBackColor = true;
            this.chkSinglePort.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // txtPortEnd
            // 
            this.txtPortEnd.Location = new System.Drawing.Point(99, 17);
            this.txtPortEnd.Name = "txtPortEnd";
            this.txtPortEnd.Size = new System.Drawing.Size(65, 21);
            this.txtPortEnd.TabIndex = 1;
            this.txtPortEnd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPortStart
            // 
            this.txtPortStart.Location = new System.Drawing.Point(6, 17);
            this.txtPortStart.Name = "txtPortStart";
            this.txtPortStart.Size = new System.Drawing.Size(63, 21);
            this.txtPortStart.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtThreadNumber);
            this.groupBox3.Location = new System.Drawing.Point(20, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分配线程数";
            // 
            // txtThreadNumber
            // 
            this.txtThreadNumber.Location = new System.Drawing.Point(31, 20);
            this.txtThreadNumber.Name = "txtThreadNumber";
            this.txtThreadNumber.Size = new System.Drawing.Size(100, 21);
            this.txtThreadNumber.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(187, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 409);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扫描结果";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 67);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 280);
            this.listBox1.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "只显示开放端口";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.trackBar1);
            this.groupBox5.Location = new System.Drawing.Point(20, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 110);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "设置超时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "超时值(ms):";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(73, 21);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "10";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(26, 27);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(124, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 21);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Location = new System.Drawing.Point(187, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(581, 41);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "扫描进度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(170, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "开始";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "停止";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "关于";
            // 
            // button3
            // 
            this.button3.Image = global::Port_scanner.Properties.Resources.about;
            this.button3.Location = new System.Drawing.Point(135, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 52);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Port_scanner.Properties.Resources.stop;
            this.button2.Location = new System.Drawing.Point(73, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 52);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Stop_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::Port_scanner.Properties.Resources.start;
            this.button1.Location = new System.Drawing.Point(14, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Start_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.flowLayoutPanel1);
            this.groupBox7.Location = new System.Drawing.Point(193, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(575, 65);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "常见端口";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkPort80);
            this.flowLayoutPanel1.Controls.Add(this.chkPort443);
            this.flowLayoutPanel1.Controls.Add(this.chkPort8000);
            this.flowLayoutPanel1.Controls.Add(this.chkPort8080);
            this.flowLayoutPanel1.Controls.Add(this.chkPort135);
            this.flowLayoutPanel1.Controls.Add(this.chkPort445);
            this.flowLayoutPanel1.Controls.Add(this.chkPort1025);
            this.flowLayoutPanel1.Controls.Add(this.chkPort1080);
            this.flowLayoutPanel1.Controls.Add(this.chkPort21);
            this.flowLayoutPanel1.Controls.Add(this.chkPort22);
            this.flowLayoutPanel1.Controls.Add(this.chkPort23);
            this.flowLayoutPanel1.Controls.Add(this.chkPort69);
            this.flowLayoutPanel1.Controls.Add(this.chkPort25);
            this.flowLayoutPanel1.Controls.Add(this.chkPort110);
            this.flowLayoutPanel1.Controls.Add(this.chkPort993);
            this.flowLayoutPanel1.Controls.Add(this.chkPort996);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(569, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkPort80
            // 
            this.chkPort80.AutoSize = true;
            this.chkPort80.Location = new System.Drawing.Point(3, 3);
            this.chkPort80.Name = "chkPort80";
            this.chkPort80.Size = new System.Drawing.Size(36, 16);
            this.chkPort80.TabIndex = 0;
            this.chkPort80.Text = "80";
            this.chkPort80.UseVisualStyleBackColor = true;
            // 
            // chkPort443
            // 
            this.chkPort443.AutoSize = true;
            this.chkPort443.Location = new System.Drawing.Point(45, 3);
            this.chkPort443.Name = "chkPort443";
            this.chkPort443.Size = new System.Drawing.Size(42, 16);
            this.chkPort443.TabIndex = 1;
            this.chkPort443.Text = "443";
            this.chkPort443.UseVisualStyleBackColor = true;
            // 
            // chkPort8000
            // 
            this.chkPort8000.AutoSize = true;
            this.chkPort8000.Location = new System.Drawing.Point(93, 3);
            this.chkPort8000.Name = "chkPort8000";
            this.chkPort8000.Size = new System.Drawing.Size(48, 16);
            this.chkPort8000.TabIndex = 2;
            this.chkPort8000.Text = "8000";
            this.chkPort8000.UseVisualStyleBackColor = true;
            // 
            // chkPort8080
            // 
            this.chkPort8080.AutoSize = true;
            this.chkPort8080.Location = new System.Drawing.Point(147, 3);
            this.chkPort8080.Name = "chkPort8080";
            this.chkPort8080.Size = new System.Drawing.Size(48, 16);
            this.chkPort8080.TabIndex = 3;
            this.chkPort8080.Text = "8080";
            this.chkPort8080.UseVisualStyleBackColor = true;
            // 
            // chkPort135
            // 
            this.chkPort135.AutoSize = true;
            this.chkPort135.Location = new System.Drawing.Point(201, 3);
            this.chkPort135.Name = "chkPort135";
            this.chkPort135.Size = new System.Drawing.Size(42, 16);
            this.chkPort135.TabIndex = 4;
            this.chkPort135.Text = "135";
            this.chkPort135.UseVisualStyleBackColor = true;
            // 
            // chkPort445
            // 
            this.chkPort445.AutoSize = true;
            this.chkPort445.Location = new System.Drawing.Point(249, 3);
            this.chkPort445.Name = "chkPort445";
            this.chkPort445.Size = new System.Drawing.Size(42, 16);
            this.chkPort445.TabIndex = 5;
            this.chkPort445.Text = "445";
            this.chkPort445.UseVisualStyleBackColor = true;
            // 
            // chkPort1025
            // 
            this.chkPort1025.AutoSize = true;
            this.chkPort1025.Location = new System.Drawing.Point(297, 3);
            this.chkPort1025.Name = "chkPort1025";
            this.chkPort1025.Size = new System.Drawing.Size(48, 16);
            this.chkPort1025.TabIndex = 6;
            this.chkPort1025.Text = "1025";
            this.chkPort1025.UseVisualStyleBackColor = true;
            // 
            // chkPort1080
            // 
            this.chkPort1080.AutoSize = true;
            this.chkPort1080.Location = new System.Drawing.Point(351, 3);
            this.chkPort1080.Name = "chkPort1080";
            this.chkPort1080.Size = new System.Drawing.Size(48, 16);
            this.chkPort1080.TabIndex = 7;
            this.chkPort1080.Text = "1080";
            this.chkPort1080.UseVisualStyleBackColor = true;
            // 
            // chkPort21
            // 
            this.chkPort21.AutoSize = true;
            this.chkPort21.Location = new System.Drawing.Point(405, 3);
            this.chkPort21.Name = "chkPort21";
            this.chkPort21.Size = new System.Drawing.Size(36, 16);
            this.chkPort21.TabIndex = 8;
            this.chkPort21.Text = "21";
            this.chkPort21.UseVisualStyleBackColor = true;
            // 
            // chkPort22
            // 
            this.chkPort22.AutoSize = true;
            this.chkPort22.Location = new System.Drawing.Point(447, 3);
            this.chkPort22.Name = "chkPort22";
            this.chkPort22.Size = new System.Drawing.Size(36, 16);
            this.chkPort22.TabIndex = 9;
            this.chkPort22.Text = "22";
            this.chkPort22.UseVisualStyleBackColor = true;
            // 
            // chkPort23
            // 
            this.chkPort23.AutoSize = true;
            this.chkPort23.Location = new System.Drawing.Point(489, 3);
            this.chkPort23.Name = "chkPort23";
            this.chkPort23.Size = new System.Drawing.Size(36, 16);
            this.chkPort23.TabIndex = 10;
            this.chkPort23.Text = "23";
            this.chkPort23.UseVisualStyleBackColor = true;
            // 
            // chkPort69
            // 
            this.chkPort69.AutoSize = true;
            this.chkPort69.Location = new System.Drawing.Point(3, 25);
            this.chkPort69.Name = "chkPort69";
            this.chkPort69.Size = new System.Drawing.Size(36, 16);
            this.chkPort69.TabIndex = 11;
            this.chkPort69.Text = "69";
            this.chkPort69.UseVisualStyleBackColor = true;
            // 
            // chkPort25
            // 
            this.chkPort25.AutoSize = true;
            this.chkPort25.Location = new System.Drawing.Point(45, 25);
            this.chkPort25.Name = "chkPort25";
            this.chkPort25.Size = new System.Drawing.Size(36, 16);
            this.chkPort25.TabIndex = 12;
            this.chkPort25.Text = "25";
            this.chkPort25.UseVisualStyleBackColor = true;
            // 
            // chkPort110
            // 
            this.chkPort110.AutoSize = true;
            this.chkPort110.Location = new System.Drawing.Point(87, 25);
            this.chkPort110.Name = "chkPort110";
            this.chkPort110.Size = new System.Drawing.Size(42, 16);
            this.chkPort110.TabIndex = 13;
            this.chkPort110.Text = "110";
            this.chkPort110.UseVisualStyleBackColor = true;
            // 
            // chkPort993
            // 
            this.chkPort993.AutoSize = true;
            this.chkPort993.Location = new System.Drawing.Point(135, 25);
            this.chkPort993.Name = "chkPort993";
            this.chkPort993.Size = new System.Drawing.Size(42, 16);
            this.chkPort993.TabIndex = 14;
            this.chkPort993.Text = "993";
            this.chkPort993.UseVisualStyleBackColor = true;
            // 
            // chkPort996
            // 
            this.chkPort996.AutoSize = true;
            this.chkPort996.Location = new System.Drawing.Point(183, 25);
            this.chkPort996.Name = "chkPort996";
            this.chkPort996.Size = new System.Drawing.Size(42, 16);
            this.chkPort996.TabIndex = 15;
            this.chkPort996.Text = "996";
            this.chkPort996.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 542);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "端口扫描器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIPEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortEnd;
        private System.Windows.Forms.TextBox txtPortStart;
        private System.Windows.Forms.TextBox txtThreadNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkSingleIP;
        private System.Windows.Forms.CheckBox chkSinglePort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkPort80;
        private System.Windows.Forms.CheckBox chkPort443;
        private System.Windows.Forms.CheckBox chkPort8000;
        private System.Windows.Forms.CheckBox chkPort8080;
        private System.Windows.Forms.CheckBox chkPort135;
        private System.Windows.Forms.CheckBox chkPort445;
        private System.Windows.Forms.CheckBox chkPort1025;
        private System.Windows.Forms.CheckBox chkPort1080;
        private System.Windows.Forms.CheckBox chkPort21;
        private System.Windows.Forms.CheckBox chkPort22;
        private System.Windows.Forms.CheckBox chkPort23;
        private System.Windows.Forms.CheckBox chkPort69;
        private System.Windows.Forms.CheckBox chkPort25;
        private System.Windows.Forms.CheckBox chkPort110;
        private System.Windows.Forms.CheckBox chkPort993;
        private System.Windows.Forms.CheckBox chkPort996;
    }
}

