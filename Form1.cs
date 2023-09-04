using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folders_Sizer
{
    public partial class Form1 : Form
    {
        static bool inWork;
        static long sizeValue;
        static long foldersValue;
        static long filesValue;
        static Thread intefaceUpdate;
        public Form1()
        {
            InitializeComponent();
            Result_DGV.RowCount = 6;
        }

        public void StartProcedure()
        {
            Invoke((MethodInvoker)delegate ()
            {
                Folders_L.Text = "0";
                Fiels_L.Text = "0";
                Size_L.Text = "0";
                
                Open_B.Enabled = false;
                Path_TB.Enabled = false;
                Start_B.Text = "Stop";
                inWork = true;
            });

            sizeValue = 0;
            foldersValue = 0;
            filesValue = 0;

            var folders = Directory.GetDirectories(Path_TB.Text).ToList();
            var folderList = new List<Folder>();

            foreach (var folder in folders)
            {
                var tFolder = new Folder();

                tFolder.Path = folder;
                tFolder.GetName();
                tFolder.GetSize();
                foldersValue++;

                folderList.Add(tFolder);
            }

            Invoke((MethodInvoker)delegate ()
            {
                Result_DGV.Rows.Clear();

                foreach (var folder in folderList)
                {
                    folder.GetPercent();

                    Result_DGV.Rows.Add(folder.Name, folder.SizeMB, folder.SizeB, folder.Percent);
                }

                while (Result_DGV.Rows.Count < 6)
                    Result_DGV.Rows.Add();

                Folders_L.Text = foldersValue.ToString();
                Fiels_L.Text = filesValue.ToString();
                Size_L.Text = Math.Round((double)sizeValue / 1024 / 1024, 1).ToString();
                Open_B.Enabled = true;
                Path_TB.Enabled = true;
                Start_B.Text = "Start";
                inWork = false;
            });

            try { intefaceUpdate.Abort(); }
            catch { }
        }

        private void Start_B_Click(object sender, EventArgs e)
        {
            var calculationThread = new Thread(StartProcedure);
            if (inWork)
            {
                try
                {
                    calculationThread.Abort();
                    intefaceUpdate.Abort();
                    Open_B.Enabled = true;
                    Path_TB.Enabled = true;
                    Start_B.Text = "Start";
                    inWork = false;
                }
                catch { }
            }
            else
            {
                calculationThread.Start();

                intefaceUpdate = new Thread(InterfaceUpdate);
                intefaceUpdate.Start();
            }
        }

        public void InterfaceUpdate()
        {
            while (true)
            {
                Thread.Sleep(25);

                Invoke((MethodInvoker)delegate ()
                {
                    Folders_L.Text = foldersValue.ToString();
                    Fiels_L.Text = filesValue.ToString();
                    Size_L.Text = Math.Round((double)sizeValue / 1024 / 1024, 1).ToString();
                });
            }
        }

        private class Folder
        {
            public string Name;
            public string Path;
            public long SizeB;
            public double SizeMB;
            public double Percent;

            public void GetName()
            {
                var tName = Path.Split('\\');
                Name = tName[tName.Length - 1];
            }

            public void GetSize()
            {
                try
                {
                    var folders = new DirectoryInfo(Path).GetDirectories();
                    var files = new DirectoryInfo(Path).GetFiles();

                    foreach (var folder in folders)
                        GetSize(folder);

                    foreach (var file in files)
                    {
                        SizeB += file.Length;
                        sizeValue += file.Length;
                        filesValue++;
                    }

                    SizeMB = Math.Round(SizeB / 1024f / 1024f, 2);
                }
                catch { }
            }

            public void GetSize(DirectoryInfo sourceFolder)
            {
                try
                {
                    var folders = new DirectoryInfo(sourceFolder.FullName).GetDirectories();
                    var files = new DirectoryInfo(sourceFolder.FullName).GetFiles();

                    foreach (var folder in folders)
                        GetSize(folder);

                    foreach (var file in files)
                    {
                        SizeB += file.Length;
                        sizeValue += file.Length;
                        filesValue++;
                    }
                }
                catch { }
            }

            public void GetPercent()
            {
                Percent = Math.Round((double)SizeB / (double)sizeValue * 100d, 2);
            }
        }

        private void Open_B_Click(object sender, EventArgs e)
        {
            using (var ofd = new FolderBrowserDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Path_TB.Text = ofd.SelectedPath;
            }
        }
    }
}
