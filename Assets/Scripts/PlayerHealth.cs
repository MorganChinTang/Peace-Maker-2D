using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    public HealthUI healthUI;

    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetMaxHearts(maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }
   
    private void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthUI.UpdateHearts(currentHealth);

        if(currentHealth<=0)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
