using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    // Use this for initialization

    void Start()
    {
        score = 0;
        UpdateScore();
    }
    // Update is called once per frame

    private void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "" + score;
    }
}

