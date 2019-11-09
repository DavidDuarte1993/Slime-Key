using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public GameObject panel;
    public void LoadScene()
    {
        SceneManager.LoadScene("TitleScene");
        Time.timeScale = 1;
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
