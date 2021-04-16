using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public ParticleSystem MuzzleFlashe;
    public ParticleSystem CollissionExplosionPrefab;
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
             MuzzleFlashe.Play();
            if(Physics.Raycast(transform.position,transform.forward, out RaycastHit hitInfo)){
                // faire des trucs avec la collission détéctée
                ParticleSystem collissionExplosion = Instantiate(CollissionExplosionPrefab,hitInfo.point,Quaternion.identity);
                collissionExplosion.transform.LookAt(hitInfo.normal);
                //Destroy(hitInfo.collider.gameObject);
               Destroy(collissionExplosion.gameObject,1f);
            }
        }
    }
}
