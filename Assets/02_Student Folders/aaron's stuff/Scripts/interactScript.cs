using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactScript : MonoBehaviour
{
    public float interactDistance=5f;



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position,transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,interactDistance))
            {
                if(hit.collider.CompareTag("door"))
                {
                    //DoorScript doorScript=hit.collider.transform.parent.GetComponent<doorScript>();
                    hit.collider.transform.parent.GetComponent<doorScript>().ChangeDoorState();
                }
            }
        }
    }
}
