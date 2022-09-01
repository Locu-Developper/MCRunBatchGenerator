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
            ofd.Filter = "サーバーファイル(*.jar : *.JAR)|*.jar;*.JAR";
            ofd.Title = "サーバーファイルを選択してください";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void jDKバージョンToolStripMenuItem_Click(object sender, EventArgs e)
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


            label8.Text = "Java"+ JavaVer +"のインストールフォルダー";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fo = new FolderBrowserDialog();

            fo.Description = "Java" + JavaVer + "をインストールしてあるフォルダを指定してください";

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
            //exitCode:0 = 取得成功、exitCode:1 = javaをインストールしてない可能性が高いエラー
            if (exitCode == 0)
            {
                //Splitで改行別に配列
                string[] stdOP_Split = stdOP.Split(new string[] {"\r\n"}, StringSplitOptions.None);
                //ifで1行目のjdkバージョンの文字列と必要jdkバージョンの比較
                if(stdOP_Split[0].Contains("openjdk 11") == true)
                {
                    Debug.WriteLine("True");
                }
            }

            else if (exitCode <= 1)
            {
                if(stdERR.Contains("java") == true)
                {
                    if(stdERR.Contains("内部コマンドまたは外部コマンド") == true)
                    {
                        MessageBox.Show("Java" + JavaVer + "がインストールされていないか、\r\n" +
                            "Program Files  もしくは  Program Files (x86) の中の Java フォルダに、\r\n" +
                            "Java" + JavaVer + "がインストールされていない可能性があります。\r\n" +
                            "起動ファイルは出力しますが、サーバーが起動しない可能性があります。\r\n" +
                            "Java" + JavaVer + "をインストール済みで Program Files  もしくは  Program Files (x86) 以外のフォルダにインストールした場合は、\r\n" +
                            "詳細設定の項目を開きJava" + JavaVer + "のフォルダを指定してください。 \r\n\r\n" + 
                            "====== エラー内容 ======\r\n" + stdERR);
                    }
                    else
                    {
                        MessageBox.Show("Javaエラーの可能性があります。\r\n\r\n" +
                            "====== エラー内容 ======\r\n" + stdERR);
                    }
                }
                else
                {
                    MessageBox.Show("下のエラーを検索してみてください。\r\n\r\n" +
                        "====== エラー内容 ======\r\n" + stdERR);
                }
            }

            string runFolder = "" , srvFileNm = "", GUIchk = "", runProg = "";


            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "サーバーファイルが置いてあるフォルダを指定してください";
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


            //batファイル生成
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
                    DialogResult dr = MessageBox.Show("既にファイルが存在します。\r\n\r\n上書きしてもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);

                    if(dr == DialogResult.OK)
                    {
                        Encoding enc = Encoding.GetEncoding("UTF-8");
                        using (StreamWriter writer = new StreamWriter(filePath, false, enc))
                        {
                            writer.WriteLine(runProg);
                        }

                    }
                    MessageBox.Show("起動用ファイルに上書き保存されました。");

                }

                else
                {
                    using (FileStream fs = File.Create(filePath)) ;

                    Encoding enc = Encoding.GetEncoding("UTF-8");
                    using(StreamWriter writer = new StreamWriter(filePath, false, enc))
                    {
                        writer.WriteLine(runProg);
                    }

                    MessageBox.Show("起動用ファイルが作成されました。");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}