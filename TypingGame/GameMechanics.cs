﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class GameMechanics
    {
        // Game mechanics
        List<Level> level = new List<Level>();
        Random randomNum = new Random();

        public int userScore { get; private set; }
        
        public int currentLevel { get; private set; }
        public int requiredScore { get; private set; }
        public bool updateLevelAndRequiredScore { get; private set; }        

        public GameMechanics()
        {
            initializeGameData();
            userScore = 0;
            currentLevel = 0;
            requiredScore = level[currentLevel].scoreForLevelUp;
            updateLevelAndRequiredScore = true;
            
        }

        public string getWord()
        {
            // Random pick a word fromthe current level's list
            return level[currentLevel].levelWords[randomNum.Next(level[currentLevel].numOfWords)];

        }

        public bool isAnswerRight(string userAnswer)
        {
            // Set these flags to false to control score and level updates
            updateLevelAndRequiredScore = false;

            // The user had typed a space, so check if their word
            // matches the list of game words and pass result to update game data
            return updateGameData(level[currentLevel].levelWords.Contains(userAnswer));;
        }

        private bool updateGameData(bool answerIsCorrect)
        {
            if (answerIsCorrect)
            {
                // increment their score and change flag
                userScore++;

                // Check for level up
                if (userScore >= level[currentLevel].scoreForLevelUp)
                {
                    currentLevel++;
                    requiredScore = level[currentLevel].scoreForLevelUp;
                    updateLevelAndRequiredScore = true;

                }
            }
            else
            {
                userScore = 0;
            }

            return answerIsCorrect;

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