using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t=0;
    public float a;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //t += Time.deltaTime;

        //t=t+(float)0.0001;
        t = t + a;
        
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
