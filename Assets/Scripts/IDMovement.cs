using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDMovement : MonoBehaviour
{


    public float startPosX;
    public float startPosY;
    public bool isBeingHeld = false;
    public float z;

    void Start()
    {
        z = this.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isBeingHeld == true)
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, z);
        }

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {

        isBeingHeld = false;

    }

}
