using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Windows
{
    public partial class TestForm : Form
    {
        private static int activeQuestion;
        private static int maxQuestion;
        private static char[] correctAns;
        private static string[] questions;
        private static char[] selectedAns;
        private static int timeLeft = 60;
        private static string canName;
        private static string country;
        private static string canNumber;

        public TestForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(350, 662);
            groupBox2.SetBounds(50, 100, 275, 475);
            groupBox3.SetBounds(50, 100, 275, 475);
            groupBox4.SetBounds(50, 100, 275, 475);
            activeQuestion = 0;
            setContestDetail();
            loadQuestionFile();
            timeClock.Start();
        }

        private void setContestDetail()
        {
            ContestEntryForm contestForm = new ContestEntryForm();
            canName = contestForm.getCanName();
            labCanName.Text = contestForm.getCanName();
            country = contestForm.getCountry();
            canNumber = contestForm.getCanNum();
            string picPath;
            if (country == "Angola")
                picPath = "f01.jpg";
            else if (country == "Antigua")
                picPath = "f02.jpg";
            else if (country == "Argentina")
                picPath = "f03.jpg";
            else if (country == "Armenia")
                picPath = "f04.jpg";
            else
                picPath = "f05.jpg";
            picFlag.Image  = Image.FromFile(picPath);
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadQuestionFile()
        {
            StreamReader datafile;
            string aLine;
            try
            {
                datafile = new StreamReader("mamat.txt");
                aLine = datafile.ReadLine();
                maxQuestion = Convert.ToInt32(aLine);
                questions = new string[maxQuestion];
                selectedAns = new char[maxQuestion];
                correctAns = new char[maxQuestion];
                int k = 0;
                while (datafile.Peek() != -1)
                {
                    questions[k] = datafile.ReadLine();
                    k++;
                }
                datafile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORRRR2 : " + ex.Message);
            }
        }


        private void displayQuestion()
        {
            string aLine;

            aLine = questions[activeQuestion];
            string[] wordList = Regex.Split(aLine, @":");
            int quesType = Convert.ToInt32(wordList[0]);
            correctAns[activeQuestion] = Convert.ToChar(wordList[1]);

            if (quesType == 1)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                radType1A.Checked = false;
                radType1B.Checked = false;
                radType1C.Checked = false;
                radType1D.Checked = false;
                if (selectedAns[activeQuestion] == 'A')
                    radType1A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType1B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType1C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType1D.Checked = true;

                labQType1.Text = wordList[2];
                radType1A.Text = wordList[3];
                radType1B.Text = wordList[4];
                radType1C.Text = wordList[5];
                radType1D.Text = wordList[6];
            }
            else if (quesType == 2)
            {
                radType2A.Checked = false;
                radType2B.Checked = false;
                radType2C.Checked = false;
                radType2D.Checked = false;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                if (selectedAns[activeQuestion] == 'A')
                    radType2A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType2B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType2C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType2D.Checked = true;

                labQType2.Text = wordList[2];
                string picFile = wordList[3];
                picQuestion.Image = Image.FromFile(picFile);
                picQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
                radType2A.Text = wordList[4];
                radType2B.Text = wordList[5];
                radType2C.Text = wordList[6];
                radType2D.Text = wordList[7];
            }
            else if (quesType == 3)
            {
                radType3A.Checked = false;
                radType3B.Checked = false;
                radType3C.Checked = false;
                radType3D.Checked = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                if (selectedAns[activeQuestion] == 'A')
                    radType3A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType3B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType3C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType3D.Checked = true;

                labQType3.Text = wordList[2];
                string picFile1 = wordList[3];
                string picFile2 = wordList[4];
                string picFile3 = wordList[5];
                string picFile4 = wordList[6];
                type3APic.Image = Image.FromFile(picFile1);
                type3APic.SizeMode = PictureBoxSizeMode.StretchImage;
                type3BPic.Image = Image.FromFile(picFile2);
                type3BPic.SizeMode = PictureBoxSizeMode.StretchImage;
                type3CPic.Image = Image.FromFile(picFile3);
                type3CPic.SizeMode = PictureBoxSizeMode.StretchImage;
                type3DPic.Image = Image.FromFile(picFile4);
                type3DPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
   
            labActiveQuestion.Text = (activeQuestion + 1) + " of " + maxQuestion;
            labDebug.Text = "";

            if (activeQuestion == 0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (maxQuestion == (activeQuestion + 1))
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            activeQuestion++;
            displayQuestion();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            activeQuestion--;
            displayQuestion();
        }

        private void radType1A_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'A';
        }

        private void radType1B_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'B';
        }

        private void radType1C_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'C';
        }

        private void radType1D_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'D';
        }

        private void radType2A_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'A';
        }

        private void radType2B_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'B';
        }

        private void radType2C_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'C';
        }

        private void radType2D_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'D';
        }

        private void radType3A_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'A';
        }

        private void radType3B_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'B';
        }

        private void radType3C_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'C';
        }

        private void radType3D_Click(object sender, EventArgs e)
        {
            selectedAns[activeQuestion] = 'D';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnCancel.Visible)
            {
                string filename = "mamatresult.txt";
                StreamWriter file = new StreamWriter(filename, true);
                string aLine = "\r\n";
                int time = 60 - timeLeft;
                aLine = aLine + canName + ":"+
                        country + ":" + maxQuestion + ":" +
                        checkcorrectAns()+":"; ;


                for (int k = 0; k < maxQuestion; k++)
                {
                    aLine = aLine + selectedAns[k] + ":";
                }
                aLine = aLine + time;
                file.Write(aLine);
                file.Close();
                Hide();
                ResultForm resultForm = new ResultForm();
                resultForm.Show();
                //Application.Exit();
            }
            else
            {
                btnCancel.Visible = true;
                btnSubmit.Text = "Submit?";
            }
        }
        private int checkcorrectAns()
        {

            int correctResult = 0;
            for(int k = 0; k < maxQuestion; k++)
            {
                if(selectedAns[k] == correctAns[k])
                {
                    correctResult++;
                }
            }
            return correctResult;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSubmit.Text = "Submit";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            displayQuestion();
        }

        private void timeClock_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft -= 1;
                txtTime.Text = timeLeft + "s";
                picTimeout.Image = Image.FromFile("time.jpg");
                picTimeout.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                btnPrev.Visible = false;
                btnNext.Visible = false;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                labelQue.Visible = false;
                labActiveQuestion.Visible = false;
                groupBox4.Visible = true;
            }

            if(timeLeft == 10)
            {
                lblWarining.Visible = true;
            }
            else
            {
                lblWarining.Visible = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Hide();
            ResultForm rf = new ResultForm();
            rf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
