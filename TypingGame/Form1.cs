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
        List<Level> level = new List<Level>();
        Random randomNum = new Random();
        List<Label> gameLabels = new List<Label>();
        string userInput = "";
        int userScore = 0;
        int currentLevel = 0;
        
        public Form1()
        {
            InitializeComponent();
            initializeGameData();

            // Initialize text boxes
            levelText.Text = "Level: " + (currentLevel+1);
            scoreText.Text = "Score: " + userScore;
            needText.Text = "Need: " + level[currentLevel].scoreForLevelUp;
            addNewGameLabel();
            
            timer1.Start();
        }

        // Move the labels and create a new label on every tick of the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Label label in gameLabels)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + 40);
            }

            addNewGameLabel();

            // If a label goes off the playing area remove it from the list.
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
            label.Text = level[currentLevel].levelWords[randomNum.Next(level[currentLevel].numOfWords)];
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

            int labelIndex = 0;
            bool userInputCorrect = false;

            // The user had typed a space, so check if their word
            // matches the list of game words
            foreach (Label label in gameLabels)
            {
                if (label.Text == userInput)
                {
                    // Their word matches, so take note of the index
                    // and hide the label
                    label.Visible = false;
                    labelIndex = gameLabels.IndexOf(label);
                    userInputCorrect = true;                    

                    // Game Words can be repeated in the list.
                    // Break here so that the first correct one found
                    // is removed.
                    break;
                }
            }

            // Remove the label
            if (userInputCorrect)
            {
                // increment their score
                userScore++;
                scoreText.Text = "Score: " + userScore;
                
                gameLabels.RemoveAt(labelIndex);
                
            }
            else
            {
                // reset their score
                userScore = 0;
                scoreText.Text = "Score: " + userScore;
            }

            // Check for level up
            if (userScore >= level[currentLevel].scoreForLevelUp)
            {
                currentLevel++;
                levelText.Text = "Level: " + (currentLevel+1);
                needText.Text = "Need: " + level[currentLevel].scoreForLevelUp;
                
                userScore = 0;
                scoreText.Text = "Score: " + userScore;
            }

            // Clear the user input, for the next try
            userInput = "";
        }

        // Setup the words for each of the levels
        private void initializeGameData()
        {


            String[] level1Words = {"a", "s", "d", "f", "g",
                                    "h", "j", "k", "l", ";"};
            level.Add(new Level(level1Words, 5));

            String[] level2Words = {"has", "alas", "gad;",
                                    "lad", "jak;", ";;;;",
                                    "had","fad", "kl;",
                                    "sad", "glad"};
            level.Add(new Level(level2Words, 15));

            String[] level3Words = {"q", "w", "e", "r", "t",
                                    "y", "u", "i", "o", "p"};
            level.Add(new Level(level3Words, 10));

            String[] level4Words = {"qwert", "yuiop",
                                    "wet", "yet", "put",
                                    "quit", "weep;", "wipe",
                                    "tip","out"};
            level.Add(new Level(level4Words, 15));

            String[] level5Words = {"z", "x", "c", "v", "b",
                                    "n", "m", ",", ".", "/"};
            level.Add(new Level(level5Words, 10));

            String[] level6Words = {"zxcvb", "nm,./",
                                    "nxc", "vmn", "z,.",
                                    "bv.n", "mx,", "/cv",
                                    "bxm","xxz"};
            level.Add(new Level(level6Words, 15));

            String[] level7Words = {"1", "2", "3", "4", "5",
                                    "6", "7", "8", "9", "0"};
            level.Add(new Level(level7Words, 10));

            String[] level8Words = {"12345", "67890",
                                    "876", "123", "934",
                                    "037", "892", "246",
                                    "029","715"};
            level.Add(new Level(level8Words, 15));
        }

    }
}
