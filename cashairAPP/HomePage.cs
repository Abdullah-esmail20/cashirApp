using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cashairAPP
{
    public partial class homeBage : Form
    {
        

        public homeBage()
        {
            InitializeComponent();
        }
      
        private void الواجههToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem2.Checked)
            {
                Form fr1= new homeBage();
                fr1.Show(); 
            }
        }

       

       

      

        private void TBCLIPS_Click(object sender, EventArgs e)
        {
            Form fr1 = new ChipsBage();
            fr1.Show();
            this.Hide();

        }

        private void TBFool_Click(object sender, EventArgs e)
        {

            Form fr1 = new FooditemsBage();
            fr1.Show();
            this.Hide();

        }

        private void TBDri_Click(object sender, EventArgs e)
        {

            Form fr1 = new DrinksBage();
            fr1.Show();
            this.Hide();

        }

        private void TBPou_Click(object sender, EventArgs e)
        {

            Form fr1 = new PoultryBage();
            fr1.Show();
            this.Hide();

        }

        private void TBclean_Click(object sender, EventArgs e)
        {
            Form fr1 = new CleaningBage();
            fr1.Show();
            this.Hide();
        }

        private void TBVegetables_Click(object sender, EventArgs e)
        {
            Form fr1 = new vegetables();
            fr1.Show();
            this.Hide();

        }
    }
}
