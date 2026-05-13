using UnityEngine;

public class linearMovementBounced : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0;
    public float a;
    private bool e;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e)
        {
            t = t + a;
            if (t == 1 || t > 1)
            {
                e = false;
            }
           
        }
        else
        {
            t=t - a;
            if(t == 0 || t < 0)
            {
                e = true;
            }
        }
        
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
