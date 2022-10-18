using System;
using System.Drawing;
using System.Windows.Forms;

namespace DZ6_1
{
    public partial class Form1 : Form
    {
        new readonly MenuStrip Menu;
        public Form1()
        {
            InitializeComponent();
            Menu = new MenuStrip();
            MainMenuStrip = Menu;
            Controls.Add(Menu);
        }

        private void BtnTopLevelMenu_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text == "")
            {
                TopLevelMenu.BackColor = Color.Red;
                MessageBox.Show("Укажите название пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Menu.Items.Add(TopLevelMenu.Text);
                TopLevelMenu.BackColor = Color.Green;
                MessageBox.Show($"{TopLevelMenu.Text} - добавлен в меню", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSubItem_Click(object sender, EventArgs e)
        {
            if (Menu.Items.Count < 1)
                MessageBox.Show("У вас нет ни одного пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TopLevelMenu.Text == "")
            {
                TopLevelMenu.BackColor = Color.Red;
                MessageBox.Show("Укажите название пункта меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SubItem.Text == "")
            {
                SubItem.BackColor = Color.Red;
                MessageBox.Show("Укажите название пункта подменю", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < Menu.Items.Count; i++)
                    if (Menu.Items[i].Text == TopLevelMenu.Text)
                    {
                        ((ToolStripMenuItem)Menu.Items[i]).DropDownItems.Add(SubItem.Text);
                        SubItem.BackColor = Color.Green;
                        MessageBox.Show($"{SubItem.Text} - добавлен в меню - {TopLevelMenu.Text}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                TopLevelMenu.BackColor = Color.Red;
                MessageBox.Show($"{TopLevelMenu.Text} - нет такого меню", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Level_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
