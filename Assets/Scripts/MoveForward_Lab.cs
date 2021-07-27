using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward_Lab : MonoBehaviour
{
    public float speed = 250f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
