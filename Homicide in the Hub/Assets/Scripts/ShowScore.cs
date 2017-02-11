using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShowScore : MonoBehaviour {

    public Text scoredisplay;

    private int clues_found = NotebookManager.instance.clue_count();
    private int time = (int)GameMaster.instance.get_timer();

    private void set_score(int screen)
    {
        if (screen == 0)
        {
            scoredisplay.text = ("SCORE: \n\n" +
            "Time taken: " + convert_time(time) +
            "\nClues found: " + clues_found + "/9 ") +
            "\n\n Overall Score: " + caluclate_score().ToString("0") + " /100";
        } else
        {
            scoredisplay.text = ("SCORE: \n\n" +
            "Time taken: " + convert_time(time) +
            "\nClues found: " + clues_found + "/9 ") +
            "\n\n Overall Score: 0 /100";

        }
    }

    private string convert_time(int time)
    {
        int mins  = -1;
        int seconds = 0;
        while (time > 0 )
        {
            time = time - 60;
            mins = mins + 1;
        }
        seconds = time + 60;
        if (seconds < 10)
        {
            return mins.ToString() + ":0" + seconds.ToString();
        }
        return mins.ToString() + ":" + seconds.ToString();
    }

    private double caluclate_score()
    {
        double mul;
        if (time <= 90)
        {
            mul = 2;
        } else if ( time <= 150 && time > 91)
        {
            mul = 1.5;
        } else if (time > 151 && time <= 210)
        {
            mul = 1.25;
        } else
        {
            mul = 1;
        }
        return ((clues_found * 5) * mul)+10;
      
    }

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().Equals("Win Screen"))
        {
            set_score(0);
        } else
        {
            set_score(1);
        }
        
    }
}
