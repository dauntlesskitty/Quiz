using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Windows
{
    public class candidates
    {
        private string name;
        private string country;
        private int totQuestion;
        private int totCorrect;
        private int time;
        private string ans;
        private string percentage;
        public static List<candidates> candidate = new List<candidates>();

        public candidates()
        {

        }

        public candidates(string n, string con,int totQ, int totCA, string an,int tim)
        {
            name = n;
            country = con;
            totQuestion = totQ;
            totCorrect = totCA;
            ans = an; //Answers
            time = tim; //Time taken to finish
            double perC = (double)totCA / (double)totQ * 100; //Calculate percentage of correct Answers
            perC = Math.Round(perC, 2); //Rounding up to 2 decimals
            percentage = perC.ToString()+"%";
        }

        public int getAllCandidateNum()
        {
            return candidate.Count;
        }

        public void addCandidate(candidates can)
        {
            candidate.Add(can);
        }

        public List<candidates> getCans()
        {
            return candidate;
        }

        public string getName()
        {
            return name;
        }

        public string getCountry()
        {
            return country;
        }

        public int getTotQ()
        {
            return totQuestion;
        }

        public int getTotCA()
        {
            return totCorrect;
        }

        public int getTime()
        {
            return time;
        }

        public string getPer()
        {
            return percentage;
        }

        public string getAns()
        {
            return ans;
        }
    }
}
