using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]protected GameObject m_PanelMenuMain;
    [SerializeField]protected GameObject m_PanelMenuPlay;
    [SerializeField]protected GameObject m_PanelMenuOptions;
    [SerializeField]protected GameObject m_PanelMenuExit;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ScreenCapture.CaptureScreenshot("MainMenu");
        }
    }

    public void Play_Button()
    {
        Debug.Log("Play Pressed");
        SceneManager.LoadScene(1);
    }
    public void Load_Button()
    {
        Debug.Log("Load Pressed");

    }
    public void Options_Button()
    {
        Debug.Log("Options Pressed");
        m_PanelMenuMain.SetActive(false);
        m_PanelMenuOptions.SetActive(true);
    }
    public void Exit_Button()
    {
        Debug.Log("Exit Pressed");
        Application.Quit();

    }
}
