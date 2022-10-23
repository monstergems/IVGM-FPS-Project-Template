using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public int index =-1;
    public bool open= false;
    public float doorOpenAngle=0f;
    public float doorCloseAngle=-90f;
    public float smooth=10f;

    void Start()
    {
        
    }


    public void ChangeDoorState()
    {
        open=!open;
    }

    void Update()
    {
        if(open)
        {
            Quaternion targetRotation = Quaternion.Euler(0,doorOpenAngle,0);
            transform.localRotation=Quaternion.Slerp(transform.localRotation,targetRotation,smooth*Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0,doorCloseAngle,0);
            transform.localRotation=Quaternion.Slerp(transform.localRotation,targetRotation2,smooth*Time.deltaTime);
        }
    }
}
