using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Paintball_Lab : MonoBehaviour
{
    public GameObject splatParticlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.transform.name);
        Vector3 position = collision.contacts[0].point + collision.contacts[0].normal * 0.1f;
        GameObject newParticles = Instantiate(splatParticlePrefab, position, Quaternion.identity);

        newParticles.transform.LookAt(collision.contacts[0].point + collision.contacts[0].normal * 2f);

        Destroy(gameObject, 0.1f);
    }
}
