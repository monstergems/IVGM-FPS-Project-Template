using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScriptWater : MonoBehaviour
{
    public float interactDistance=5f;
    GameObject obj;



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
                    if(WaterScript.rise_status[0]== true)
                    {
                        WaterScript.rise_status[0]= false;
                        //obj.GetComponent<WaterScript>().rise_status[0]= false;
                    }
                    else
                    {
                        WaterScript.rise_status[0]= true;
                        //obj.GetComponent<WaterScript>().rise_status[0]= true;
                    }
                }
            }
        }
    }
}

