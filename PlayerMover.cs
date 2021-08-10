using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Random = UnityEngine.Random;
public class PlayerMover : MonoBehaviour
{
    public GameOver gameOvers;

    public Victory win;

    public static PlayerMover instance;
    public Animator myAnim;
    public Rigidbody2D rb;

    private int final;
    private string colour;

    public GameObject player;

    // Start is called before the first frame update

    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

        RandCol();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rb.velocity = new Vector2(0, 7f);

            AudioManager.instance.PlaySFX(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Switch")
        {
            RandCol();

            collision.gameObject.SetActive(false);
        }
        if(collision.tag == "Finish")
        {
            gameOvers.Setup();  
        }
        if(collision.tag == "Win")
        {
            win.HellYeah();
        }
    }
    void RandCol()
    {
        int random = Random.Range(0, 4);

        switch(random)
        {
            case 0:
                colour = "blue";
                myAnim.Play("blue");
                break;
            case 1:
                colour = "yellow";
                myAnim.Play("yellow");
                break;
            case 2:
                colour = "red";
                myAnim.Play("red");
                break;
            case 3:
                colour = "green";
                myAnim.Play("green");
                break;
        }

        final = random;
    }
}

