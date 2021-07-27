using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy_Lab : MonoBehaviour
{
    public int hitCount = 0;
    public TextMeshProUGUI countText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Paintball")
        {
            hitCount++;
            string currentHits = (int.Parse(countText.text) + hitCount).ToString();
            countText.text = currentHits;

            if(currentHits == "20")
            {
                countText.text = currentHits + " - Level Completed";
            }
        }
    }
}
