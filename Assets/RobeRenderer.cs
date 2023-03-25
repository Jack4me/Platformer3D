using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobeRenderer : MonoBehaviour {
    public LineRenderer lineRenderer;
    public int Segments = 10;


    public void Draw(Vector3 a, Vector3 b, float length){
        lineRenderer.enabled = true;

        float interpoland = Vector3.Distance(a, b) / length;
        float offset = Mathf.Lerp(length / 2f, 0f, interpoland);

        Vector3 Adown = a + Vector3.down * offset;
        Vector3 Bdown = b + Vector3.down * offset;
        lineRenderer.positionCount = Segments + 1;
        for (int i = 0; i < Segments + 1; i++){
            lineRenderer.SetPosition(i, Bezier.GetPoint(a, Adown, Bdown, b, (float)i / Segments));
        }
    }

    public void DisableRobeLine(){
        lineRenderer.enabled = false;
    }
}