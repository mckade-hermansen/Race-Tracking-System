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
using RaceTrackingSystem.Monitor.RaceData;
using AppLayer;

namespace GUI
{
    public partial class ControlForm : Form
    {
        
        private GUIHandler handler;
        private System.Object _lock = new System.Object();

        public ControlForm(GUIHandler hand)
        {
			handler = hand;
            InitializeComponent();
        }

        public void RefreshAthletes()
        {
           
            lock (_lock)
            {
                listView1.Items.Clear();

                foreach (Subject ath in handler.subjects)
                {
                    listView1.Items.Add(ath.BibNumber.ToString());
                }
                this.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedBibIndex = listView1.FocusedItem.Index;
            Console.WriteLine(selectedBibIndex);
            Observer observer = null;
   
            if(observerCheckBoxList.GetItemCheckState(0) == CheckState.Checked)
            {
                MilestoneObserver milestone = new MilestoneObserver();
                observer = milestone;
                handler.subjects[selectedBibIndex].RegisterObserver(observer);
                milestone.Show();
            }
            if(observerCheckBoxList.GetItemCheckState(1) == CheckState.Checked)
            {
                ListObserverForm list = new ListObserverForm();
                observer = list;
                handler.subjects[selectedBibIndex].RegisterObserver(observer);
                list.Show();
            }
            if (observerCheckBoxList.GetItemCheckState(2) == CheckState.Checked)
            {
                PositionObserver pos = new PositionObserver();
                observer = pos;
                handler.subjects[selectedBibIndex].RegisterObserver(observer);
                pos.Show();
            }
            if (observerCheckBoxList.GetItemCheckState(3) == CheckState.Checked)
            {
                Scoreboard score = new Scoreboard(handler);
                observer = score;
                foreach(Subject sub in handler.subjects)
                {
                    sub.RegisterObserver(observer);
                }
                score.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
