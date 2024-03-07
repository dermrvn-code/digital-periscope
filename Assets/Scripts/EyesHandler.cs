using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class EyesHandler : MonoBehaviour
{

    public Camera leftEye;
    public Camera rightEye;

    public float spacing = 0.6f;

    public int fov = 60;

    public float rotation = 0f;


    void Start()
    {
    }

    void Update()
    {
        UpdateSpacing();
        UpdateRotation();
        UpdateFOV();
    }

    void UpdateSpacing()
    {
        leftEye.transform.localPosition = new Vector3(spacing / 2, 0, 0);
        rightEye.transform.localPosition = new Vector3(-spacing / 2, 0, 0);
        leftEye.transform.localPosition = new Vector3(spacing / 2, 0, 0);
        rightEye.transform.localPosition = new Vector3(-spacing / 2, 0, 0);
    }

    void UpdateRotation()
    {
        this.gameObject.transform.localEulerAngles = new Vector3(0, rotation, 0);
    }

    void UpdateFOV()
    {
        leftEye.fieldOfView = fov;
        rightEye.fieldOfView = fov;
    }
}
