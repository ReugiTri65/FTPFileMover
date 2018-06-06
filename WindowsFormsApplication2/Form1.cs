using FTPFileMover;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Project References:
//https://www.codeproject.com/Tips/443588/Simple-Csharp-FTP-Class
//https://stackoverflow.com/questions/16620234/how-to-do-a-30-minute-count-down-timer
//https://forums.asp.net/t/1757459.aspx?upload+all+files+and+folders+using+c+


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        //Variables
        static FtpWebRequest reqFTP;
        static FileInfo fileInf;
        //static string ftpServerIP = "192.168.1.2";
        //static string ftpUserID = "Tekno3";
        //static string ftpPassword = "admin";
        //static string serverUri = "192.168.1.2" + "/New folder/";
        //static string localUri = "C:/Users/Tekno3/Desktop/Sample/";

        static string ftpUserID;
        static string ftpPassword;
        static string serverUri;
        static string localUri;

        string fileToCreate;

        static int timerDuration;
        static int timerCount; //Should be in milisecond
        static string timeUnit;
        static string autoStartStatus;
        static string autoDeleteStatus;

        static int ctr = 0;
        static string FTS;
        Thread thread;

        static int catchStatus = 0;
        static NetworkCredential credentials = new NetworkCredential(ftpUserID, ftpPassword);


        #region CONFIGURATION
        public static void ReadTerminalPort()
        {
            try
            {
                // Read each line of the file into a string array. Each element 
                // of the array is one line of the file. 
                string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\TerminalConfig.dat");

                // Display the file contents by using a foreach loop.
                foreach (string line in lines)
                {
                    ftpUserID = lines[1];
                    ftpPassword = lines[2];
                    serverUri = ReverseSlash(lines[3]);
                    localUri = ReverseSlash(lines[4]);
                    timerDuration = Convert.ToInt32(lines[5]);
                    timeUnit = lines[6];
                    autoStartStatus = lines[7];
                    FTS = lines[8];
                    autoDeleteStatus = lines[9];

                }
            }
            catch { }
        }


        public static string ReverseSlash(string input)
        {
            input = input.Replace("\\", "/");
            //Console.WriteLine(t);
          //  MessageBox.Show(input);
            return input;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            //Reades the TerminalConfig.dat file
            ReadTerminalPort();

            //backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            //backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            //backgroundWorker1.WorkerReportsProgress = true;

            //BackgroundWorker BG = new BackgroundWorker();
            //BG.DoWork += new DoWorkEventHandler(BG_DoWork);

            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;

            //ReverseSlash("C:\\Users\\Tekno3\\Documents\\Visual Studio 2015\\Projects\\05-31-18v1 FTPFileMover\\WindowsFormsApplication2\\bin\\Debug");

            thread = new Thread(startMove);

        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbxUser.Text = ftpUserID;
            txtbxPass.Text = ftpPassword;
            txtbxServer.Text = serverUri;
            txtbxLocal.Text = localUri;
            txtbxTimeInterval.Text = timerDuration.ToString();

            //if (cmbTimeUnit.Text == "Minute")
            if (timeUnit == ("Minute"))
            {
                cmbTimeUnit.SelectedIndex = 0;
                timerCount = (timerDuration * 60) * 1000;
            }
            else if (timeUnit == ("Hour"))
            {
                cmbTimeUnit.SelectedIndex = 1;
                timerCount = ((timerDuration * 60) * 60) * 1000;
            }
            if(FTS == "1")
            {
                rbtnFile.Checked = true;
            }
            else if (FTS == "2")
            {
                rbtnFolder.Checked = true;
            }
            else if (FTS == "3")
            {
                rbtnAll.Checked = true;
            }
            else
            {

            }
            if (autoDeleteStatus == "1")
            {
                rbtnAutoDeleteYes.Checked = true;
            }
            else
            {
                rbtnAutoDeleteNo.Checked = true;
            }

            if (autoStartStatus.Equals("ON", StringComparison.OrdinalIgnoreCase))
            {
                chboxAutoStart.Checked = true;
                timer1.Enabled = true;
                /////////////////////////////////////////////////////////////////////////////////
                btnStart.Visible = false;
                //btnStop.Visible = true;
                btnStart.Enabled = false;
                //startMove();
            }
            else if (autoStartStatus.Equals("OFF", StringComparison.OrdinalIgnoreCase))
            {
                chboxAutoStart.Checked = false;
                //timer1.Enabled = false;
                lblTimer.Text = "Disabled";
            }
            else
            {
                chboxAutoStart.Checked = false;
                //              timer1.Enabled = false;
            }

            //For Debugging purpose
            //string[] contents = File.ReadAllLines("TerminalConfig.dat");
            //if (contents != null)
            //{
            //    foreach (string content in contents)
            //    {
            //        MessageBox.Show(content);

            //     }
            //}

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                BackupFiles();
                //if (chboxAutoStart.Checked)
                //{
                btnStart.Visible = false;
                btnStop.Visible = true;
                //}
                //else
                //{
                //    btnStart.Enabled = false;
                //}

                if (btnEdit.Visible == false)
                {
                    btnStart.Enabled = true;
                    MessageBox.Show("Cannot Start when editing configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnStop.Visible = true;
                //startMove();
                //   Thread.Sleep(5000);
                if (chboxAutoStart.Checked)
                {
                    //Console.WriteLine(lblTimer.Text);
                    //if (lblTimer.Text == "Remaing Time: 00:00:01")
                    //{
                    if (timeUnit == ("Minute"))
                    {
                        cmbTimeUnit.SelectedIndex = 0;
                        timerCount = (timerDuration * 60) * 1000;
                    }
                    else if (timeUnit == ("Hour"))
                    {
                        cmbTimeUnit.SelectedIndex = 1;
                        timerCount = ((timerDuration * 60) * 60) * 1000;
                    }
                    timer1.Enabled = true;
                    timer1.Start();

                    if (thread.IsAlive)
                    {
                        thread.Resume();
                    }
                    else
                    {
                        thread = new Thread(startMove);
                        thread.Start();
                    }

                    ////////////////
                    //startMove();

                    //   thread.Abort();

                    //chkbxAutoStart.Checked = true;
                    //timer1.Enabled = true;
                    //startMove();
                    //btnStart.Visible = false;
                    //btnStop.Visible = true;
                    //}
                }
                else
                {
                    //btnStart.Visible = false;
                    //btnStop.Visible = true;

                    //btnStart.Enabled = false;

                    if (thread.IsAlive)
                    {
                        thread.Resume();
                    }
                    else
                    {
                        thread = new Thread(startMove);
                        thread.Start();
                    }
                    //thread.Suspend();
                    //      thread.Abort();
                    ////////////////////////////
                    //startMove();
                }
            }
                //Thread.Sleep(5000);
                //lblMessage.Text = "";
            }
            catch (Exception eeee)
            { }
        }
        static string[] files;

        public void startMove()
        {
            try
            {
                if (rbtnFolder.Checked)
                {
                    IncludeFolders();
                }
                else if (rbtnAll.Checked)
                {
                    PassFiles(localUri, "");
                    IncludeFolders();
                }
                else
                {
                    PassFiles(localUri, "");
                }

                if (catchStatus == 0)
                {
                    this.Invoke((MethodInvoker)delegate() { lblMessage.Text = "Done passing files \n" + ctr + " files passed"; });
                    using (StreamWriter stream = new FileInfo("logfile.txt").AppendText())
                    {
                        stream.WriteLine(DateTime.Now + " " + ctr.ToString() + " files passed");
                    }
                    this.Invoke((MethodInvoker)delegate() { btnStart.Visible = true;});
                    this.Invoke((MethodInvoker)delegate() { btnStop.Visible = false; });
                }
                else
                {

                }

                ctr = 0;
                //lblMessage.Text = "Tranferring files done!";         

                if (!chboxAutoStart.Checked)
                {
                    this.Invoke((MethodInvoker)delegate () {   btnStart.Enabled = true;  });
                    this.Invoke((MethodInvoker)delegate() { btnStart.Visible = true; });
                    this.Invoke((MethodInvoker)delegate() { btnStop.Visible = false; });
            }
   

                //   }
                //    lblTimer.Text = "Auto-Start not Enabled";               
            }
            catch (Exception eee)
            {
                //this.Invoke((MethodInvoker)delegate () { lblMessage.Text = eee.Message; });
                //lblMessage.Text = eee.Message;
                btnStart.Enabled = true;
            }

        } 

        public void IncludeFolders()
        {
            //backgroundWorker1.RunWorkerAsync();
            try
            {
                string sourceDirectory = "";
                sourceDirectory = localUri;
                string destinationPath = "";
                destinationPath = serverUri;
                long totalSize = 0;
                string lastModified = "";
                DateTime CompareDate = DateTime.Now.AddDays(-30);
                string[] folderNames = Directory.GetDirectories(sourceDirectory, "*.*", SearchOption.AllDirectories);
                foreach (string fn in folderNames)
                {
                    string str;
                    DirectoryInfo d;
                    str = new DirectoryInfo(fn).Name;
                    Console.WriteLine(fileToCreate);
                    Console.WriteLine(str);
                    Console.WriteLine(fileToCreate);
                    fileToCreate = "ftp://" + serverUri + str + "/";
                    Console.WriteLine(fileToCreate);

                    // Create FtpWebRequest object from the Uri provided
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(fileToCreate));

                    // Provide the WebPermission Credintials
                    reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                    //reqFTP.UsePassive = true;
                    //reqFTP.UseBinary = true;
                    //reqFTP.KeepAlive = false;
                    reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;

                    // Step 3 - Call GetResponse() method to actually attempt to create the directory
                    try
                    {
                        FtpWebResponse makeDirectoryResponse = (FtpWebResponse)reqFTP.GetResponse();
                    }
                    catch (WebException e)
                    {
                        String status = ((FtpWebResponse)e.Response).StatusDescription;
                    }
                    catch (Exception eeee)
                    { }
                    //////////////////////////////////////////////
                    PassFiles(fn, str);

                    if (rbtnAutoDeleteYes.Checked)
                    {
                        Directory.Delete(fn + "/", true);
                    }
                    //Console.WriteLine(fn + "/");
                }
            }
            catch (Exception eee)
            {

            }

        //   
            //DeleteFtpDirectory(localUri);
        }

        public void PassFiles(string fn,string str)
        {
            try
            {
          //      files = new string[] { };
                if (rbtnFolder.Checked || rbtnAll.Checked)
                {
                    str = str + "/";
                    files = Directory.GetFiles(fn + "/", @"*.*");
                }
                else
                {
                    files = Directory.GetFiles(fn, @"*.*");
                }

                if (files != null || files.Length < 0)
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine(ctr.ToString());
                        fileInf = new FileInfo(file);
                        fileToCreate = "ftp://" + serverUri + str + fileInf.Name;
                        // Create FtpWebRequest object from the Uri provided
                        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(fileToCreate));
                        // Provide the WebPermission Credintials
                        reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                        // By default KeepAlive is true, where the control connection is not closed
                        // after a command is executed.
                        reqFTP.KeepAlive = false;
                        // Specify the command to be executed.
                        reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                        // Specify the data transfer type.
                        reqFTP.UseBinary = true;
                        // Notify the server about the size of the uploaded file
                        reqFTP.ContentLength = fileInf.Length;
                        int buffLength = 524288;
                        //int buffLength = 5000;
                        byte[] buff = new byte[buffLength];
                        int contentLen;

                        // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
                        FileStream fs = fileInf.OpenRead();
                        try
                        {
                            // Stream to which the file to be upload is written
                            Stream strm = reqFTP.GetRequestStream();
                            // Read from the file stream 2kb at a time
                            contentLen = fs.Read(buff, 0, buffLength);
                            // Until Stream content ends
                            while (contentLen != 0)

                            {
                                // Write Content from the file stream to the FTP Upload Stream
                                strm.Write(buff, 0, contentLen);
                                contentLen = fs.Read(buff, 0, buffLength);
                                //////////////                      backgroundWorker1_DoWork;
                            }
                            // Close the file stream and the Request Stream
                            strm.Close();
                            fs.Close();
                            /////////////////////////////////////////////////////////////////////
                            //Deletes file after creating/copying in the server
                            if (rbtnAutoDeleteYes.Checked)
                            {
                                deleteFile();
                            }
                            ctr++;
                        }
                        catch (WebException e)
                        {
                            String status = ((FtpWebResponse)e.Response).StatusDescription;
                        }
                        catch (Exception ex)
                        {
                            //startMove();
                            if (ex.HResult == -2146233079)
                            {
                              //  this.Invoke((MethodInvoker)delegate() { lblMessage.Text = "Invalid username and password"; });
                                
                                catchStatus = 1;
                                break;
                             
                            }
                        }
                    }
                }
            }
            catch(Exception eeee)
            {
               // lblMessage.Text = eeee.Message;
              //  btnStart.Enabled = true;
            }
            //lblMessage.Text = "";
            
        }



        public void deleteFile()
        {
            try
            {
                string fileToDelete = localUri + fileInf.Name;
                if (File.Exists(@"" + fileToDelete))
                {
                    File.Delete(@"" + fileToDelete);
                }
                else
                {
                    //dapat magrun ulit dito yung program instead of eror message
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString()); 
            }
            return;
        }

        static void DeleteFtpDirectory(string url)
        {
            //Directory.Delete(path, true);
        }

        void DeleteFtpDirectory(string url, NetworkCredential credentials)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                request.Credentials = credentials;
                request.GetResponse().Close();
            }
            catch (Exception eee)
            {

            }

        }

        //  public void DeleteFile(string path)
        //  {
        //      FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);

        //      request.Method = WebRequestMethods.Ftp.DeleteFile;
        //      request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        //      request.Proxy = null;

        //      FtpWebResponse response = (FtpWebResponse)request.GetResponse();

        ////      PostEvent($"Deleting file {path} returned status {response.StatusDescription}", Debug);

        //      response.Close();
        //  }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Timer stopped!";
            if (btnStart.Visible == false)
            {
                MessageBox.Show("Cannot configure application while passing files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                groupBox1.Enabled = true;
                btnEdit.Visible = false;
                btnSave.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            int lineNo = 1;

            try
            {
                if (chboxAutoStart.Checked)
                {
                    autoStartStatus = "ON";
                }
                else
                {
                    autoStartStatus = "OFF";
                }
                if (timeUnit == ("Minute"))
                {
                    cmbTimeUnit.SelectedIndex = 0;
                }
                else if (timeUnit == ("Hour"))
                {
                    cmbTimeUnit.SelectedIndex = 1;
                }
                if (rbtnFile.Checked)
                {
                    FTS = "1";
                }
                else if (rbtnFolder.Checked)
                {
                    FTS = "2";
                }
                else if (rbtnAll.Checked)
                {
                    FTS = "3";
                }
                if (rbtnAutoDeleteYes.Checked)
                {
                    autoDeleteStatus = "1";
                }
                else
                {
                    autoDeleteStatus = "2";
                }

                // string path = File.ReadLines("TerminalConfig.dat");
                //   string path = @"\TerminalConfig.dat";
                string[] lines = File.ReadAllLines("TerminalConfig.dat");
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\TerminalConfig.dat";

                string createText
                    = "~~TerminalConfig~~"
                    + Environment.NewLine
                    + txtbxUser.Text
                    + Environment.NewLine
                    + txtbxPass.Text
                    + Environment.NewLine
                    + txtbxServer.Text
                    + Environment.NewLine
                    + txtbxLocal.Text
                    + Environment.NewLine
                    + txtbxTimeInterval.Text
                    + Environment.NewLine
                    + cmbTimeUnit.SelectedItem
                    + Environment.NewLine
                    + autoStartStatus
                    + Environment.NewLine
                    + FTS
                    + Environment.NewLine
                    + autoDeleteStatus
                    + Environment.NewLine
                        ;

                File.WriteAllText(path, createText);


                ftpUserID = txtbxUser.Text;
                ftpPassword = txtbxPass.Text;
                serverUri = ReverseSlash(txtbxServer.Text);
                localUri = ReverseSlash(txtbxLocal.Text);
                timerDuration = Convert.ToInt32(txtbxTimeInterval.Text);

            }
            catch (Exception eee) { }
        }

        private void chkbxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            //if (autoStartStatus.Equals("ON"))
            //{
            //    chkbxAutoStart.Checked = true;
            //}
            //else
            //{
            //    chkbxAutoStart.Checked = false;
            //}
        }

        string timerStatus;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerStatus = "on";
            timerCount = timerCount - 1000;
            string Sec = string.Empty;
            string Min = string.Empty;
            string Hour = string.Empty;

            if (timerCount <= 0)
            {
                lblTimer.Text = "";
                timer1.Stop();
                return;
            }
            else
            {
                var timeSpan = TimeSpan.FromMilliseconds(Convert.ToDouble(timerCount));

                var seconds = timeSpan.Seconds;
                var minutes = timeSpan.Minutes;
                var hours = timeSpan.Hours;

                if (seconds.ToString().Length.Equals(1))
                {
                    Sec = "0" + seconds.ToString();
                }
                else
                {
                    Sec = seconds.ToString();
                }
                if (minutes.ToString().Length.Equals(1))
                {
                    Min = "0" + minutes.ToString();
                }
                else
                {
                    Min = minutes.ToString();
                }
                if (hours.ToString().Length.Equals(1))
                {
                    Hour = "0" + hours.ToString();
                }
                else
                {
                    Hour = hours.ToString();
                }
                string Totaltime =  Hour + ":" + Min + ":" + Sec;
                lblTimer.Text = Totaltime;

                if (Hour == "00" && Min == "00" && Sec == "00")
                {
                    startMove();
                    timerStatus = "off";
                    MessageBox.Show("Backing-Up Files Done!");
                    //timer1.Enabled = true;
                    //timer1.Start();
                }
                else
                {
                    if (chboxAutoStart.Checked)
                    {
                        //   Console.WriteLine(lblTimer.Text);
                        if (lblTimer.Text == "00:00:01")
                        {
                            if (timeUnit == ("Minute"))
                            {
                                cmbTimeUnit.SelectedIndex = 0;
                                timerCount = (timerDuration * 60) * 1000;
                            }
                            else if (timeUnit == ("Hour"))
                            {
                                cmbTimeUnit.SelectedIndex = 1;
                                timerCount = ((timerDuration * 60) * 60) * 1000;
                            }
                            timer1.Enabled = true;
                            timer1.Start();
                            startMove();
                            //chkbxAutoStart.Checked = true;
                            //timer1.Enabled = true;
                            //startMove();
                            //btnStart.Visible = false;
                            //btnStop.Visible = true;
                        }
                    }
                }
            }
        }

        static System.Timers.Timer _timer; // From System.Timers
        static List<DateTime> _l; // Stores timer results

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (chboxAutoStart.Checked)
            {
                timer1.Stop();
                //btnStop.Visible = false;
                btnStart.Visible = true;
                btnStart.Enabled = true;
                lblTimer.Text = "Timer stopped!";
            }
            else
            {
                btnStart.Visible = true;
                btnStart.Enabled = true;
                
                lblMessage.Text = "Passing of files aborted";
            }
            if (thread.IsAlive)
            {
                thread.Suspend();
            }
            //thread.Abort();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //var ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(fileToCreate));
            //ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            //using (var inputStream = File.OpenRead(fileInf.Name))
            //using (var outputStream = ftpWebRequest.GetRequestStream())
            //{
            //    var buffer = new byte[1024 * 1024];
            //    int totalReadBytesCount = 0;
            //    int readBytesCount;
            //    while ((readBytesCount = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        outputStream.Write(buffer, 0, readBytesCount);
            //        totalReadBytesCount += readBytesCount;
            //        var progress = totalReadBytesCount * 100.0 / inputStream.Length;
            //        backgroundWorker1.ReportProgress((int)progress);
            //    }
            //}

            // Counter(ctr, files.Length);
            //if (files != null || files.Length < 0)
            //{
            //    foreach (string file in files)
            //    {
            //        backgroundWorker1.ReportProgress(ctr);
            //    }
            //}

            startMove();
        }

        public void Counter(int no, int total)
        {
            //for (int i = no; i < total; i++)
            //{
            while (no != total)
            {
                //Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(no);
            }
            //  }
        }
        static string[] substrings;
        private void button1_Click(object sender, EventArgs e)
        {

            // string str = "sasadadadada/adadadadad\"dadadadad / dadad";

            // string pattern = "\"";

            // str.Replace("/", pattern);
            // for (int x = 0; x < 1; x++)
            // {
            //     //MessageBox.Show(substrings[x] + "");
            //    // return
            //         Console.WriteLine(substrings[x].ToString());
            // }
            //// return null;
        }

        private void gpboxFTS_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(SystemColors.Highlight);
            //e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void gpboxAutoStart_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(SystemColors.Highlight);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            reqFTP.Abort();
       //     Break;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //thread.Abort();
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                //Backupfiles to local directory
                BackupFiles();
                //Copy files to server
                startMove();
                //Deletes file in the local PC
                //Directory.Delete(localUri + "/", true);

                System.IO.DirectoryInfo di = new DirectoryInfo(localUri);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                //Directory.CreateDirectory(localUri + "/");
                this.Invoke((MethodInvoker)delegate() { lblMessage.Text = "Done passing files \n" + ctr + " files passed"; });
            }
            catch (Exception eee)
            {

            }
        }

        public void Delete()
        {

        }

        public void BackupFiles()
        {
            try
            {
                //Directory.Move(localUri, "C:/Users/Teknologika inc/Desktop/Sample2/Newfolder/");
                //Copy(localUri, "C:/Users/Teknologika inc/Desktop/Sample2/"+DateTime.Now.ToString()+"/");
                //Copy(localUri, @"C:/Users/Teknologika inc/Desktop/Sample2/");
                Copy(localUri);
            }
            catch (Exception eee)
            {

            }
        }

        public static void Copy(string sourceDirectory)
        {
            string str = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(ReverseSlash2(AppDomain.CurrentDomain.BaseDirectory + str + "\\"));

                CopyAll(diSource, diTarget);
            }
            catch (Exception eee)
            {

            }
        }

        public static string ReverseSlash2(string input)
        {
            input = input.Replace("\\", "/");
            //Console.WriteLine(t);
            //  MessageBox.Show(input);
            return input;
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                Directory.CreateDirectory(target.FullName);

                // Copy each file into the new directory.
                foreach (FileInfo fi in source.GetFiles())
                {
                    Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                        //target.CreateSubdirectory(DateTime.Now.ToString());
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (Exception eee)
            {

            }
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(SystemColors.Highlight);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
    }
}

