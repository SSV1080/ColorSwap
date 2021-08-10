using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFade : MonoBehaviour
{   
    public Image fadeScreen;

    public bool fade2Blk;
    public bool fadeFrmBlk;
        
    public float fadeSpeed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (fade2Blk)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a , 1f, fadeSpeed * Time.deltaTime));
            if(fadeScreen.color.a == 1f)
            {
                fade2Blk = false;
            }
        }
        if (fadeFrmBlk)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (fadeScreen.color.a == 0f)
            {
                fadeFrmBlk = false;
            }
        }
    }

    public void FadeToBlack()
    {
        fade2Blk = true;
        fadeFrmBlk = false;
    }

    public void FadeFromBlack()
    {
        fade2Blk = false;
        fadeFrmBlk = true;
    }
}
