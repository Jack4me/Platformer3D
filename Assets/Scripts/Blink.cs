using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Blink : MonoBehaviour {
    public Renderer[] rendererBody;

    public void StartBlinkCoroutine(){
        StartCoroutine(BlinkCoroutine());
    }

    public IEnumerator BlinkCoroutine(){
        for (float t = 0; t < 1; t += Time.deltaTime){
            for (int i = 0; i < rendererBody.Length; i++){
                for (int j = 0; j < rendererBody[i].materials.Length; j++){
                    rendererBody[i].materials[j].SetColor("_EmissionColor",
                        new Color(Mathf.Sin(t * 30) * 0.5f + 0.5f, 0, 0, 0));
                }
            }

            yield return null;
        }
    }
}