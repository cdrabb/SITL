using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool moving = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moving = false;

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(1f, 0, 0);
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(-1f, 0, 0);
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, 1f);
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, -1f);
            moving = true;
        }
    }
}
