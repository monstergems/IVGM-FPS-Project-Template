using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactScript_water : MonoBehaviour
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
                if(hit.collider.CompareTag("lever"))
                {
                    if(waterScript.rise_status[0]== true)
                    {
                        waterScript.rise_status[0]= false;
                    }
                    else
                    {
                        waterScript.rise_status[0]= true;
                    }
                }
            }
        }
    }
}
