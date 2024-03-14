using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent OnInteract;

    void Start()
    {
        gameObject.layer = LayerMask.NameToLayer("Interactable");
        Setup();
    }

    public abstract void Setup();

    public abstract void Highlight();

    public abstract void Unhighlight();

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
