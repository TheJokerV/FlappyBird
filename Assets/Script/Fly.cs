using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Fly : MonoBehaviour
{

    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public AudioSource clip;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * velocity;

            clip.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();

    }

}
