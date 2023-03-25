using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGun : MonoBehaviour {
    public Rigidbody rigidbodyPlayer;
    public Transform spawn;
    public float speed;
    public Gun gun;

    public float maxCharge = 3f;
    private float charged;
    private bool isCharged;
    public ReloadUI reload;
    void Update()
    {
       

        if (isCharged){
            if (Input.GetKeyDown(KeyCode.C)){
                rigidbodyPlayer.AddForce(-spawn.forward * speed, ForceMode.VelocityChange);
                gun.Shot();
                charged = 0;
                isCharged = false;
                reload.StartCharge();
            }
        }
        else{
            charged += Time.unscaledDeltaTime;
            reload.SetCharge(charged, maxCharge);
            if (charged >= maxCharge){
                isCharged = true;
                reload.StopCharge();
            }
        }
    }
}
