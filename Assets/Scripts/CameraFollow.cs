using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform toFollow = null;
    private Vector3 offset;
    private Transform mytransform;
 private void  Start() {
      mytransform = transform;
      offset = toFollow.position - mytransform.position;
 }

 private void LateUpdate()
  {
     mytransform.position = toFollow.position - offset;
     mytransform.LookAt(toFollow);
 }
}
