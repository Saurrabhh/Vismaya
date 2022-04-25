using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemove : MonoBehaviour
{
    // Start is called before the first frame update

    public float sensitivity = 0.001f;

    public Vector2 currMouselook = new Vector2(90,11);
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        LookAround();
        lockedcursor();
    }


    void LookAround()
    {
        currMouselook.x += Input.GetAxis("Mouse X") * sensitivity;
        currMouselook.y += Input.GetAxis("Mouse Y") * sensitivity;

        transform.localRotation = Quaternion.Euler(-currMouselook.y, currMouselook.x, 0);
       
    }


    void lockedcursor()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        
    }
}
