using AlthogithmSort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlthogithmSort
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_SelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort Ss = new SelectionSort();
            Ss.ShowDialog();
        }

        private void button_InterchangeSort_Click(object sender, EventArgs e)
        {
            InterchangeSort Is = new InterchangeSort();
            Is.ShowDialog();
        }

        private void button_BubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort Bs = new BubbleSort();
            Bs.ShowDialog();
        }
    }
}
