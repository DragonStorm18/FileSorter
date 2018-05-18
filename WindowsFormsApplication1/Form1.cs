using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CheckMonth.Checked = true;
        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            lblFinish.Text = "Sorting Files Please Wait......";

            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\");
            FileInfo[] files = info.GetFiles().Where(j => !j.Extension.EndsWith("exe")).OrderBy(p => p.LastWriteTime).ToArray();

            if (CheckDate.Checked == true)
            {
                SelectionDate();
            }
            else
                if (CheckMonth.Checked == true)
                {
                    SelectionMonth();
                }
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = files.Length;

            if (files.Length == 0)
            {
                MessageBox.Show("There are no files to move");
            }
            //if (progressBar1.Value == files.Length)
            //{
                //MessageBox.Show("File Sorting Complete");
                lblFinish.Text = "FILE SORTING COMPLETE";
            //}
        }

        public DateTime GetDateTaken(Image targetImg)
        {
            //Property Item 36867 corresponds to the Date Taken
            PropertyItem propItem = targetImg.GetPropertyItem(36867);
            DateTime dtaken;
            //Convert date taken metadata to a DateTime object
            string sdate = Encoding.UTF8.GetString(propItem.Value).Trim();
            string secondhalf = sdate.Substring(sdate.IndexOf(" "), (sdate.Length - sdate.IndexOf(" ")));
            string firsthalf = sdate.Substring(0, 10);
            firsthalf = firsthalf.Replace(":", "-");
            sdate = firsthalf + secondhalf;
            dtaken = DateTime.Parse(sdate);
            return dtaken;
        }

        private void SelectionMonth()
        {
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\");
            FileInfo[] files = info.GetFiles().Where(j => !j.Extension.EndsWith("exe")).OrderBy(p => p.LastWriteTime).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                string from = Application.StartupPath + "\\" + files[i];
                string dest = Application.StartupPath + "\\" + files[i].LastWriteTime.ToString("yyyy-MMMM") + "\\" + files[i];

                Directory.CreateDirectory(Application.StartupPath + "\\" + files[i].LastWriteTime.ToString("yyyy-MMMM"));

                if (File.Exists(dest))
                {
                    DialogResult dr = MessageBox.Show("The file you are trying to move " + " ( " + files[i] + " ) " + " already exists. Do you want to overide it?", "Overwrite Files", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(dest);
                    }
                    else
                    {
                        if (dr == DialogResult.No)
                        {
                            continue;
                        }
                    }
                }
                File.Move(from, dest);
               // progressBar1.Value = progressBar1.Value + 1;
                //progressBar1.Update();
            }
        }

        private void SelectionDate()
        {
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\");
            FileInfo[] files = info.GetFiles().Where(j => !j.Extension.EndsWith("exe")).OrderBy(p => p.LastWriteTime).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                string from = Application.StartupPath + "\\" + files[i];
                string dest = Application.StartupPath + "\\" + files[i].LastWriteTime.ToString("yyyy-MM-dd") + "\\" + files[i];

                Directory.CreateDirectory(Application.StartupPath + "\\" + files[i].LastWriteTime.ToString("yyyy-MM-dd"));

                if (File.Exists(dest))
                {
                    DialogResult dr = MessageBox.Show("The file you are trying to move " + " ( " + files[i] + " ) " + " already exists. Do you want to overide it?", "Overwrite Files", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(dest);
                    }
                    else
                    {
                        if (dr == DialogResult.No)
                        {
                            continue;
                        }
                    }
                }
                File.Move(from, dest);
               // progressBar1.Value = progressBar1.Value + 1;
                //ogressBar1.Update();
            }
        }

        private void checkMonth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

       


