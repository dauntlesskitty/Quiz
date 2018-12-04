using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Windows
{
    public class Winners
    {
        private string country;
        private static string[] wincountry = new string[2];
        private int totQ;
        private int totCorrect;
        private int time;
        public static List<int> canIndex = new List<int>();
        public static List<Winners> winlist = new List<Winners>();

        public Winners()
        {

        }
        public Winners(string c)
        {
            country = c;
            totQ = 0;
            totCorrect = 0;
            time = 0;
        }

        public void addWinner(Winners win)
        {
            winlist.Add(win);
        }

        public List<Winners> getWinners()
        {
            return winlist;
        }

        public void updateWinners(int tq, int ta, int tim, int index)
        {
            totQ = totQ + tq;
            totCorrect = totCorrect + ta;
            time = time + tim;
            canIndex.Add(index);
        }

        public string getCuntry()
        {
            return country;
        }

        public int getTotQ()
        {
            return totQ;
        }

        public int getCA()
        {
            return totCorrect;
        }

        public int getTime()
        {
            return time;
        }

        public double getPercentage()
        {
            double perC = (double)getCA() / (double)totQ * 100;
            perC = Math.Round(perC, 2);
            return perC;
        }

        public string getCandidatesNames()
        {
            string names = "";

            candidates cans = new candidates();
            List<candidates> canlist = cans.getCans();

            for(int i = 0; i< canlist.Count; i++)
            {
                if(canlist[i].getCountry() == wincountry[0])
                {
                    names = names + canlist[i].getName() + " ; ";
                }
            }

            return names;
        }

        public string[] sortWinnersCountry()
        {
            wincountry = new string[winlist.Count];
            List<double> scores = new List<double>();
            for(int i = 0; i< winlist.Count; i++)
            {
                scores.Add(winlist[i].getPercentage());
            }

            scores.Sort();
            scores.Reverse();
            for(int i = 0; i < winlist.Count; i++)
            {
                
                for(int k = 0; k < scores.Count; k++)
                {
                    if(winlist[i].getPercentage() == scores[k])
                    {
                        wincountry[k] = winlist[i].getCuntry();
                    }
                }
            }

           /* for(int k = 0; k<country.Length; k++)
                Console.WriteLine("Sorted country: " + country[k]);*/

            return wincountry;
        }

    }
}
