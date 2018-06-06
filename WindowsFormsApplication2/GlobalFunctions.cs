using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPFileMover
{
    class GlobalFunctions
    {
        //public void startMove()
        //{
        //    try
        //    {
        //        if (rbtnFolder.Checked)
        //        {
        //            IncludeFolders();
        //        }
        //        else if (rbtnAll.Checked)
        //        {
        //            PassFiles(localUri, "");
        //            IncludeFolders();

        //        }
        //        else
        //        {
        //            PassFiles(localUri, "");
        //        }

        //        lblMessage.Text = "Done passing files \n" + ctr + " files passed";
        //        using (StreamWriter stream = new FileInfo("logfile.txt").AppendText())
        //        {
        //            stream.WriteLine(DateTime.Now + " " + ctr.ToString() + " files passed");
        //        }

        //        ctr = 0;
        //        //lblMessage.Text = "Tranferring files done!";         

        //        if (!chboxAutoStart.Checked)
        //        {
        //            btnStart.Enabled = true;
        //            //btnStart.Visible = true;
        //            //        btnStop.Visible = false;
        //        }

        //        //   }
        //        //    lblTimer.Text = "Auto-Start not Enabled";               
        //    }
        //    catch (Exception eee)
        //    {
        //        lblMessage.Text = eee.Message;
        //        btnStart.Enabled = true;
        //    }

        //}
        //public void IncludeFolders()
        //{
        //    //backgroundWorker1.RunWorkerAsync();

        //    string sourceDirectory = "";
        //    sourceDirectory = localUri;
        //    string destinationPath = "";
        //    destinationPath = serverUri;
        //    long totalSize = 0;
        //    string lastModified = "";
        //    DateTime CompareDate = DateTime.Now.AddDays(-30);
        //    string[] folderNames = Directory.GetDirectories(sourceDirectory, "*.*", SearchOption.AllDirectories);
        //    foreach (string fn in folderNames)
        //    {
        //        string str;
        //        DirectoryInfo d;
        //        str = new DirectoryInfo(fn).Name;
        //        Console.WriteLine(fileToCreate);
        //        Console.WriteLine(str);
        //        Console.WriteLine(fileToCreate);
        //        fileToCreate = "ftp://" + serverUri + str + "/";
        //        Console.WriteLine(fileToCreate);

        //        // Create FtpWebRequest object from the Uri provided
        //        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(fileToCreate));

        //        // Provide the WebPermission Credintials
        //        reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

        //        //reqFTP.UsePassive = true;
        //        //reqFTP.UseBinary = true;
        //        //reqFTP.KeepAlive = false;
        //        reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;

        //        // Step 3 - Call GetResponse() method to actually attempt to create the directory
        //        try
        //        {
        //            FtpWebResponse makeDirectoryResponse = (FtpWebResponse)reqFTP.GetResponse();
        //        }
        //        catch (Exception eeee)
        //        { }
        //        //////////////////////////////////////////////
        //        PassFiles(fn, str);
        //    }
        //}

        //public void PassFiles(string fn, string str)
        //{
        //    try
        //    {
        //        if (rbtnFolder.Checked || rbtnAll.Checked)
        //        {
        //            str = str + "/";
        //            files = Directory.GetFiles(fn + "/", @"*.*");
        //        }
        //        else
        //        {
        //            files = Directory.GetFiles(fn, @"*.*");
        //        }

        //        if (files != null || files.Length < 0)
        //        {
        //            foreach (string file in files)
        //            {
        //                Console.WriteLine(ctr.ToString());
        //                fileInf = new FileInfo(file);
        //                fileToCreate = "ftp://" + serverUri + str + fileInf.Name;
        //                // Create FtpWebRequest object from the Uri provided
        //                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(fileToCreate));
        //                // Provide the WebPermission Credintials
        //                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        //                // By default KeepAlive is true, where the control connection is not closed
        //                // after a command is executed.
        //                reqFTP.KeepAlive = false;
        //                // Specify the command to be executed.
        //                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
        //                // Specify the data transfer type.
        //                reqFTP.UseBinary = true;
        //                // Notify the server about the size of the uploaded file
        //                reqFTP.ContentLength = fileInf.Length;
        //                //int buffLength = 524288;
        //                int buffLength = 5000;
        //                byte[] buff = new byte[buffLength];
        //                int contentLen;

        //                // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
        //                FileStream fs = fileInf.OpenRead();
        //                try
        //                {
        //                    // Stream to which the file to be upload is written
        //                    Stream strm = reqFTP.GetRequestStream();
        //                    // Read from the file stream 2kb at a time
        //                    contentLen = fs.Read(buff, 0, buffLength);
        //                    // Until Stream content ends
        //                    while (contentLen != 0)

        //                    {
        //                        // Write Content from the file stream to the FTP Upload Stream
        //                        strm.Write(buff, 0, contentLen);
        //                        contentLen = fs.Read(buff, 0, buffLength);
        //                        //////////////                      backgroundWorker1_DoWork;
        //                    }
        //                    // Close the file stream and the Request Stream
        //                    strm.Close();
        //                    fs.Close();
        //                    /////////////////////////////////////////////////////////////////////
        //                    //Deletes file after creating/copying in the server
        //                    //deleteFile();
        //                    ctr++;
        //                }
        //                catch (Exception ex)
        //                {
        //                    //MessageBox.Show(ex.Message, "Upload Error");
        //                    lblMessage.Text = ex.Message;
        //                    btnStart.Enabled = true;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception eeee)
        //    {
        //        // lblMessage.Text = eeee.Message;
        //        //  btnStart.Enabled = true;
        //    }
        //    //lblMessage.Text = "";

        //}



        //public void deleteFile()
        //{
        //    try
        //    {
        //        string fileToDelete = localUri + fileInf.Name;
        //        if (File.Exists(@"" + fileToDelete))
        //        {
        //            File.Delete(@"" + fileToDelete);
        //        }
        //        else
        //        {
        //            //dapat magrun ulit dito yung program instead of eror message
        //        }



        //        //string[] files = Directory.GetFiles(path, @"*.*");

        //        //if (files != null)
        //        //{
        //        //    foreach (string file in files)
        //        //    {
        //        //FileInfo fileInf = new FileInfo(file);

        //        // uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
        //        // uri = path + fileInf.Name;
        //        // /* Create an FTP Request */
        //        // reqFTP = (FtpWebRequest)WebRequest.Create(uri);
        //        // /* Log in to the FTP Server with the User Name and Password Provided */
        //        // reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        //        // /* When in doubt, use these options */
        //        // reqFTP.UseBinary = true;
        //        // reqFTP.UsePassive = true;
        //        // reqFTP.KeepAlive = true;
        //        // /* Specify the Type of FTP Request */
        //        //// reqFTP = (FtpWebRequest)WebRequest.Create(host + "/" + deleteFile);
        //        // reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
        //        // /* Resource Cleanup */
        //        // FtpWebResponse ftpResponse = (FtpWebResponse)reqFTP.GetResponse();
        //        // ftpResponse.Close();
        //        // reqFTP = null;
        //        //    }
        //        //}
        //    }
        //    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        //    return;
        //}
    }
}
