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

namespace GUI
{
    public partial class PositionObserver : Form, Observer
    {
        public PositionObserver()
        {
            InitializeComponent();
            progressBar1.Maximum = 17000;
        }

        public void Update(AthleteUpdate update)
        {
            if(update.UpdateType == AthleteRaceStatus.OnCourse)
            {
                LocationUpdate temp = (LocationUpdate)update;
                progressBar1.Value = (int)temp.LocationOnCourse;
            }
            if (update.UpdateType == AthleteRaceStatus.Finished)
            {
                progressBar1.Value = 17000;
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // PositionObserver
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "PositionObserver";
        //    this.Load += new System.EventHandler(this.PositionObserver_Load);
        //    this.ResumeLayout(false);

        //}

        private void PositionObserver_Load(object sender, EventArgs e)
        {

        }
    }
}
