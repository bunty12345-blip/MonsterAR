using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hit;
    public GameObject image;

 
 

    void Start()
    {
   

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Instantiate(image);
                Debug.Log("Hittt ");
            }

        }
    }
}
