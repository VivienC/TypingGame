using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Form data        
        List<Label> gameLabels = new List<Label>();
        string userInput = "";
        GameMechanics gameMechanics = new GameMechanics();
        Random randomNum = new Random();

        public Form1()
        {
            InitializeComponent();

            updateGameDataLabels();
            addNewGameLabel();
            timer1.Start();
        }

        // Move the labels and create a new label on every tick of the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move the labels
            foreach (Label label in gameLabels)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + 40);
            }

            // TODO: use game mechanics class to supply text
            addNewGameLabel();

            // If the first label goes off the playing area remove it from the list.
            if (gameLabels[0].Location.Y >= 500)
            {
                gameLabels[0].Visible = false;
                gameLabels.RemoveAt(0);
            }
        }
       
        // Create a new label using the words from the current level.
        // Format the label and add it to the list of current game labels.
        private void addNewGameLabel()
        {
            // Create a label and add it to the list
            Label label = new Label();
            label.Text = gameMechanics.getWord();
            label.Location = new Point(randomNum.Next(350), 5);
            label.AutoSize = true;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Visible = true;
            label.Parent = panel1;
            gameLabels.Add(label);
        }

        // Event handler to collect and check user input. If correct,
        // remove it from list
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Keep collecting the user input until they type a space
            if (e.KeyChar != ' ')
            {
                userInput += e.KeyChar;
                return;
            }


            // The user has typed a space so check the answer
            if (gameMechanics.isAnswerRight(userInput))
            {
                int labelIndex = 0;

                // The user has typed a correct word, so find its index
                foreach (Label label in gameLabels)
                {
                    if (label.Text == userInput)
                    {
                        labelIndex = gameLabels.IndexOf(label);

                        // Game Words can be repeated in the list.
                        // Break here so that the first correct one found
                        // is removed.
                        break;
                    }
                }

                // Hide the label and remove it from the list
                gameLabels[labelIndex].Visible = false;
                gameLabels.RemoveAt(labelIndex);
            }

            updateGameDataLabels();

            // Clear the user input, for the next try
            userInput = "";
        }

        private void updateGameDataLabels()
        {
            // Update Score
            scoreText.Text = "Score: " + gameMechanics.userScore;

            // Update Level and Required Score if required
            if (gameMechanics.updateLevelAndRequiredScore)
            {
                levelText.Text = "Level: " + (gameMechanics.currentLevel + 1);
                needText.Text = "Need: " + gameMechanics.requiredScore;
            }

            timer1.Interval = gameMechanics.levelSpeed;
        }

        

    }
}
