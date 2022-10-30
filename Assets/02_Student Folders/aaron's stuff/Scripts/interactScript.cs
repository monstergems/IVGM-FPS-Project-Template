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
                    if(hit.collider.transform.parent.GetComponent<doorScript>() == null)
                    {
                        return;
                    }

                    if(Inventory.keys[hit.collider.transform.parent.GetComponent<doorScript>().index] == true)
                    {
                        hit.collider.transform.parent.GetComponent<doorScript>().ChangeDoorState();
                    }
                    
                }
                else
                {
                    if(hit.collider.CompareTag("key"))
                    {
                        Inventory.keys[hit.collider.GetComponent<Key>().index]= true;
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}
