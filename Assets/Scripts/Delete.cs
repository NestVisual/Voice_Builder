using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

    void OnTake()
    {
        Destroy(gameObject, 5);
    }
}