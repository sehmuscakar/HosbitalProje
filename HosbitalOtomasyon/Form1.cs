using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosbitalOtomasyon
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoktorlarPaeli fr = new frmDoktorlarPaeli();// her form bir class tır. nesne aldık
            fr.Show();//nesneyi açtık
          //  this.Hide(); //gizleme yaptık
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonePaneli fr= new frmPersonePaneli();
            fr.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          frmHastalarPaneli fr= new frmHastalarPaneli();
            fr.Show();
            
        }

       
    }
}
