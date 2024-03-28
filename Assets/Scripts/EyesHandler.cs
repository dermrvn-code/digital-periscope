using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesHandler : MonoBehaviour
{

    public Camera leftEye;
    public Camera rightEye;

    public float eyeSpacing = 0.6f;

    public float rotation = 0f;

    public float heightOffset = 0f;
    public float height = 0f;

    private int zoom = 60;


    void Awake()
    {
        LoadValues();
    }

    void Update()
    {
        UpdateSpacing();
        UpdateRotation();
        UpdateHeight();
    }

    void OnApplicationQuit()
    {
        SaveValues();
    }



    void UpdateSpacing()
    {
        leftEye.transform.localPosition = new Vector3(eyeSpacing / 2, 0, 0);
        rightEye.transform.localPosition = new Vector3(-eyeSpacing / 2, 0, 0);
        leftEye.transform.localPosition = new Vector3(eyeSpacing / 2, 0, 0);
        rightEye.transform.localPosition = new Vector3(-eyeSpacing / 2, 0, 0);
    }

    void UpdateRotation()
    {
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x, rotation, gameObject.transform.localEulerAngles.z);
    }
    void UpdateHeight()
    {
        gameObject.transform.localPosition = new Vector3(0, height + heightOffset, 0);
    }


    public void ZoomIn()
    {
        if (zoom <= 25) return;
        zoom = zoom - 1;
        SetZoom(zoom);
    }


    public void ZoomOut()
    {
        if (zoom >= 100) return;
        zoom = zoom + 1;
        SetZoom(zoom);
    }

    public void LeftMove()
    {
        if (rotation - 1 < 0) rotation = 360;
        rotation = rotation - 1;
    }

    public void RightMove()
    {
        if (rotation + 1 > 360) rotation = 0;
        rotation = rotation + 1;
    }

    public void SetZoom(int zoom)
    {
        this.zoom = zoom;
        leftEye.fieldOfView = zoom;
        rightEye.fieldOfView = zoom;
    }


    private void LoadValues()
    {
        heightOffset = PlayerPrefs.GetFloat("heightOffset", 0);
        eyeSpacing = PlayerPrefs.GetFloat("eyeSpacing", 0);
    }

    private void SaveValues()
    {
        PlayerPrefs.SetFloat("heightOffset", heightOffset);
        PlayerPrefs.SetFloat("eyeSpacing", eyeSpacing);
        PlayerPrefs.Save();
    }
}
