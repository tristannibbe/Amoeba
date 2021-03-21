using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject pauseScreen;
    public Slider healthBar;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setUpHealthBar(float max)
    {
        healthBar.maxValue = max;
        healthBar.value = max;
    }

    public void setHealthBarMax(float max)
    {
        healthBar.maxValue = max;
    }

    public void setHealthBarValue(float value)
    {
        healthBar.value = value;
    }

    public void togglePauseScreen(InputAction.CallbackContext context)
    {
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
