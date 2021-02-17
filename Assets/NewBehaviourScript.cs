using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
       
    }

    Vector3 target = new Vector3(8,3,3);

    void Update()
    {
        Vector3 value = Vector3.zero;
        transform.position = Vector3.Lerp(transform.position, target, 0.01f);
    }

}
