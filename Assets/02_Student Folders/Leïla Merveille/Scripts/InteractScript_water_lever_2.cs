using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript_water_lever_2 : MonoBehaviour
{
    public GameObject water;
    public GameObject lever;
    public bool rising = false;
    public float interactDistance=5f;

    //water
    public float riseUntil;

    //
    private float variableToChange;
    private float changePerSecond;
    
    //lever
    private float leverOpenAngle=50f;
    private float smooth=4f;

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
            // if water level not reached increase water level
            
            if (water.transform.position.y >= riseUntil) {
                rising = false;
            }
            if (water.transform.position.y <= riseUntil) {
                Debug.Log(riseUntil);
                Vector3 waterLevel = new Vector3(0f, 0.005f, 0f);
                water.transform.position += waterLevel;
            }
            // rotate lever
            Quaternion targetRotation = Quaternion.Euler(leverOpenAngle, 90, 0);
            lever.transform.localRotation=Quaternion.Slerp(lever.transform.localRotation,targetRotation,smooth*Time.deltaTime);
        } 
        else if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position,transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,interactDistance))
            {
                if(hit.collider.gameObject.tag == "Switch_Lever_2")
                {
                    if (rising == false) 
                    {
                        Debug.Log("AAAAAAAAAAA");
                        // rotate lever
                        rising = true;
                    }
                }
            }
        }
    }

}
