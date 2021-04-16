using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform player;
    private Transform _transform ;
    public float speed; 

    private void Start() {
        player = GameObject.Find("Player").transform;
        _transform = transform;
    }
    private void Update() {
        Vector3 target = new Vector3(player.position.x,_transform.position.y, player.position.z);
        _transform.LookAt(target);
        _transform.position += _transform.forward * Time.deltaTime * speed ;
    }
}
