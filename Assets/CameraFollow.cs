using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
 
    Camera MainCamera = Camera.main;
    GameObject Player;
    public void MoveCameraTo(float moveTo, bool followPlayer)
    {
        if (followPlayer)
        {
            MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, new Vector3(moveTo, MainCamera.transform.position.y, MainCamera.transform.position.z), 1);
        } // Vector lep to player?
        else
        {

        }//Vector lerp to point
    }
}
