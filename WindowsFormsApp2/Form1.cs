using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private bool Isok { get; set; } = false;
        private CancellationTokenSource cts { get; set; } = new CancellationTokenSource ();
        string path1 { get; set; }
        int password;
        public Form1()
        {
            InitializeComponent();
            To_label.Focus();
        }


        private char xorIt(char input)
        {
            return (char)(input ^ password);
        }
        private bool Check() => From_label.Text.Length>0;



        private void FileWrite(CancellationToken token)
        {
            Isok = true;
            password = Convert.ToInt32(To_label.Text);
            var array = File.ReadAllText(path1);
            int num = array.Length / 100;
            using (StreamWriter writer = new StreamWriter("test.txt", false))
            {
                progressBar1.Value++;
                for (int i = 0; i < array.Length; i++)
                {

                  //  Thread.Sleep(1000);

                    writer.Write(xorIt(array[i]));
                    if (num >= i)
                    {
                        num += num;
                        progressBar1.Value++;
                    }
                    if (token.IsCancellationRequested)
                    {
                        MessageBox.Show("A");
                        return;
                    }

                }
                progressBar1.Value = 100;

            }
            File.Copy("test.txt", path1, true);
  

        }

        
       // [Obsolete]
        public void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Tag)
                {
                    case "1":
                        OpenFileDialog theDialog = new OpenFileDialog();
                        theDialog.Title = "Open Text File";
                        theDialog.Filter = "TXT files|*.txt";
                        
                        if (theDialog.ShowDialog() == DialogResult.OK)
                        {
                            path1 = theDialog.FileName;
                            From_label.Text = theDialog.FileName;
                        }
                        break;
                    case "3":
                        if (Check())
                        {

                            using ( cts = new CancellationTokenSource())
                            {
                                ThreadPool.QueueUserWorkItem((O) =>
                                {

                                    try
                                    {
                                        FileWrite(cts.Token);
                                    }
                                    catch (Exception ex)
                                    {

                                        throw;
                                    }

                                });
                            }
                        }
                        break;
                    case "5":
                        if (Isok)
                        {
                            cts.Cancel();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
