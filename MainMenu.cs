using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Transform vehicleRoot;
    public float cameraRotateSpeed = 5;
    private float x, y = 0;
    private int currentVehicleNumber = 0;
    private int DoorsMode = 0;
    public void CarDoors()
    {
        DoorsMode++;
        if (DoorsMode > 1) DoorsMode = 0;
    }
    private int LightsMode = 0;
    public void CarLights()
    {
        LightsMode++;
        if (LightsMode > 1) LightsMode = 0;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            x = Mathf.Lerp(x, Mathf.Clamp(Input.GetAxis("Mouse X"), -2, 2) * cameraRotateSpeed, Time.deltaTime * 5.0f);
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 50, 60);
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 50, Time.deltaTime);
        }
        else {
            x = Mathf.Lerp(x, cameraRotateSpeed * 0.02f, Time.deltaTime * 10.0f);
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60, Time.deltaTime);
        }
        transform.RotateAround(vehicleRoot.position, Vector3.up, x);
    }
}
