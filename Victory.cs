using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{

    public Button quitz;
    public Image win;
    public Button nxtlvl;

    public GameObject disc;

    public Button retry;
    public Button quitGame;



    // Start is called before the first frame update

    public void HellYeah()
    {

        AudioManager.instance.PlaySFX(0);

        gameObject.SetActive(true);

        disc.SetActive(false);

        PlayerMover.instance.player.SetActive(false);

        retry.gameObject.SetActive(false);
        quitGame.gameObject.SetActive(false);
    }
}

