using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public InGameMenu inGameMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inGameMenu.gameObject.SetActive(!inGameMenu.gameObject.activeSelf);
        }
    }
}
