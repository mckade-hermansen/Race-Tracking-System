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
    public partial class ListObserverForm : Form, Observer
    {
        public ListObserverForm()
        {
            InitializeComponent();
            listView1.View = View.List;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Update(AthleteUpdate update)
        {           
            listView1.Items.Add(new ListViewItem(update.ToString()));
            this.Refresh();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // ListObserverForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "ListObserverForm";
        //    this.Load += new System.EventHandler(this.ListObserverForm_Load);
        //    this.ResumeLayout(false);

        //}

        private void ListObserverForm_Load(object sender, EventArgs e)
        {

        }

        private void ListObserverForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
