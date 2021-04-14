﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score: " + ScoreNum;
    }

    void OnTriggerEnter2D(Collider2D cherry)
    {
        if(cherry.tag == "cherry")
        {
            ScoreNum += 1;
            MyScoreText.text = "Score: " + ScoreNum;

        }
       
    }
    void OnTriggerEnter2D1(Collider2D spike)
    {
        if (spike.tag == "spike")
        {
            ScoreNum += 1;
            MyScoreText.text = "Score: " + ScoreNum;

        }

    }

}
