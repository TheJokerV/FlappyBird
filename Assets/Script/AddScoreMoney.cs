using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreMoney : MonoBehaviour
{
    public GameObject money;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Money.money++;

        Destroy(money);
    }

}
