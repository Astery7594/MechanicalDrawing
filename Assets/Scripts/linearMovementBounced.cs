using UnityEngine;

public class linearMovementBounced : MonoBehaviour
{
    //make object move linearly though two point back and fore
    public Transform start;//object starting movement position
    public Transform end;//end position
    public float t = 0;//(0-1)
    public float a;//speed
    private bool e;//determine whether the end point has been reached
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e)//the end point hasn't been reached
        {
            t = t + a; //set object speed
            if (t == 1 || t > 1)// reached the end point
            {
                e = false;
            }
           
        }
        else//the end point has been reached
        {
            t=t - a; //move backwards
            if(t == 0 || t < 0) //reached start point
            {
                e = true;
            }
        }
        //move the object
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
