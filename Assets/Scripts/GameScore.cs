using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    // Start is called before the first frame update

    public Text ScoreText, HS;
    public static bool saved = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(saved)
        {
            this.ScoreText.text = "" + GoalieScript.score.ToString();
            this.HS.text = "" + GoalieScript.highscore.ToString();
        }

    }
}
