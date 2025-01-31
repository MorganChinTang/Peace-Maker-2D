using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.UI; 

public class EndGoal : MonoBehaviour
{
    bool player1Finished = false;
    bool player2Finished = false;
    public Image GameOver;
    public Animator animator;
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            player1Finished = true;
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            player2Finished = true;
        }

        if (player1Finished && player2Finished && gameController.progressAmount >= 0)
        {
            Debug.Log("Game Finished");
            animator.SetTrigger("isFinished");
            GameOver.enabled = true;
        }
    }
}
