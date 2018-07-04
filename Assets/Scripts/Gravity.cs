using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	void Start () {
        Physics.gravity = new Vector3(0, -0.5f, 0);
	}

    void OnUp()
    {
        Physics.gravity = new Vector3(0, 0.5f, 0);
    }
    void Zero()
    {
        Physics.gravity = new Vector3(0, -0.5f, 0);
    }

    void OnDown()
    {
        Physics.gravity = new Vector3(0, -0.5f, 0);
        //.Invoke("Zero", 2);
    }

    void OnTag()
    {
        GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("Text");
        foreach (GameObject obj in tagobjs)
        {
            
        }
    }
}
