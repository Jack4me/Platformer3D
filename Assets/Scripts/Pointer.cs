using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {
    public Camera cameraPlayer;
    public Transform aim;
    public Transform body;
    public float euler;

    private void Start(){
    }

    private void LateUpdate(){
        Ray ray = cameraPlayer.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.back, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        aim.position = point;

        Vector3 gunLookAtAim = aim.position - transform.position;
        transform.rotation = Quaternion.LookRotation(gunLookAtAim);


        if (gunLookAtAim.x < 0){
            euler = Mathf.Lerp(euler, 50, Time.deltaTime * 10);
        }

        if (gunLookAtAim.x > 0){
            euler = Mathf.Lerp(euler, -50, Time.deltaTime * 10);
        }

        body.localEulerAngles = new Vector3(0, euler, 0);
    }
}