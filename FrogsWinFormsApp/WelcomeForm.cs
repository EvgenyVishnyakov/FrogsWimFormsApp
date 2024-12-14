using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrogsWinFormsApp;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }
    private void StartGameButton_Click(object sender, EventArgs e)
    {
        MainForm mainForm = new MainForm();
        mainForm.ShowDialog();
        this.Close();
    }
    private void StartGameButton_MouseHover(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.IndianRed;
    }
    private void StartGameButton_MouseLeave(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.RosyBrown;
    }
}
