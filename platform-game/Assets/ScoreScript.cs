using System.Collections;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("cherry"))
        {
            ScoreNum = ScoreNum + 5;
            MyScoreText.text = "Score: " + ScoreNum;

        }
        if (other.CompareTag("spike"))
        {
            ScoreNum = ScoreNum - 2;
            MyScoreText.text = "Score: " + ScoreNum;
        }
        if (other.CompareTag("alert"))
        {
            Debug.Log("Almost there!");
        }
        if (other.CompareTag("house"))
        {
            Debug.Log("You made it home!");
        }
    }

}
