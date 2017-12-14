using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaceTrackingSystem;
using RaceData.Messages;
using RaceData;
using RaceTrackingSystem.Monitor.RaceData;

namespace GUI
{
    public partial class Scoreboard : Form, Observer
    {
        public List<int> athletes = new List<int>();
        private GUIHandler handler;
        public Scoreboard(GUIHandler h)
        {
            InitializeComponent();
            listView1.View = View.List;
            handler = h;
        }

        public void Update(AthleteUpdate update)
        {
            
            if(update.UpdateType == AthleteRaceStatus.Finished)
            {
                athletes.Add(update.BibNumber);
                updateScoreboard();
            }
        }

        public void updateScoreboard()
        {
            listView1.Items.Clear();
            foreach (int bib in athletes)
            {
                listView1.Items.Add(bib.ToString());
            }
        }

        public int findIndex(double score)
        {
            int count = 0;
            foreach (double scr in athletes)
            {
                if (scr == score)
                {
                    return count;
                }
                count++;
            }
            return 0;
        }
    }
}
