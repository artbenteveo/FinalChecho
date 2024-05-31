using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationControl : MonoBehaviour
{

    bool isPaused = false;



    private void Start()
    {



    }

    private void Update()
    {

    }
   



    public void ActivateObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    public void DectivateObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void pause()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        } else {
            Time.timeScale = 1;
            isPaused = false;
        }
        
    }


}
