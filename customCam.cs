using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customCam : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    public int musicToPlay;
    private bool musicStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        //To calculate Offset of camera from the player
        transform.position = player.transform.position + offset;

        if(!musicStarted)
        {
            musicStarted = true;

            AudioManager.instance.PlayBGM(musicToPlay);
        }
    }
}
