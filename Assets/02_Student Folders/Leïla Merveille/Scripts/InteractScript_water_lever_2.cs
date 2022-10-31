using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript_water_lever_2 : MonoBehaviour
{
    public GameObject water;
    public GameObject lever;

    //water
    public float riseUntil = 0.5f;

    //
    private float variableToChange;
    private float changePerSecond;
    private bool rising = false;
    
    //lever
    private float leverOpenAngle=126f;
    private float smooth=10f;
    private float interactDistance=5f;

    void Update()
    {
        // we need the water level to rise when we pull a lever
        //      - pull lever
        //          - detect lever
        //          - turn on water level rising switch
        //      - increase the water level
        variableToChange += changePerSecond * Time.deltaTime;

        if (rising == true) 
        {
            Debug.Log(Time.deltaTime);
            // if water level not reached increase water level
            if (water.transform.position.y < riseUntil) {
                Vector3 waterLevel = new Vector3(0f, 0.001f, 0f);
                water.transform.position += waterLevel;
            }
            // rotate lever
            Quaternion targetRotation = Quaternion.Euler(leverOpenAngle, 0, 0);
            lever.transform.localRotation=Quaternion.Slerp(lever.transform.localRotation,targetRotation,smooth*Time.deltaTime);
        } 
        else if(Input.GetKeyDown(KeyCode.E))
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
    }

}
