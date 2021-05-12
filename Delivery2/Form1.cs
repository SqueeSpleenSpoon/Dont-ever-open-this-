using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Courier form = new Courier();

            form.ShowDialog();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();

            form.ShowDialog();

        }

        private void ownTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnTransport form = new OwnTransport();

            form.ShowDialog();

        }

        private void firmsTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmsTransport form = new FirmsTransport();

            form.ShowDialog();

        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goods form = new Goods();

            form.ShowDialog();

        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery form = new Delivery();

            form.ShowDialog();

        }
    }
}
