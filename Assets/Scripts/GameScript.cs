using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public static int[] arr;
    public static int i;
    public int a;
    public TwoGram twogram;
    public ThreeGram threegram;
    

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        arr = new int[200];

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
        twogram.Calculation(arr);
        threegram.Calculation(arr);
        TwoGram.kicks++;
        ThreeGram.kicks++;
        ScoreScript.ScoreVal++;
    }
}
