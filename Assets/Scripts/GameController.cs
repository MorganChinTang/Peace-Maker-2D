using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{
    public int progressAmount;
    public Slider progressSlider;

    void Start()
    {
        progressAmount = 0;
        progressSlider.value = 0;
        Collectable.OnCollection += IncreaseProgressAmount;
    }
    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;
        if(progressAmount >=100)
        {
            Debug.Log("You Collected All Keys!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
