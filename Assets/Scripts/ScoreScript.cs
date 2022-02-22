using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreVal;
    public Text Score;
   
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
        ScoreVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "" +ScoreVal ;
    }
}
