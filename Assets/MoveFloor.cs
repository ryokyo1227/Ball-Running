using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public bool moveflag;
    // Start is called before the first frame update
    void Start()
    {
        moveflag = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < -1.9f)
        {
            moveflag = true;
        }
       if(transform.position.x > 3)
        {
            moveflag = false;
        }
        if (moveflag == true)
        {
            transform.position += new Vector3(0.05f,0,0);
        }
        if(moveflag == false)
        {
            transform.position -= new Vector3(0.05f, 0, 0);
        }
    }
}
