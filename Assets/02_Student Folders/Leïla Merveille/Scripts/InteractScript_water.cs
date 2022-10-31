using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript_water : MonoBehaviour
{
    public GameObject water;
    public float interactDistance=5f;

    private float variableToChange;
    private float changePerSecond;
    private bool rising = false;

    void Update()
    {
        // we need the water level to rise when we pull a lever
        //      - pull lever
        //          - detect lever
        //          - turn on water level rising switch
        //      - increase the water level
        variableToChange += changePerSecond * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position,transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,interactDistance))
            {
                if(hit.collider.gameObject.tag == "Switch_Lever")
                {
                    if (rising == false) 
                    {
                        Debug.Log(Time.deltaTime);
                        // rotate lever
                        rising = true;
                    }
                }
            }
        }
        // Debug.Log(Time.deltaTime);

        // if (rising == true )
        // if (true)
        // {
        //     if (Time.deltaTime <= duration)
        //     {// make the water rise for duration amount of time
        //         water.GetComponent<Transform>().position = new Vector3(waterLevelx , waterLevely + (Time.deltaTime / duration) * totalWaterLevelIncrease, waterLevelz);
                
        //     }
        // } 
        // else if (Input.GetKeyDown(KeyCode.E))
        // {
        //     Ray ray = new Ray(transform.position,transform.forward);
        //     RaycastHit hit;
        //     if(Physics.Raycast(ray,out hit,interactDistance))
        //     {
        //         if(hit.collider.CompareTag("Switch_Lever"))
        //         {
        //             if(rising == false)
        //             {
        //                 rising  = true;
        //                 // animate lever being pulled down
        //                 // gradually increase the water height
        //             }
        //         }
        //     }
        // }
    }
}
