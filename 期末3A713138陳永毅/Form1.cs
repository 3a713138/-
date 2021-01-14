using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末3A713138陳永毅
{   
    public partial class Form1 : System.Windows.Forms.Form
    {
        int floor = 1;
        int mHP = 0; //怪物最大血量
        int nEXP = 5;//需要經驗
        int HMHP = 0;//人物最大血量
        int HMMP = 0;//人物最大魔量
        public int LV = 0;//等級
        int EXP = 0;//現有經驗
        int mD = 0;//累積傷害
        int D = 0;//判斷累積傷害
        int lastD = 0;//最後傷害
        int Attack = 0;//物攻
        int Contact = 0;//魔攻
        int Defense = 0;
        int cost = 0;
        int 技能 = 0;
        public int point ;
        public int xx;
        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        public class resp
        {
            public List<img> data { get; set; }
        }

        public class img
        {
            public string link { get; set; }
        }
        private resp GetImages(string albumHash, string clientId)
        {
            resp result = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.imgur.com/3/album/{albumHash}/images");
                //Add Header 
                WebHeaderCollection webHeaderCollection = request.Headers;
                webHeaderCollection.Add("Authorization", $"Client-ID {clientId}");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string json = readStream.ReadToEnd();

                result = JsonConvert.DeserializeObject<resp>(json);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (mHP == 0)
            {
                int randomIndex = (new Random()).Next(100);
                if (randomIndex <= 30)
                {

                    richTextBox.Text = "前進\r";
                }
                else if (randomIndex <= 75)
                {
                    int monster = (new Random()).Next(100);
                    if (monster <= 50)
                    {
                        richTextBox.Text = "遭遇怪物\r";
                        int m = (new Random()).Next(84);
                        if (m <= 34)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 10;
                            D = mHP;
                            lastD = mHP;
                        }
                        else if (m <= 68)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 10 + 4;
                            D = mHP;
                            lastD = mHP;
                        }
                        else
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 10 - 4;
                            D = mHP;
                            lastD = mHP;
                        }
                        string myString = mHP.ToString();
                        rtbOutput.Text = myString;
                        var x = GetImages("C6LjsIZ", "8a721fbdac72744");
                        if (x == null)
                        {
                            return;
                        }
                        // download 一張照片下來  
                        string url = x.data[0].link;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream receiveStream = response.GetResponseStream();
                        var image = Image.FromStream(receiveStream);
                        Console.WriteLine(image.Width);
                        picResult.Image = image;


                    }
                    else if (monster <= 80)
                    {
                        richTextBox.Text = "遭遇菁英怪物\r";
                        int m = (new Random()).Next(57);
                        if (m <= 23)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 20;
                            D = mHP;
                            lastD = mHP;
                        }
                        else if (m <= 46)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 20 + 5;
                            D = mHP;
                            lastD = mHP;
                        }
                        else
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 20 - 5;
                            D = mHP;
                            lastD = mHP;
                        }
                        string myString = mHP.ToString();
                        rtbOutput.Text = myString;
                        var x = GetImages("TsQIrJz", "8a721fbdac72744");
                        if (x == null)
                        {
                            return;
                        }
                        // download 一張照片下來  
                        string url = x.data[m].link;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream receiveStream = response.GetResponseStream();
                        var image = Image.FromStream(receiveStream);
                        Console.WriteLine(image.Width);
                        picResult.Image = image;
                    }
                    else
                    {
                        richTextBox.Text = "遭遇BOSS\r";
                        int m = (new Random()).Next(25);
                        if (m <= 10)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 200;
                            D = mHP;
                            lastD = mHP;
                        }
                        else if (m <= 20)
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 200 + 5;
                            D = mHP;
                            lastD = mHP;
                        }
                        else
                        {
                            mD = 0;
                            mHP = 0;
                            mHP = floor * 200 - 5;
                            D = mHP;
                            lastD = mHP;
                        }
                        string my = mHP.ToString();
                        rtbOutput.Text = my;
                        var x = GetImages("ZyzZjHZ", "8a721fbdac72744");
                        if (x == null)
                        {
                            return;
                        }
                        // download 一張照片下來  
                        string url = x.data[m].link;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream receiveStream = response.GetResponseStream();
                        var image = Image.FromStream(receiveStream);
                        Console.WriteLine(image.Width);
                        picResult.Image = image;
                    }

                }
                else
                {
                    richTextBox.Text = "獲得道具";
                }
            }
            else
            {
                MessageBox.Show($"請先打倒怪物", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 道具ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void 技能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                mHP = mHP - 10;
                if(mHP<=0)
                {
                if (mD == lastD)
                {
                    MessageBox.Show($"別再空揮了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mD = 0;
                    mHP = 0;
                }
                else
                {
                    mD = mD + D;
                    mHP = 0;
                    string my = mHP.ToString();
                    rtbOutput.Text = my;
                    if (mD <= floor * 10 + 4)
                    {
                        if(nEXP<=EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;
                            
                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            form2.x += 3;

                        }
                        else
                        {
                            EXP = EXP + floor;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                        }
                    }
                    else if (mD <= floor * 20 + 5)
                    {
                        if (nEXP <= EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;

                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor ;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            form2.x += 3;

                        }
                        else
                        {
                            EXP = EXP + (2 * floor);
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            
                        }
                    }
                    else
                    {
                        if (nEXP <= EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;

                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor ;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            floor = floor + 1;
                            string myString = floor.ToString();
                            label3.Text = myString;
                            form2.x +=   3;
                        }
                        else
                        {
                            EXP = EXP + (5 * floor);
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            floor = floor + 1;
                            string myString = floor.ToString();
                            label3.Text = myString;
                        }
                    }
                }
                }
                else
                {
                    mD =mD + 10;
                    string my = mHP.ToString();
                    rtbOutput.Text = my;
                    D = D - 10;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mHP = mHP - 20;
            if (mHP <= 0)
            {
                if (mD == lastD)
                {
                    MessageBox.Show($"別再空揮了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mD = 0;
                    mHP = 0;
                }
                else
                {
                    mD = mD + D;
                    mHP = 0;
                    string my = mHP.ToString();
                    rtbOutput.Text = my;
                    if (mD <= floor * 10 + 4)
                    {
                        if (nEXP <= EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;

                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            form2.x += 3;
                          
                        }
                        else
                        {
                            EXP = EXP + floor;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                        }
                    }
                    else if (mD <= floor * 20 + 5)
                    {
                        if (nEXP <= EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;

                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            form2.x += 3;
                        }
                        else
                        {
                            EXP = EXP + (2 * floor);
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                        }
                    }
                    else
                    {
                        if (nEXP <= EXP)
                        {
                            LV = LV + 1;
                            EXP = EXP - nEXP;

                            string LVs = LV.ToString();
                            label9.Text = LVs;
                            nEXP = nEXP + 2 * floor;
                            string nEXPs = nEXP.ToString();
                            label13.Text = nEXPs;
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            floor = floor + 1;
                            string myString = floor.ToString();
                            label3.Text = myString;
                            form2.x += 3;
                        }
                        else
                        {
                            EXP = EXP + (5 * floor);
                            string NEXP = EXP.ToString();
                            label12.Text = NEXP;
                            floor = floor + 1;
                            string myString = floor.ToString();
                            label3.Text = myString;
                        }
                    }
                }
            }
            else
            {
                mD = mD + 20;
                string my = mHP.ToString();
                rtbOutput.Text = my;
                D = D - 20;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void 技能ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void 能力值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            form2.Show();
        }
    }
}
