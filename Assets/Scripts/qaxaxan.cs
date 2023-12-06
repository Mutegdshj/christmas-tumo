using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qaxaxan : MonoBehaviour
{
   
     public Camera camera;
    public List<GameObject> toy;
    public int res;
    public Component dos;
    public GameObject gooh;
    public void One()
    {
        res = 0;
    }
    public void Two()
    {
        res = 1;
    }
    public void Three()
    {
        res = 2;
    }
    public void Test()
    {
        Debug.Log("Working");
    }
    void Update()
    {
        gooh = GameObject.Find("Hanging");
        dos=GameObject.Find("Hanging").GetComponent<ConstantForce>();
        // Check for mouse input (left mouse button)
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Cast a ray from the camera through the mouse position
            Ray ray = camera.ScreenPointToRay(mousePosition);

            // Perform the raycast and store the hit information
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                // The ray hit an object
                GameObject hitObject = hitInfo.collider.gameObject;
                GameObject GameHit = hitObject.gameObject;

                // You can now do something with the hit object
                Instantiate(toy[res], hitObject.transform.position, hitObject.transform.rotation);
                hitInfo.collider.enabled = false;
                if (GameHit == gooh.gameObject) ;
                {
                    Destroy(dos);
                }
           
                // Optionally, perform further actions with the hit object
            }
            else
            {
                // The ray did not hit any object
                Debug.Log("Ray did not hit anything.");
            }
        }
    }
}
