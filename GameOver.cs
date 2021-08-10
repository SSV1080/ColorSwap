using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image gameOver;
    public Button retry;
    public Button quit;

    public GameObject disc;

    // Start is called before the first frame update

    public void Setup()
    {
        gameObject.SetActive(true);

        PlayerMover.instance.player.SetActive(false);

        disc.SetActive(false);

        retry.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }
}

  