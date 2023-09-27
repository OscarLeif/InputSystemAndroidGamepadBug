using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float inputFloat;


    private void Start()
    {

    }

    public void InputPerformed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }

        if (context.valueType == typeof(float))
        {
            inputFloat = context.ReadValue<float>();
        }
        else if (context.valueType == typeof(Vector2))
        {
            //valueV2 = context.ReadValue<Vector2>();
        }
    }


    private void Update()
    {
        this.transform.Translate(new Vector3(1, 0) * inputFloat * speed * Time.deltaTime);
    }
}
