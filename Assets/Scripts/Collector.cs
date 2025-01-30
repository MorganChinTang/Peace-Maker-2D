using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IItem item = collision.GetComponent<IItem>();
        if (item != null)
        {
            item.Collect();

        }
    }
}
