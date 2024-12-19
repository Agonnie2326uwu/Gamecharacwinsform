using Gamecharacwinsform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace Gamecharacwinsform
{
    public partial class Form1 : Form
    {
       
        private List<GameCharacter> characterCollection = new List<GameCharacter>();
        private GameCharacter selectedCharacter;
        public static Form1 Instace;
        public GameCharacter createdCharacter;

        public Form1()
        {
            InitializeComponent();
              
            Instace = this;
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int level = int.Parse(txtLevel.Text);
            int health = int.Parse(txtHealth.Text);

            GameCharacter newCharacter;

            if (cmbCharacterType.SelectedItem.ToString() == "Warrior")
            {
                int strength = int.Parse(txtStrength.Text);
                newCharacter = new Warrior(name, level, health, strength);
            }
            else if (cmbCharacterType.SelectedItem.ToString() == "Mage")
            {
                int mana = int.Parse(txtMana.Text);
                int intelligence = int.Parse(txtIntelligence.Text);
                newCharacter = new Mage(name, level, health, mana, intelligence);
            }
            else
            {
                MessageBox.Show("Please select a valid character type.");
                return;
            }

           
            characterCollection.Add(newCharacter);
            listBoxCharacters.Items.Add(newCharacter.Name);
            MessageBox.Show($"{newCharacter.Name} added to your collection!");

        }

        private void btnSelectCharacter_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedIndex >= 0)
            {
                selectedCharacter = characterCollection[listBoxCharacters.SelectedIndex];
                
                MessageBox.Show($"{selectedCharacter.Name} selected!");
            }
            else
            {
                MessageBox.Show("Please select a character from the list.");
            }

        }


        private void cmbCharacterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCharacterType.SelectedItem.ToString() == "Warrior")
            {
                txtStrength.Enabled = true;
                txtMana.Enabled = false;
                txtIntelligence.Enabled = false;

            }
            else if (cmbCharacterType.SelectedItem.ToString() == "Mage")
            {
                txtMana.Enabled = true;
                txtIntelligence.Enabled = true;
                txtStrength.Enabled = false;

            }
            else
            {
                MessageBox.Show("Please select a valid character type.");
                return;
            }

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            createdCharacter = selectedCharacter;
            
            this.Hide();    
            Form2 f2 = new Form2();
            f2.Show();
        }

      
    }
}
