namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gpboxFTS = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtnFile = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnFolder = new System.Windows.Forms.RadioButton();
            this.cmbTimeUnit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxTimeInterval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxLocal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpboxAutoStart = new System.Windows.Forms.GroupBox();
            this.chboxAutoStart = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnAutoDeleteYes = new System.Windows.Forms.RadioButton();
            this.rbtnAutoDeleteNo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpboxFTS.SuspendLayout();
            this.gpboxAutoStart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(362, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "BACKUP";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup Client File to FTP Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gpboxFTS);
            this.groupBox1.Controls.Add(this.cmbTimeUnit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbxTimeInterval);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbxLocal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbxServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbxPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbxUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gpboxAutoStart);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 374);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Auto Delete";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(417, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 193);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 135);
            this.label16.TabIndex = 40;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Note:";
            // 
            // gpboxFTS
            // 
            this.gpboxFTS.Controls.Add(this.label14);
            this.gpboxFTS.Controls.Add(this.rbtnFile);
            this.gpboxFTS.Controls.Add(this.rbtnAll);
            this.gpboxFTS.Controls.Add(this.rbtnFolder);
            this.gpboxFTS.Location = new System.Drawing.Point(416, 28);
            this.gpboxFTS.Name = "gpboxFTS";
            this.gpboxFTS.Size = new System.Drawing.Size(226, 129);
            this.gpboxFTS.TabIndex = 37;
            this.gpboxFTS.TabStop = false;
            this.gpboxFTS.Paint += new System.Windows.Forms.PaintEventHandler(this.gpboxFTS_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, -3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "File to Send";
            // 
            // rbtnFile
            // 
            this.rbtnFile.AutoSize = true;
            this.rbtnFile.Checked = true;
            this.rbtnFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFile.Location = new System.Drawing.Point(28, 28);
            this.rbtnFile.Name = "rbtnFile";
            this.rbtnFile.Size = new System.Drawing.Size(183, 21);
            this.rbtnFile.TabIndex = 38;
            this.rbtnFile.TabStop = true;
            this.rbtnFile.Text = "Files (Inside the directory)";
            this.rbtnFile.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAll.Location = new System.Drawing.Point(28, 90);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(153, 21);
            this.rbtnAll.TabIndex = 37;
            this.rbtnAll.Text = "Both (File and folder)";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnFolder
            // 
            this.rbtnFolder.AutoSize = true;
            this.rbtnFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFolder.Location = new System.Drawing.Point(28, 59);
            this.rbtnFolder.Name = "rbtnFolder";
            this.rbtnFolder.Size = new System.Drawing.Size(202, 21);
            this.rbtnFolder.TabIndex = 36;
            this.rbtnFolder.Text = "Folders (Files inside included)";
            this.rbtnFolder.UseVisualStyleBackColor = true;
            // 
            // cmbTimeUnit
            // 
            this.cmbTimeUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeUnit.FormattingEnabled = true;
            this.cmbTimeUnit.Items.AddRange(new object[] {
            "Minute",
            "Hour"});
            this.cmbTimeUnit.Location = new System.Drawing.Point(161, 269);
            this.cmbTimeUnit.Name = "cmbTimeUnit";
            this.cmbTimeUnit.Size = new System.Drawing.Size(230, 25);
            this.cmbTimeUnit.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Auto Start";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Run Every ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Backup Schedule";
            // 
            // txtbxTimeInterval
            // 
            this.txtbxTimeInterval.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTimeInterval.Location = new System.Drawing.Point(161, 242);
            this.txtbxTimeInterval.Name = "txtbxTimeInterval";
            this.txtbxTimeInterval.Size = new System.Drawing.Size(230, 25);
            this.txtbxTimeInterval.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Time Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Local Client (This PC)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "FTP Server";
            // 
            // txtbxLocal
            // 
            this.txtbxLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLocal.Location = new System.Drawing.Point(161, 172);
            this.txtbxLocal.Name = "txtbxLocal";
            this.txtbxLocal.Size = new System.Drawing.Size(230, 25);
            this.txtbxLocal.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Local Directory";
            // 
            // txtbxServer
            // 
            this.txtbxServer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxServer.Location = new System.Drawing.Point(161, 105);
            this.txtbxServer.Name = "txtbxServer";
            this.txtbxServer.Size = new System.Drawing.Size(230, 25);
            this.txtbxServer.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtbxServer, "IP or hostname of the server followed by the directory");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server Directory";
            // 
            // txtbxPass
            // 
            this.txtbxPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPass.Location = new System.Drawing.Point(161, 79);
            this.txtbxPass.Name = "txtbxPass";
            this.txtbxPass.Size = new System.Drawing.Size(230, 25);
            this.txtbxPass.TabIndex = 8;
            this.txtbxPass.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // txtbxUser
            // 
            this.txtbxUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUser.Location = new System.Drawing.Point(161, 53);
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(230, 25);
            this.txtbxUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // gpboxAutoStart
            // 
            this.gpboxAutoStart.Controls.Add(this.chboxAutoStart);
            this.gpboxAutoStart.Controls.Add(this.radioButton3);
            this.gpboxAutoStart.Location = new System.Drawing.Point(145, 265);
            this.gpboxAutoStart.Name = "gpboxAutoStart";
            this.gpboxAutoStart.Size = new System.Drawing.Size(230, 59);
            this.gpboxAutoStart.TabIndex = 36;
            this.gpboxAutoStart.TabStop = false;
            this.gpboxAutoStart.Paint += new System.Windows.Forms.PaintEventHandler(this.gpboxAutoStart_Paint);
            // 
            // chboxAutoStart
            // 
            this.chboxAutoStart.AutoSize = true;
            this.chboxAutoStart.Location = new System.Drawing.Point(16, 29);
            this.chboxAutoStart.Name = "chboxAutoStart";
            this.chboxAutoStart.Size = new System.Drawing.Size(52, 25);
            this.chboxAutoStart.TabIndex = 38;
            this.chboxAutoStart.Text = "Yes";
            this.chboxAutoStart.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(75, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 25);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(272, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(362, 426);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 32);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(272, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(512, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 21);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "label12";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 89);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(14, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 29;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 508);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(473, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Timer (Remaining Time)";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(453, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 30;
            this.button2.Text = "FORCE BACKUP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnAutoDeleteYes);
            this.groupBox4.Controls.Add(this.rbtnAutoDeleteNo);
            this.groupBox4.Location = new System.Drawing.Point(142, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 35);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox4_Paint);
            // 
            // rbtnAutoDeleteYes
            // 
            this.rbtnAutoDeleteYes.AutoSize = true;
            this.rbtnAutoDeleteYes.Location = new System.Drawing.Point(19, 13);
            this.rbtnAutoDeleteYes.Name = "rbtnAutoDeleteYes";
            this.rbtnAutoDeleteYes.Size = new System.Drawing.Size(52, 25);
            this.rbtnAutoDeleteYes.TabIndex = 38;
            this.rbtnAutoDeleteYes.Text = "Yes";
            this.rbtnAutoDeleteYes.UseVisualStyleBackColor = true;
            // 
            // rbtnAutoDeleteNo
            // 
            this.rbtnAutoDeleteNo.AutoSize = true;
            this.rbtnAutoDeleteNo.Checked = true;
            this.rbtnAutoDeleteNo.Location = new System.Drawing.Point(78, 13);
            this.rbtnAutoDeleteNo.Name = "rbtnAutoDeleteNo";
            this.rbtnAutoDeleteNo.Size = new System.Drawing.Size(50, 25);
            this.rbtnAutoDeleteNo.TabIndex = 37;
            this.rbtnAutoDeleteNo.TabStop = true;
            this.rbtnAutoDeleteNo.Text = "No";
            this.rbtnAutoDeleteNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(693, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpboxFTS.ResumeLayout(false);
            this.gpboxFTS.PerformLayout();
            this.gpboxAutoStart.ResumeLayout(false);
            this.gpboxAutoStart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTimeUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbxTimeInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gpboxAutoStart;
        private System.Windows.Forms.RadioButton chboxAutoStart;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpboxFTS;
        private System.Windows.Forms.RadioButton rbtnFile;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnFolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnAutoDeleteYes;
        private System.Windows.Forms.RadioButton rbtnAutoDeleteNo;
    }
}

