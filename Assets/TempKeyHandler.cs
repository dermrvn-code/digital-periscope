using UnityEngine;

public class KeyInput : MonoBehaviour
{
    EyesHandler eh;

    // Define the function to call when the keys are pressed
    void LeftMove()
    {
        eh.rotation = eh.rotation - 1;
        Debug.Log("Left");
    }

    void RightMove()
    {
        eh.rotation = eh.rotation + 1;
        Debug.Log("Left");
    }


    void Start()
    {
        eh = GetComponent<EyesHandler>();
    }

    void Update()
    {
        // Check for left key press
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LeftMove();
        }

        // Check for right key press
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightMove();
        }
    }
}
