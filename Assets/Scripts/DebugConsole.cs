using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class DebugConsole : MonoBehaviour
{
    public static TMP_Text consoleText;

    private static bool consoleActive = false;

    void Start()
    {
        consoleText = GetComponent<TMP_Text>();
    }

    public static void ToggleActivation()
    {
        consoleActive = !consoleActive;
        consoleText.enabled = consoleActive;

        if (consoleActive) Log("Console activated");
    }

    public static void Log(string text)
    {
        if (consoleActive)
        {
            var clearAfterLines = 25;
            var oldText = consoleText.text;
            var oldLines = oldText.Split("\n");
            if (oldLines.Length > clearAfterLines)
            {
                oldLines = oldLines.Skip(clearAfterLines).ToArray();
                oldText = string.Join("\n", oldLines);
            }
            consoleText.text = oldText + "\n" + "[" + DateTime.Now.ToString() + "] " + text;
        }
    }
}
