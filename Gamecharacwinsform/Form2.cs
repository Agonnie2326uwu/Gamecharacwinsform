using Gamecharacwinsform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecharacwinsform
{
    public partial class Form2 : Form
    {
        private GameCharacter selectedCharacter;
        public Form2()
        {
            InitializeComponent();
            selectedCharacter = Form1.Instace.createdCharacter;

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }
            selectedCharacter.Attack();
            battleLog.Items.Add($"{selectedCharacter.Name} performed an attack.");
            txtCharacterDetails.Text = selectedCharacter.ToString();

        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }
            selectedCharacter.Defend();
            battleLog.Items.Add($"{selectedCharacter.Name} defended.");
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }
            selectedCharacter.LevelUp();
            battleLog.Items.Add($"{selectedCharacter.Name} leveled up.");
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}