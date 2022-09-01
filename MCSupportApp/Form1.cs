using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCSupportApp
{
    public partial class Form1 : Form
    {

        string stdOP, stdERR = null, RootDirPath = "";
        int exitCode, JavaVer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CMD_JDKVer()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c java --version");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;

            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            Process process = Process.Start(psi);

            string standardOutput = process.StandardOutput.ReadToEnd();
            string standardError = process.StandardError.ReadToEnd();
            exitCode = process.ExitCode;

            process.Close();

            if (exitCode == 0)
            {
                stdOP = standardOutput;
            }

            else if (exitCode <= 1)
            {
                stdERR = standardError;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "�T�[�o�[�t�@�C��(*.jar : *.JAR)|*.jar;*.JAR";
            ofd.Title = "�T�[�o�[�t�@�C����I�����Ă�������";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void jDK�o�[�W����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMD_JDKVer();
            if (exitCode == 0)
            {
                MessageBox.Show(stdOP);
            }

            else if (exitCode <= 1)
            {
                MessageBox.Show(stdERR);
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = new string[] { };
            files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBox1.Clear();
            var fileName = Path.GetFileName(files[0]);
            textBox1.Text += fileName;
            RootDirPath = Path.GetDirectoryName(files[0]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var MCVerIdx = comboBox1.SelectedIndex;
            if (MCVerIdx >= 8 && MCVerIdx <= 58)
            {
                JavaVer = 8;
            }
            else if (MCVerIdx >= 0 && MCVerIdx <= 7)
            {
                JavaVer = 17;
            }


            label8.Text = "Java"+ JavaVer +"�̃C���X�g�[���t�H���_�[";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fo = new FolderBrowserDialog();

            fo.Description = "Java" + JavaVer + "���C���X�g�[�����Ă���t�H���_���w�肵�Ă�������";

            if (fo.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = fo.SelectedPath;
            }
            fo.Dispose();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

//-----------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            textBox2.PlaceholderText = "run";
            textBox4.PlaceholderText = "1";
            textBox5.PlaceholderText = "4";
        }

//-----------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            var MCVerIdx = comboBox1.SelectedIndex;
            if (MCVerIdx >= 8 && MCVerIdx <= 58)
            {
                JavaVer = 8;
            }
            else if(MCVerIdx >= 0 && MCVerIdx <= 7)
            {
                JavaVer = 17;
            }
            CMD_JDKVer();
            //exitCode:0 = �擾�����AexitCode:1 = java���C���X�g�[�����ĂȂ��\���������G���[
            if (exitCode == 0)
            {
                //Split�ŉ��s�ʂɔz��
                string[] stdOP_Split = stdOP.Split(new string[] {"\r\n"}, StringSplitOptions.None);
                //if��1�s�ڂ�jdk�o�[�W�����̕�����ƕK�vjdk�o�[�W�����̔�r
                if(stdOP_Split[0].Contains("openjdk 11") == true)
                {
                    Debug.WriteLine("True");
                }
            }

            else if (exitCode <= 1)
            {
                if(stdERR.Contains("java") == true)
                {
                    if(stdERR.Contains("�����R�}���h�܂��͊O���R�}���h") == true)
                    {
                        MessageBox.Show("Java" + JavaVer + "���C���X�g�[������Ă��Ȃ����A\r\n" +
                            "Program Files  ��������  Program Files (x86) �̒��� Java �t�H���_�ɁA\r\n" +
                            "Java" + JavaVer + "���C���X�g�[������Ă��Ȃ��\��������܂��B\r\n" +
                            "�N���t�@�C���͏o�͂��܂����A�T�[�o�[���N�����Ȃ��\��������܂��B\r\n" +
                            "Java" + JavaVer + "���C���X�g�[���ς݂� Program Files  ��������  Program Files (x86) �ȊO�̃t�H���_�ɃC���X�g�[�������ꍇ�́A\r\n" +
                            "�ڍאݒ�̍��ڂ��J��Java" + JavaVer + "�̃t�H���_���w�肵�Ă��������B \r\n\r\n" + 
                            "====== �G���[���e ======\r\n" + stdERR);
                    }
                    else
                    {
                        MessageBox.Show("Java�G���[�̉\��������܂��B\r\n\r\n" +
                            "====== �G���[���e ======\r\n" + stdERR);
                    }
                }
                else
                {
                    MessageBox.Show("���̃G���[���������Ă݂Ă��������B\r\n\r\n" +
                        "====== �G���[���e ======\r\n" + stdERR);
                }
            }

            string runFolder = "" , srvFileNm = "", GUIchk = "", runProg = "";


            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "�T�[�o�[�t�@�C�����u���Ă���t�H���_���w�肵�Ă�������";
            fbd.SelectedPath = RootDirPath;


            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                runFolder = fbd.SelectedPath;
            }

            fbd.Dispose();

            if(checkBox1.Checked == true)
            {
                GUIchk = "";
            }
            else if(checkBox1.Checked == false)
            {
                GUIchk = " nogui";
            }


            //bat�t�@�C������
            srvFileNm = textBox1.Text;
            int Xms = 1, Xmx = 4;
            string javaFullPath = "", unit1 = "G", unit2 = "G", javaFullPath_st = "";
            if (textBox3.Text.Length == 0)
            {
                javaFullPath = "java";
                javaFullPath_st = javaFullPath;
            }
            else
            {
                javaFullPath = Path.Combine(textBox3.Text, "bin", "java.exe");
                javaFullPath_st = "\"" + javaFullPath + "\"";
            }

            if (!(textBox4.Text.Length == 0))
            {
                Xms = int.Parse(textBox4.Text);
                unit1 = comboBox2.Text.Substring(0, comboBox2.Text.Length - 1);
            }
            if (!(textBox5.Text.Length == 0))
            {
                Xmx = int.Parse(textBox5.Text);
                unit2 = comboBox3.Text.Substring(0, comboBox3.Text.Length - 1);
            }

            runProg =
                "@echo off\r\n" +
                javaFullPath_st + " -Xms" + Xms + unit1 + " -Xmx" + Xmx + unit2 + " -jar " + srvFileNm + GUIchk + "\r\n" +
                "pause";

            string defaultFn = "";

            if(textBox2.Text.Length == 0)
            {
                defaultFn = "run";
            }
            else
            {
                defaultFn = textBox2.Text;
            }

            try
            {
                string filePath = Path.Combine(runFolder, defaultFn + ".bat");

                FileInfo fileInfo = new FileInfo(filePath);
                if(fileInfo.Exists)
                {
                    DialogResult dr = MessageBox.Show("���Ƀt�@�C�������݂��܂��B\r\n\r\n�㏑�����Ă���낵���ł��傤���H", "�m�F", MessageBoxButtons.OKCancel);

                    if(dr == DialogResult.OK)
                    {
                        Encoding enc = Encoding.GetEncoding("UTF-8");
                        using (StreamWriter writer = new StreamWriter(filePath, false, enc))
                        {
                            writer.WriteLine(runProg);
                        }

                    }
                    MessageBox.Show("�N���p�t�@�C���ɏ㏑���ۑ�����܂����B");

                }

                else
                {
                    using (FileStream fs = File.Create(filePath)) ;

                    Encoding enc = Encoding.GetEncoding("UTF-8");
                    using(StreamWriter writer = new StreamWriter(filePath, false, enc))
                    {
                        writer.WriteLine(runProg);
                    }

                    MessageBox.Show("�N���p�t�@�C�����쐬����܂����B");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}