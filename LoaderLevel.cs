using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoaderLevel : MonoBehaviour
{
    public string SceneToLoad;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
