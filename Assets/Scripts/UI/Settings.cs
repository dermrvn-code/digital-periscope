using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public EyesHandler eyes;
    public Slider eyeSpacing;
    public Slider heightOffset;
    private Image image;
    public bool visible = false;

    void Start()
    {
        image = GetComponent<Image>();
        ToggleView(!visible);
        if (eyes == null)
        {
            Debug.LogError("No eyes were given in the Hardware SettingsWrap");
            return;
        }
        eyeSpacing.value = eyes.eyeSpacing;
        heightOffset.value = eyes.heightOffset;
    }

    public void ChangeEyeSpacing(float spacing)
    {
        eyes.eyeSpacing = spacing;
    }

    public void ChangeOffsetHeight(float offset)
    {
        eyes.heightOffset = offset;
    }

    public void CloseView()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        image.enabled = false;
        visible = false;
    }

    public void OpenView()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        image.enabled = true;
        visible = true;
    }

    public void ToggleView()
    {
        ToggleView(visible);
    }

    private void ToggleView(bool visible)
    {
        if (visible)
        {
            CloseView();
            return;
        }
        OpenView();
    }


}
