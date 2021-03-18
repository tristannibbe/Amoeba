using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIController : MonoBehaviour
{

    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void togglePauseScreen(InputAction.CallbackContext context)
    {
        print("dsafdsaf");
        if (pauseScreen.activeInHierarchy)
        {
            closePauseScreen();
        }
        else
        {
            openPauseScreen();
        }
    }

    public void openPauseScreen(){
        pauseScreen.SetActive(true);
    }

    public void closePauseScreen()
    {
        pauseScreen.SetActive(false);
    }
}
