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
    public partial class ContestEntryForm : Form
    {
        private static string passpostNum;
        private static string country;
        private static string canName;
        private static string photo;
        private bool ifCandidate;

        public ContestEntryForm()
        {
            InitializeComponent();
        }

        private void loadCandidateFile()
        {
            StreamReader datafile;
            string aLine;
            try
            {
                datafile = new StreamReader("candidates.txt"); 
                int k = 0;
                while (datafile.Peek() != -1)
                {
                    aLine = datafile.ReadLine();
                    string[] contentsDetail = Regex.Split(aLine, @":"); //Split each word with :

                    if (contentsDetail[0]==passpostNum && contentsDetail[1] == country) //Check whether match
                    {
                        ifCandidate = true;
                        photo = contentsDetail[2];
                        canName = contentsDetail[3];
                        lblMessage.Text = "Success log in, please click next.";
                        break;
                    }

                    ifCandidate = false;
                    k++;
                }
                datafile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORRRR : " + ex.Message);
            }
        }

        private void ContestEntryForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            passpostNum = txtPassport.Text;
            country = cboCountry.Text;
            loadCandidateFile(); //Check candidate in txt file whether exist

            if (ifCandidate == true)
            {
                lblMessage.Text = "Success log in, please click next.  Welcome "+ getCanName() + " !";
                pic1.Image = Image.FromFile(photo);
                groupBox1.Visible = true;
            }
            else
            {
                lblMessage.Text = "Wrong candidate. Please submit again";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm testForm = new TestForm(); //Begin Test
            testForm.Show();
        }

        public string getPassportNum()
        {
            return passpostNum;
        }

        public string getCountry()
        {
            return country;
        }

        public string getCanName()
        {
            return canName;
        }

        public string getCanNum()
        {
            return passpostNum;
        }
    }
}
