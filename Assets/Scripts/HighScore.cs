using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[System.Serializable]
public class HighScore
{
    public string UserName;
    public int Score;

    public HighScore()
    {
        UserName = "Anonymous";
        Score = 0;
    }
}
