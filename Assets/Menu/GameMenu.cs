using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    //Attach your canvas to this variable in inspector
    public GameObject canvasObj;
    public GameObject bg;
    public GameObject cam1;
    public GameObject cam2;

    //This will check if your game is paused (we'll set it)
    private bool gamePaused;

    public void backToGame()
    {
        canvasObj.SetActive(false);
        bg.SetActive(false);
    }

    void Update()
    {
        //Reading input for ESCAPE key, and by saying gamePaused = !gamePaused, we switch the bool on and off each time the Keycode is registered!
        if (Input.GetKeyDown(KeyCode.Escape))
            gamePaused = !gamePaused;

        //Now we enable and disable the game object!
        if (gamePaused)
        {
            canvasObj.SetActive(true);
            bg.SetActive(true);
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

        else
        {
            canvasObj.SetActive(false);
            bg.SetActive(false);
            cam1.SetActive(true);
            cam2.SetActive(false);
        } 
    }
}