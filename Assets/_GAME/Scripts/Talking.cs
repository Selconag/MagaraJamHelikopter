using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using Unity;
using UnityEngine.UI;
public class Talking : MonoBehaviour
{
    [SerializeField] protected Text Subtitles;
    [SerializeField] protected GameObject InGameMenuPanel;
    //private string path = Resources.Load("Speeches.txt").ToString();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause_Button();
        }
    }

    #region Menu
    private void Pause_Button()
    {
        Time.timeScale = 0;
        InGameMenuPanel.SetActive(true);
    }

    public void Continue_Button()
    {
        Time.timeScale = 1;
        InGameMenuPanel.SetActive(false);
    }

    public void Options_Button()
    {


    }

    public void Exit_Button()
    {
        Application.Quit();

    }
    #endregion

    #region Subtitles
    public void Reader_of_Subtitles()
    {
        TextAsset Subtitle_Textfile = Resources.Load<TextAsset>("Speeches.txt");
        string file = Subtitle_Textfile.text.ToString();
        string[] lines = file.Split('\n');
    }
    #endregion




}
