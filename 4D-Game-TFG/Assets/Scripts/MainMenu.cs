using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isControlsEnable = false;
    [SerializeField] public GameObject controlsMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ControlsDisplay()
    {
        if (isControlsEnable == false)
        {
            isControlsEnable = true;
            controlsMenu.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            isControlsEnable = false;
            controlsMenu.SetActive(false);
            gameObject.SetActive(true);
        }
    }
}
