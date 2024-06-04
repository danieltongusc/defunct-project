using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameOverManager gameOverManager;
    void Start()
    {
        //gameOverManager = FindObjectOfType<GameOverManager>();

        // if (gameOverManager == null)
        // {
        //     Debug.LogError("GameOverManager not found in the scene.");
        // }
    }

    // Update is called once per frame
    //void KilledEnemy(Collision2D collision)
    public void KilledEnemy()
    {
        Debug.Log("Killed one enemy");

        Destroy(gameObject);
    }
}
