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

namespace GUI
{
    public partial class MilestoneObserver : Form, Observer
    {

        static string prevUpdate = "";
        public MilestoneObserver()
        {
            InitializeComponent();
            listView1.View = View.List;
        }

        public void Update(AthleteUpdate update)
        {
            Console.WriteLine(prevUpdate);
            if (prevUpdate != "")
            {
                if (prevUpdate != $"{update.UpdateType}")
                {
                    listView1.Items.Add(new ListViewItem(update.ToString()));
                    prevUpdate = $"{update.UpdateType}";
                }
            }
            else
            {
                prevUpdate = $"{update.UpdateType}";
                listView1.Items.Add(new ListViewItem(update.ToString()));
                
            }
        }
    }
}
