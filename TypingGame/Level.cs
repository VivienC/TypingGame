using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    // Keep the data for each level
    public struct Level
    {
        public Level(String[] stringWords, int score, int speed)
        {
            levelWords = stringWords;
            numOfWords = stringWords.Length;
            scoreForLevelUp = score;
            levelSpeed = speed;
 
        }

        public String[] levelWords;
        public int numOfWords;
        public int scoreForLevelUp;
        public int levelSpeed;

                
    }
}
