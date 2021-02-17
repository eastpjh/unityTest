using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
       
    }

    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);
        transform.Translate(vec);
    }

}
