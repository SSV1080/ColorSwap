using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rings : MonoBehaviour
{

    public GameOver gameOver;

    public string color;
    public PlayerMover player;

    public float loadTime;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (color == "green" && !player.myAnim.GetCurrentAnimatorStateInfo(0).IsName("green"))
            {
                gameOver.Setup();

            }
            if (color == "yellow" && !player.myAnim.GetCurrentAnimatorStateInfo(0).IsName("yellow"))
            {
                gameOver.Setup();

            }
            if (color == "blue" && !player.myAnim.GetCurrentAnimatorStateInfo(0).IsName("blue"))
            {
                gameOver.Setup();

            }
            if (color == "red" && !player.myAnim.GetCurrentAnimatorStateInfo(0).IsName("red"))
            {
                gameOver.Setup();

            }
        }
    }
}

  
