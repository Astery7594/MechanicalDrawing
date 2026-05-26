using UnityEngine;

public class inCamera : MonoBehaviour
{
    // is a script make an object move linear and bounced between both edge of screen

    public float s; //speed which can change in unity

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make object move with setting speed
        Vector2 newPosition = transform.position;
        newPosition.x += s;
        transform.position = newPosition;

        //Transfer world point to screen point view
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //then determine whether it has left the screen
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            // if it is change its derection
            s = s * -1;
        }
    }
}
