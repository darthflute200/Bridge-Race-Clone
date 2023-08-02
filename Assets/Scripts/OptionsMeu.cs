using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMeu : MonoBehaviour
{
    Canvas OptionMenuCanvas;
    private void Start()
    {
        OptionMenuCanvas = GetComponent<Canvas>();
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void SetQuality(int Qualityindex)
    {
        QualitySettings.SetQualityLevel(Qualityindex);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            OptionMenuCanvas.enabled = false;
            Time.timeScale = 1f;
        }
    }
}
