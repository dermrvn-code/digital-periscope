using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownHeightScale : MonoBehaviour
{
    public bool isWrapper = true;
    public RectTransform dropdown;
    private RectTransform self;
    private TMP_Dropdown dd;

    public enum WrapperType
    {
        wrapper, dropdownScroller
    };

    public WrapperType type = WrapperType.wrapper;


    void Start()
    {
        self = GetComponent<RectTransform>();
        dd = dropdown.gameObject.GetComponent<TMP_Dropdown>();

        if (type == WrapperType.wrapper)
        {
            var size = dd.options.Count > 0 ? dropdown.sizeDelta.y * dd.options.Count : 200;
            self.sizeDelta = new Vector2(self.sizeDelta.x, size);
        }
        else if (type == WrapperType.dropdownScroller)
        {
            float size;
            if (dd.options.Count > 0)
            {
                size = dropdown.sizeDelta.y * dd.options.Count;
                if (dd.options.Count > 3)
                {
                    size = dropdown.sizeDelta.y * 3;
                }
            }
            else
            {
                size = 200;
            }
            self.sizeDelta = new Vector2(self.sizeDelta.x, size);
        }
    }

}
