using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    //Attach your canvas to this variable in inspector
    public GameObject canvasObj;

    //This will check if your game is paused (we'll set it)
    private bool gamePaused;


    void Update()
    {
        //Reading input for ESCAPE key, and by saying gamePaused = !gamePaused, we switch the bool on and off each time the Keycode is registered!
        if (Input.GetKeyDown(KeyCode.Escape))
            gamePaused = !gamePaused;

        //Now we enable and disable the game object!
        if (gamePaused)
            canvasObj.SetActive(true);
        else
            canvasObj.SetActive(false);

    }
}