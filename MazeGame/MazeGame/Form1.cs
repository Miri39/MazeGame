using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer _startGameSound =
            new System.Media.SoundPlayer(
                @"C:\Users\MIRI\OneDrive\Desktop\gdsc\C#\MazeGame\MazeGame\StartGameSound.wav");

        private System.Media.SoundPlayer _deadPlayerSound =
            new System.Media.SoundPlayer(
                @"C:\Users\MIRI\OneDrive\Desktop\gdsc\C#\MazeGame\MazeGame\DeadPlayerSound.wav");
        
        private System.Media.SoundPlayer _winGameSound =
            new System.Media.SoundPlayer(
                @"C:\Users\MIRI\OneDrive\Desktop\gdsc\C#\MazeGame\MazeGame\WinGameSound.wav");
        
        
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
            _startGameSound.Play();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10,10);
            Cursor.Position = PointToScreen(startingPoint);
        }


        private void FinishLabel_MouseEnter_1(object sender, EventArgs e)
        {
            _winGameSound.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void wallMouseEnter(object sender, EventArgs e)
        {
            _deadPlayerSound.Play();
            MoveToStart();
        }
    }
}