using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    public static int money = 0;

    // Start is called before the first frame update
    void Start()
    {

        money = 0;

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<UnityEngine.UI.Text>().text = money.ToString();

    }
}
