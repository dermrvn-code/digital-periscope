using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{

    RaycastHit hit;
    Interactable target;

    public LayerMask layer;

    public void Interact()
    {
        target?.Interact();
    }


    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layer))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            hit.collider.gameObject.TryGetComponent<Interactable>(out target);
            Debug.Log("Hit " + hit.collider.gameObject.name);
            target?.Highlight();

            // hit.collider.gameObject.TryGetComponent<TMP_Text>(out text);
            // if (text != null)
            // {
            //     text.fontStyle = TMPro.FontStyles.Underline;
            //     return;
            // }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);

            target?.Unhighlight();
            // if (text != null)
            // {
            //     text.fontStyle = TMPro.FontStyles.Normal;
            //     text = null;
            // }
        }

    }
}
