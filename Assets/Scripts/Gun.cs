using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform spawnPosition;
    private float shotRate = 0.2f;
    private float speed = 25f;
    private float _timer;

    public GameObject flash;
    public AudioSource shotSound;

    void Update(){
        _timer += Time.deltaTime;

        if (shotRate < _timer){
            if (Input.GetMouseButton(0)){
                _timer = 0;
                GameObject newBullet = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);
                newBullet.GetComponent<Rigidbody>().velocity = spawnPosition.forward * speed;
                shotSound.Play();
                flash.SetActive(true);
                Invoke("FlashFalse", 0.09f);
            }
        }
    }

    void FlashFalse(){
        flash.SetActive(false);
    }
}