using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateRound : MonoBehaviour
{
    public Text CubeText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "K")
        {
            CubeText.text = ("Please attach me to Taco");
        }
        if (other.tag == "SP")
        {
            CubeText.text = ("Please attach me to Sinior Pomidor");
        }
        if (other.tag == "P")
        {
            CubeText.text = ("Please attach me to Pancakes");
        }
        if (other.tag == "B")
        {
            CubeText.text = ("Please attach me to Banana");
        }
    }
}