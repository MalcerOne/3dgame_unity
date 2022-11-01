using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input){
        float mouseX = input.x;
        float mouseY = input.y;

        // calculate camera rotation
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;

        // value we're clamping, minimum and maximum value
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // applying to camera
        cam.transform.localRotation = Quaternion.Euler(xRotation,0,0);

        // rotate player
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
