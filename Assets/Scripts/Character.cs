using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Character : MonoBehaviour
{
    private bool moving;
    private int currentDirection;


    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        currentDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(moving) 
        {
            this.transform.Translate(new Vector3(Time.deltaTime * 5, 0, 0));
        }
    }

    public void HorizontalMove(int direction)
    {
        moving = true;

        if (currentDirection < 0 && direction > 0)
        {
            currentDirection = 1;
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        else if (currentDirection > 0 && direction < 0)
        {
            currentDirection = -1;
            this.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        
    }

    public void HorizontalStay()
    {
        moving = false;
    }
}
