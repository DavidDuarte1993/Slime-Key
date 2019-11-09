using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StoryLoader : MonoBehaviour
{
    public static StoryLoader instance;
    public Image image;
    public Sprite[] sprites;
    int Number;
    int max;
    public string SceneToLoad;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        max = sprites.Length;
        Number = -1;
    }
    private void Update()
    {
        
    }
    public void goNext()
    {
        Number++;
        if (Number >= max)
        {
            image.color = Color.black;
            Number = 0;
            SceneManager.LoadScene(SceneToLoad);
        }

        image.sprite = sprites[Number];
    }
}
