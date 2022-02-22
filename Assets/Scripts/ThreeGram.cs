using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeGram : MonoBehaviour
{

    public static int kicks;
    private int leftper, rightper, middleper, lastkick, secondlastkick, count, a, nextdir;
    public static float threeperleft, threeperright, threepermiddle;
    // Start is called before the first frame update
    void Start()
    {
        kicks = 0;
        nextdir = 0;
       
    }


    public void Calculation(int[] arr)
    {
        count = 0;
        leftper = 0;
        rightper = 0;
        middleper = 0;
        if (kicks > 1)
        {
            a = kicks;
            lastkick = arr[a];
            secondlastkick = arr[a - 1];
            for (int i = 0; i < (a - 1); i++)
            {
                if (arr[i] == secondlastkick && arr[i + 1] == lastkick)
                {
                    if (arr[i + 2] == 1)
                    {
                        leftper++;
                    }

                    else if (arr[i + 2] == 2)
                    {
                        middleper++;
                    }

                    else if (arr[i + 2] == 3)
                    {
                        rightper++;
                    }
                    count++;//number of times lastkick appears in the array
                }
            }


            threeperleft = (leftper / (float)count) * 100.0f;
            threeperright = (rightper / (float)count) * 100.0f;
            threepermiddle = (middleper / (float)count) * 100.0f;

            if (count > 0)
            {
                ResultScript.enoughdata3g = true;
            }

        }
    }

    public int Divethree()
    {
        if (threeperleft > threeperright && threeperleft > threepermiddle)
        {
            nextdir = 1;
        }
        else if (threepermiddle > threeperleft && threepermiddle > threeperright)
        {
            nextdir = 2;
        }
        else if (threeperright > threeperleft && threeperright > threepermiddle)
        {
            nextdir = 3;
        }
        else
        {
            nextdir = Random.Range(1, 4);
        }
        return nextdir;
    }
}
