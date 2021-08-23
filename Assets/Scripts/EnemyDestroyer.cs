using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDestroyer : MonoBehaviour
{
    public int damage = 20;
    public int health = 100;

    Score score;

    Spawner gc;
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && tag.Equals("Cube"))
        {
            health -= damage;
            score = GameObject.FindGameObjectWithTag("Text").GetComponent<Score>();
            score.score+=100;
        }

        if (health <= 0)
        {           
            Destroy(gameObject);
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<Spawner>();
            gc.remaining--;
            score = GameObject.FindGameObjectWithTag("Text").GetComponent<Score>();
            score.score+=300;
        }
    }
}

