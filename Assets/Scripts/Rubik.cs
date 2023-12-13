using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubik : MonoBehaviour
{
    public float timer;
    private bool isAttached;
    public Vector3 scaleton = new Vector3(+1, +1, +1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttached)
        {
            if (Time.time - timer > 1)
            {
                Debug.Log("Austronav");
                isAttached = false;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = transform.localScale + scaleton;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Test")
        {
            isAttached = true;
            timer = Time.time;
         }
    }
    private void OnTriggerExit(Collider other)
    {
        isAttached = false;
        transform.localScale = new Vector3(1, 1, 1);
    }
}