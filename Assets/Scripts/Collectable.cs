using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Collectable: MonoBehaviour, IItem
{
    public static event Action<int> OnCollection;
    public int worth = 5;
    public void Collect()
    {
        OnCollection.Invoke(worth);
        Destroy(gameObject);
    }
}
