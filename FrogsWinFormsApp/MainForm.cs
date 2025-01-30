using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrogsWinFormsApp;

public partial class MainForm : Form
{
    private int countStep = 0;
    private int minStep = 24;

    public MainForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void Swap(PictureBox clickedPicture)
    {
        var location = clickedPicture.Location;
        int distatnce = GetDistance(clickedPicture);
        if (distatnce > 1)
        {
            MessageBox.Show("Так наши лягушонки не прыгают!");
        }
        else
        {
            GetSwapPlace(clickedPicture, location);
            countStep++;
            CountStepLabel.Text = countStep.ToString();
        }

        if (GetPlacementLeftFrogs(clickedPicture) && GetPlacementRightFrogs(clickedPicture))
        {
            StopFrogMove();
            if (countStep == minStep)
            {
                GetWinnerInfo();
                GetConfirmPlayAgain();
            }
            else
            {
                InfoLabelAfterEnd.Visible = true;
                GetConfirmPlayAgain();
            }
        }
    }

    private void GetWinnerInfo()
    {
        WinTextLabel.Visible = true;
        WinPictureBox.Visible = true;
        VictoryPictureBox.Visible = true;
    }

    private void GetConfirmPlayAgain()
    {
        ContinueGameLabel.Visible = true;
        PlayButton.Visible = true;
        StopGameButton.Visible = true;
    }

    private bool GetPlacementLeftFrogs(PictureBox clickedPicture)
    {
        return FrogPictireBox4.Location.X > Location.X && FrogPictureBox3.Location.X > Location.X && FrogPictureBox2.Location.X > Location.X && FrogPictureBox1.Location.X > Location.X;
    }

    private bool GetPlacementRightFrogs(PictureBox clickedPicture)
    {
        return FrogPictureBox5.Location.X < Location.X - FrogPictureBox5.Width && FrogPictureBox6.Location.X < Location.X - FrogPictureBox6.Width && FrogPictureBox7.Location.X < Location.X - FrogPictureBox7.Width && FrogPictureBox8.Location.X < Location.X - FrogPictureBox8.Width;
    }

    private void StopFrogMove()
    {
        FrogPictureBox1.Enabled = false;
        FrogPictureBox2.Enabled = false;
        FrogPictureBox3.Enabled = false;
        FrogPictireBox4.Enabled = false;
        FrogPictureBox5.Enabled = false;
        FrogPictureBox6.Enabled = false;
        FrogPictureBox7.Enabled = false;
        FrogPictureBox8.Enabled = false;
    }

    private void GetSwapPlace(PictureBox clickedPicture, Point location)
    {
        clickedPicture.Location = EmptyPictureBox.Location;
        EmptyPictureBox.Location = location;
    }

    private int GetDistance(PictureBox clickedPicture)
    {
        return Math.Abs(clickedPicture.Location.X - EmptyPictureBox.Location.X) / EmptyPictureBox.Size.Width;
    }

    private void PictireBox_Click(object sender, EventArgs e)
    {
        Swap((PictureBox)sender);
    }

    private void PlayButton_MouseHover(object sender, EventArgs e)
    {
        PlayButton.BackColor = Color.IndianRed;
    }

    private void PlayButton_MouseLeave(object sender, EventArgs e)
    {
        PlayButton.BackColor = Color.RosyBrown;
    }

    private void StopGameButton_MouseHover(object sender, EventArgs e)
    {
        StopGameButton.BackColor = Color.IndianRed;
    }

    private void StopGameButton_MouseLeave(object sender, EventArgs e)
    {
        StopGameButton.BackColor = Color.RosyBrown;
    }

    private void StopGameButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void PlayButton_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.ShowDialog();
        Close();
    }
}
