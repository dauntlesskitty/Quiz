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
    public partial class ResultForm : Form
    {
        private static candidates candidate = new candidates();
        private static List<candidates> canlist = new List<candidates>();

        public ResultForm()
        {
            InitializeComponent();
            loadCandidateFile();
        }

        private void loadCandidateFile()
        {
            StreamReader datafile;          
            try
            {
                datafile = new StreamReader("mamatresult.txt");
                while (datafile.Peek() != -1)
                {
                    string line = datafile.ReadLine();
                    string[] wordlist = Regex.Split(line, @":"); //Providing delimeter every after[x]
                    string canName = wordlist[0];
                    string country = wordlist[1];
                    int maxQuestion = Convert.ToInt32(wordlist[2]);
                    int corAns = Convert.ToInt32(wordlist[3]); //Correct Answers
                    string ans = ""; //if Candidate does not answer and empty string will be added
                    for(int i = 4; i< wordlist.Length-2; i++)
                    {
                        ans = ans + wordlist[i] + " , ";
                    }
                    int time = Convert.ToInt32(wordlist[wordlist.Length - 1]);

                    candidate = new candidates(canName, country, maxQuestion, corAns, ans, time);
                    candidate.addCandidate(candidate);
                }

                datafile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORRRR : " + ex.Message);
            }
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            canlist = candidate.getCans();
            for(int k = 0; k < candidate.getAllCandidateNum(); k++)
            {
                string name = canlist[k].getName();
                conList.Items.Add(name);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            resultBox.Visible = true;
            string conName = conList.SelectedItem.ToString();
            txtName.Text = conName;
            string country;

            for (int i = 0; i < canlist.Count; i++)
            {
                if (canlist[i].getName() == conName)
                {
                    country = canlist[i].getCountry();
                    setPic(country);
                    int totQ = canlist[i].getTotQ();
                    int totCA = canlist[i].getTotCA();
                    txtScore.Text = totCA + " / " + totQ;
                    txtTime.Text = canlist[i].getTime().ToString();
                    txtAns.Text = canlist[i].getAns();
                    lblPer.Text = canlist[i].getPer();

                }
            }

        }

        public void setPic(string country)
        {
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

            countryPic.Image = Image.FromFile(picPath);
            countryPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            WinnerForm winner = new WinnerForm();
            winner.Show();
        }
    }
}
