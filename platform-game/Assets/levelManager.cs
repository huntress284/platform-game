using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public int cherryValue;
    //public PlayerMovement gamePlayer;
    // Start is called before the first frame update
    void Start()
    {
        //gamePlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int numOfCherry)
    {
        cherryValue += numOfCherry;
    }
}
