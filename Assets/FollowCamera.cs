using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
    // this poistion (camera) were in same position at car

    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
