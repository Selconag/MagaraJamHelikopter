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

    public void Play_Button()
    {
        Debug.Log("Play Pressed");
    }
    public void Load_Button()
    {
        Debug.Log("Load Pressed");

    }
    public void Options_Button()
    {
        Debug.Log("Options Pressed");

    }
    public void Exit_Button()
    {
        Debug.Log("Exit Pressed");

    }
}
