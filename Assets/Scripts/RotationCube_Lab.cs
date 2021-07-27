using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCube_Lab : MonoBehaviour
{
    public GameObject cubeTarget;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(cubeTarget.transform.position, Vector3.up, 100 * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Paintball")
        {
            cubeTarget.SetActive(false);
        }
    }
}
