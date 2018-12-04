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
    public partial class WinnerForm : Form
    {
        private static string[] countries;
        private static string[] country;
        private int numRecord;
        private Winners[] wins;

        public WinnerForm()
        {
            InitializeComponent();
            loadCandidates();
        }

        // Timer to change color of the text on every tick, creating flashing effects
        private void tmrWinner_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label7.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void loadCandidates()
        {
            candidates cans = new candidates();
            List<candidates> canlist = cans.getCans();

            numRecord = canlist.Count;
            countries = new string[numRecord];
            for(int i = 0; i < numRecord; i++)
            {
                candidates can = canlist[i];
                countries[i] = can.getCountry();
            }

            country = countries.Distinct().ToArray();

            UpdateWinners(canlist);
        }

        public void UpdateWinners(List<candidates> canlist) 
        {
            int numCountry = country.Length;
            wins = new Winners[numCountry]; 
            for (int k = 0; k < country.Length; k++)
            {
                wins[k] = new Winners(country[k]);
            }

            for (int i = 0; i < numRecord; i++)
            {
                candidates can = canlist[i];
                string name = can.getName();
                string con = can.getCountry();
                int totQuestion = can.getTotQ();
                int totCorrectAns = can.getTotCA();
                int time = can.getTime();
                
                for(int k = 0; k < wins.Length; k++)
                {
                    if(wins[k].getCuntry() == con)
                    {
                        wins[k].updateWinners(totQuestion, totCorrectAns, time, i);
                    }
                }
            }

            for( int i = 0; i < wins.Length; i++)
            {
                wins[i].addWinner(wins[i]);
                //Console.WriteLine(wins[i].getCuntry());
                //Console.WriteLine(wins[i].getPercentage());
            }

            loadWinners();
        }

        public void loadWinners()
        {
            string[] country = wins[0].sortWinnersCountry(); 

            //set the 1st 
            for(int i = 0; i < wins.Length; i++)
            {
                if(country[0] == wins[i].getCuntry())
                {
                    picWin1.Image = Image.FromFile(findPicPath(wins[i].getCuntry()));
                    lblCountry1.Text = wins[i].getCuntry();
                    lblName1.Text = wins[i].getCandidatesNames();
                    lbltime1.Text = wins[i].getTime().ToString();
                    lblscore1.Text = wins[i].getPercentage().ToString();
                }
                else if (country[1] == wins[i].getCuntry())
                {
                    picWin2.Image = Image.FromFile(findPicPath(wins[i].getCuntry()));
                    lblCountry2.Text = wins[i].getCuntry();
                    lbltime2.Text = wins[i].getTime().ToString();
                    lblscore2.Text = wins[i].getPercentage().ToString();
                }
                else if (country[2] == wins[i].getCuntry())
                {
                    picWin3.Image = Image.FromFile(findPicPath(wins[i].getCuntry()));
                    lblCountry3.Text = wins[i].getCuntry();
                    lbltime3.Text = wins[i].getTime().ToString();
                    lblscore3.Text = wins[i].getPercentage().ToString();
                }
            }
        }

        private string findPicPath(string country)
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

            return picPath;
        }
    }
}
