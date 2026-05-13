using UnityEngine;

public class animationCurveStuff : MonoBehaviour
{
    public AnimationCurve c;
    public float t = 0.5f;
    private bool b;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            t = t + Time.deltaTime;
            if (t > 1.5)
            {
                b = false;
            }
        }
        else
        {
            t = t - Time.deltaTime;
            if (t < 0.5 || t == 0.5)
            {
                b = true;
            }
        }
        float a=c.Evaluate(t);
        //Vector3 newSize = Vector3.one * a;
        transform.localScale = Vector2.one * a;
    }
}
