using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherryScript : MonoBehaviour
{
    private levelManager gameLevelManager;
    public int cherryScore = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {


            Destroy(gameObject);
            cherryScore++;


            //gameLevelManager.AddCoins(cherryScore);
            //Destroy(gameObject);
        }
    }
}
