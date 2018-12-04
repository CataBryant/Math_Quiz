using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TimeLeft;
        Random Randomizer = new Random();
        int addend1;
        int addend2;
        public void StartTheQuiz()
        {
            addend1 = Randomizer.Next(51);
            addend2 = Randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
            TimeLeft = 30;
            Time.Text = "30 seconds";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congratsulations! You won a cookie!");
                button1.Enabled = true;
            }
            else
            if(TimeLeft>0)
            {
                TimeLeft--;
                Time.Text = TimeLeft  + " seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Too slow.Try again");
                sum.Value = addend1 + addend2;
                button1.Enabled = true;
            }
        }

        private bool CheckTheAnswer()
        {
            if(addend1 + addend2 == sum.Value )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
