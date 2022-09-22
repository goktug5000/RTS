using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCont : MonoBehaviour
{
    public float PanSpeed=20, PanDetect, mouseX,mouseY;
    //public float camX=0, camZ=0;

    void Start()
    {
        Debug.Log("Screen Width : " + Screen.width);
        Debug.Log("Screen Height : " + Screen.height);
        PanDetect = 120;
    }

    void Update()
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
        //this.gameObject.transform.position = new Vector3(camX, 30, camZ);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            PanSpeed = 50;
        }
        else
        {
            PanSpeed = 20;
        }
        if ((mouseX>0 && mouseX<PanDetect) || Input.GetKey(KeyCode.A))
        {
            //camX -= PanSpeed*Time.deltaTime;
            transform.Translate(-PanSpeed * Time.deltaTime, 0, 0);
        }
        if ((mouseX > (Screen.width-PanDetect) && mouseX < Screen.width) || Input.GetKey(KeyCode.D))
        {
            //camX += PanSpeed*Time.deltaTime;
            transform.Translate(PanSpeed * Time.deltaTime, 0, 0);
        }
        if ((mouseY > 0 && mouseY < PanDetect) || Input.GetKey(KeyCode.S))
        {
            //camZ -= PanSpeed * Time.deltaTime;
            transform.Translate(0, 0, -PanSpeed * Time.deltaTime);
        }
        if ((mouseY > (Screen.height - PanDetect) && mouseY < Screen.height) || Input.GetKey(KeyCode.W))
        {
            //camZ += PanSpeed * Time.deltaTime;
            transform.Translate(0, 0, PanSpeed * Time.deltaTime);
        }
        

        if (Input.GetKey(KeyCode.Q))
        {
            this.gameObject.transform.Rotate(0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.transform.Rotate(0, -0.5f, 0);
        }

    }
}
