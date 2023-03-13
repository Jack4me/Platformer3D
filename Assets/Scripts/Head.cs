using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform colliderHeadTarget;

    // Update is called once per frame
    void Update(){
        transform.position = colliderHeadTarget.position;
    }
}
