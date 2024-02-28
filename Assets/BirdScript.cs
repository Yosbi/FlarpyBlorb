using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float flapStrength;
    public LogicScript logicScript;
    public bool birdIsAlive = true;
    public float gameOverHeight = 10;
    public AudioSource wingFlapSFX;


    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!birdIsAlive)
            return;

        if ( Input.GetKeyDown(KeyCode.Space) ) {
            rigidBody2D.velocity = Vector2.up * flapStrength;
            wingFlapSFX.Play();
        }

        if (transform.position.y > gameOverHeight || transform.position.y < -gameOverHeight)
        {
            KillBird();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        KillBird();
    }

    void KillBird(){
        logicScript.gameOver();
        birdIsAlive = false;
    }

    public bool isBirdAlive()
    {
        return birdIsAlive;
    }
}
