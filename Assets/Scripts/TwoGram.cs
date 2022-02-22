using UnityEngine;

public class TwoGram : MonoBehaviour
{

    public static int kicks;
    private static int leftper, rightper, middleper, lastkick, count, a, nextdir;
    public static float twoperleft, twoperright, twopermiddle;
    // Start is called before the first frame update
    void Start()
    {
        nextdir = 0;
        kicks = 0;
       
    }


    public void Calculation(int[] arr)
    {
        count = 0;
        leftper = 0;
        rightper = 0;
        middleper = 0;
        if (kicks > 0)
        {
            a = kicks;
            lastkick = arr[a];
            for (int i = 0; i < a; i++)
            {
                if (arr[i] == lastkick)
                {
                    if (arr[i + 1] == 1)
                    {
                        leftper++;
                    }

                    else if (arr[i + 1] == 2)
                    {
                        middleper++;
                    }

                    else if (arr[i + 1] == 3)
                    {
                        rightper++;
                    }
                    count++;//number of times lastkick appears in the array

                }
            }
            twoperleft = leftper / (float)count * 100.0f;
            twoperright = rightper / (float)count * 100.0f;
            twopermiddle = middleper / (float)count * 100.0f;

            if (count > 0)
            {
                ResultScript.enoughdata2g = true;
            }

        }

    }

    public int DiveTwo()
    {
        if (twoperleft > twoperright && twoperleft > twopermiddle)
        {
            nextdir = 1;
        }
        else if (twopermiddle > twoperleft && twopermiddle > twoperright)
        {
            nextdir = 2;
        }
        else if (twoperright > twoperleft && twoperright > twopermiddle)
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
