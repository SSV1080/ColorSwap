using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   public void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RetryLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLvl0()
    {
        SceneManager.LoadScene("Lvl1");
    }
    public void NextLvl1()
    {
        SceneManager.LoadScene("Lvl2");
    }
    public void NextLvl2()
    {
        SceneManager.LoadScene("Lvl3");
    }
    public void NextLvl3()
    {
        SceneManager.LoadScene("Lvl4");
    }
    public void NextLvl4()
    {
        SceneManager.LoadScene("Lvl5");
    }

    public void LevelManager()
    {
        SceneManager.LoadScene("LevelManager");
    }

}
