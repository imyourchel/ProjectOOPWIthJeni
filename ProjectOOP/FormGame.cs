using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PapayaWhip;
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ToolStripMenuItem.Visible = false;
            panelCreatePlayer.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;            
            panelCreatePlayer.Visible = true;
            buttonExit.Visible = false;
            buttonStart.Visible = false;
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem.Visible = true;
                panelCreatePlayer.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.Visible = true;
            buttonStart.Visible = true;
        }
    }
}
