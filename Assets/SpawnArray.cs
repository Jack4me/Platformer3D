using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnArray : MonoBehaviour {
    public UnityEvent[] events;
    
    
    public void StartEvent(int eventIndex){
        events[eventIndex].Invoke();
        }
    
}
