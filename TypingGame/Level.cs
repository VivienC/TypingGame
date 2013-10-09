using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    // Keep the data for each level
    public struct Level
    {
        public Level(String[] stringWords, int score)
        {
            levelWords = stringWords;
            numOfWords = stringWords.Length;
            scoreForLevelUp = score;
 
        }

        public String[] levelWords;
        public int numOfWords;
        public int scoreForLevelUp;

                
    }
}
