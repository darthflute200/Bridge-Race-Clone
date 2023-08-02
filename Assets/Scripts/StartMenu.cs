using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] public Canvas OptionsMenuCanvas;
    Canvas Menucanvas;
    public bool IsGamePaused = true;
    void Start()
    {
        Time.timeScale = 0f;
        Menucanvas = GetComponent<Canvas>();
    }
    public void startgame()
    {
        Time.timeScale = 1f;
        IsGamePaused = false;
        Menucanvas.enabled = false;
    }
    public void OptionsMenu()
    {
        Menucanvas.enabled = false;
        OptionsMenuCanvas.enabled = true;
    }
    public void Quit()
    {
        Application.Quit();
    }

}
