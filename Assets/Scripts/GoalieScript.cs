using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalieScript : MonoBehaviour
{
    public static int[] arr;
    public static int i, kick, divevalue;
    public int a;
    public Text score1, side;
    public TwoGram twogram;
    public ThreeGram threegram;
    public static int highscore, score;


    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        arr = new int[200];
        kick = 0;
        //divevalue = 0;
        highscore = 0;
        score = 0;
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetInt("highscore");
        }
        else
        {
            PlayerPrefs.SetInt("highscore", 0);
        }
        divevalue = Random.Range(1, 4);

    }

    void Update()
    {

    }

    //UpdateArray is used to take in button inputs
    //left button gives value of a=1
    //middle button gives value of a=2
    //right button gives value of a=3
    public void UpdateArray(int a)
    {
        arr[i] = a; //input value of a stored in array
        i++; //next array slot
        kick++; //increment number of kicks
        /*if (kick < 2)
        {
            //random dives
            divevalue = Random.Range(1, 4);
            Save(divevalue, a);
        }*/
        

        if (kick < 30)
        {
            Save(divevalue, a);
            twogram.Calculation(arr);
            divevalue = GetComponent<TwoGram>().DiveTwo();
        }

        else
        {
            Save(divevalue, a);
            threegram.Calculation(arr);
            divevalue = GetComponent<ThreeGram>().Divethree();
        }
        TwoGram.kicks++;
        ThreeGram.kicks++;
        //Save(divevalue, a);
    }

    public void Save(int s, int a)
    {
        if (s != a)//scored
        {
            this.score1.text = "" +kick;

            if(s == 1)
            {
                this.side.text = "LEFT";
            }

            else if (s == 2)
            {
                this.side.text = "CENTER";
            }

            else
            {
                this.side.text = "RIGHT";                
            }
        }

        else   //saved
        {
            score = kick - 1;
            if(score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore", highscore);
            }
            SceneManager.LoadScene("ScoreScene");
            
        }
        GameScore.saved = true;
        return;
    }
}
