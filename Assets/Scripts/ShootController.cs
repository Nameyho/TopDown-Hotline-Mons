using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public ParticleSystem MuzzleFlashe;
    public ParticleSystem CollissionExplosionPrefab;

    private Transform _transform;

    private RaycastHit _hitInfo;

    private bool _isHit;

    public TrailRenderer bulletTrailPrefab;

    private void Start() {
        _transform = transform;
    }
    private void Update() {

        _isHit = Physics.Raycast(_transform.position,_transform.forward, out _hitInfo);

        if(Input.GetMouseButtonDown(0))
        {
             MuzzleFlashe.Play();
             TrailRenderer bullletTrail = Instantiate(bulletTrailPrefab,_transform.position,Quaternion.identity);
             bullletTrail.AddPosition(_transform.position);
             if(_isHit){
                // faire des trucs avec la collission détéctée
                ParticleSystem collissionExplosion = Instantiate(CollissionExplosionPrefab,_hitInfo.point,Quaternion.identity);
                

                //collissionExplosion.transform.LookAt(hitInfo.normal);
                collissionExplosion.transform.rotation =   Quaternion.LookRotation(_hitInfo.normal,Vector3.up);
                //Destroy(hitInfo.collider.gameObject);
               Destroy(collissionExplosion.gameObject,1f);
               bullletTrail.transform.position = _hitInfo.point;
               //bullletTrail.AddPosition(_hitInfo.point);
               }
        }
    }


    private void OnDrawGizmos() {
        Gizmos.DrawLine(_hitInfo.point,_hitInfo.point + _hitInfo.normal);
    }

    
}
