using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRightSide : MonoBehaviour
{
    /*Rigidbody2D rb;*/
    public GameObject note;
    public float speed;
    /*bool called=false;*/
    [SerializeField]
    SpriteRenderer[] rend = null;

    private void Awake()
    {
        /*
        Physics2D.gravity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
        */
    }

    void Start()
    {
        rend[0].enabled = false;
        rend[1].enabled = false;



    }
    void Update()
    {
        /*if (PlayerPrefs.GetInt("Start")==1&&!called)
        {

            rb.velocity = new Vector2(0, -speed);
            called = true;
        }
        */
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "RightVisibilizer")
        {
            rend[0].enabled = true;
            rend[1].enabled = true;

        }
        if(other.tag == "RightDeleter")
        {
            rend[0].enabled = false;
            rend[1].enabled = false;
        }

    }


}
