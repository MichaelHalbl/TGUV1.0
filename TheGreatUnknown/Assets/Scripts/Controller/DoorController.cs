using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
    void Update()
    {
         // Wenn der boolean wert true liefert öffnet sich die Tür
        if (doorIsOpening == true)
        {           
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        // Wenn der wert größer 7f ist wird die tür gestoppt
        if(Door.transform.position.y > 7f) {
            doorIsOpening = false;
        }
    }
    //Wenn man mit der maus klickt öffnet sich die Tür
    void OnMouseDown() {
        doorIsOpening = true;
    }
}
