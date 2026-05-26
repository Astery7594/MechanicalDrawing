using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    //make object move linearly though two point in one derection
    public Transform start; //object starting movement position
    public Transform end; //end position
    public float d=0; // the distance traveled (0 -> 1)
    public float s; //speed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //going distance
        d = d + s;
        
        if (d > 1)//when object reach the end, refresh it to the start point
        {
            d = 0;
        }
        // make the movement
        transform.position = Vector2.Lerp(start.position, end.position, d);
    }
}
