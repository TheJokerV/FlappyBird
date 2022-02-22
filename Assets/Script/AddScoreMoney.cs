using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Libreria usada para el audio.
using UnityEngine.Audio;

public class AddScoreMoney : MonoBehaviour
{
    public GameObject money;
    public AudioSource clip;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Money.money++;

            Destroy(money, 0.08f);

            clip.Play();

        }
    }

