using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun_Lab : MonoBehaviour
{
    public GameObject paintballPrefab;
    public Transform barrelTip;

    // Start is called before the first frame update
    void Start()
    {
        if (barrelTip == null)
        {
            barrelTip = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(paintballPrefab, barrelTip.position, barrelTip.rotation);
        }
    }
}
