using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEndGame : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "flag")
        {
            print("hello");
            col.gameObject.transform.parent = this.gameObject.transform;
        }
    }	
}
