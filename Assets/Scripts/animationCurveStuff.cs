using UnityEngine;

public class animationCurveStuff : MonoBehaviour
{
    //make object change their size smoothly
    public AnimationCurve c;
    public float t = 0.5f; //Pattern size
    private bool b;//The determination to ensure the existence of the pattern

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            t = t + Time.deltaTime;//Enlarged pattern
            if (t > 1.5)
            {
                b = false;
            }
        }
        else
        {
            t = t - Time.deltaTime;//Reduce the pattern
            if (t < 0.5 || t == 0.5)
            {
                b = true;
            }
        }
        //evaluate the curve
        float a=c.Evaluate(t);
        //make it change
        transform.localScale = Vector2.one * a;
    }
}
