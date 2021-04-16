using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed; 
    private Transform myTransform;

    private Rigidbody _myRigidbody;

    private void Start() {
        myTransform = transform;
        _myRigidbody = GetComponent<Rigidbody>();
    }
    private  void Update() 
    {
        Vector3 direction = Vector3.zero;
        if(Input.GetKey(KeyCode.Z))
        {
           direction += Vector3.forward;
        }
           if(Input.GetKey(KeyCode.S))
        {
            direction -= Vector3.forward;
        }
           if(Input.GetKey(KeyCode.Q))
        {
            direction += Vector3.left;
        }
        
           if(Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
            myTransform.Translate(direction * Time.deltaTime * speed,Space.World);

            _myRigidbody.velocity =Vector3.zero;
        
    }

}
