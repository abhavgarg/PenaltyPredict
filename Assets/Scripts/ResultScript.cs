using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    public Text Text1, Text2, Text3, Text4, Text5, Text6, Text7, Text8;
    public static bool enoughdata2g = false;
    public static bool enoughdata3g = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(enoughdata2g)
        {
            this.Text1.text = "" + TwoGram.twoperleft.ToString("F") + "%";
            this.Text2.text = "" + TwoGram.twopermiddle.ToString("F") + "%";
            this.Text3.text = "" + TwoGram.twoperright.ToString("F") + "%";
        }

        else
        {
            this.Text7.text = "Insufficient Data";
        }
            

        if (enoughdata3g)
        {
            this.Text4.text = "" + ThreeGram.threeperleft.ToString("F") + "%";
            this.Text5.text = "" + ThreeGram.threepermiddle.ToString("F") + "%";
            this.Text6.text = "" + ThreeGram.threeperright.ToString("F") + "%";
        }

        else
        {
            this.Text8.text = "Insufficient Data";
        }

        
    }
}
