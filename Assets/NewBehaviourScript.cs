using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            Debug.Log("test"+ Input.GetAxis("Horizontal"));
    }

}
