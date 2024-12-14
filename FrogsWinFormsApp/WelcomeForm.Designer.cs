namespace FrogsWinFormsApp
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartGameButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StartGameButton
            // 
            StartGameButton.BackColor = System.Drawing.Color.RosyBrown;
            StartGameButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            StartGameButton.Location = new System.Drawing.Point(264, 333);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new System.Drawing.Size(229, 90);
            StartGameButton.TabIndex = 0;
            StartGameButton.Text = "Начать игру!!!";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGameButton_Click;
            StartGameButton.MouseLeave += StartGameButton_MouseLeave;
            StartGameButton.MouseHover += StartGameButton_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Снимок_экрана_2024_05_12_1610047;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.Правила_игры1;
            pictureBox1.InitialImage = Properties.Resources.Снимок_экрана_2024_05_12_1610044;
            pictureBox1.Location = new System.Drawing.Point(167, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(455, 302);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(StartGameButton);
            Name = "WelcomeForm";
            Text = "Лягушки, приветствие ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}