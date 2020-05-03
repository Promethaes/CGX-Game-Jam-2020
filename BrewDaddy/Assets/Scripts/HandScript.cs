using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject go;
    public float movementForce = 2000.0f;
    public bool isRightHand = false;

    TestController inputActions;

    Vector2 movementInput;

    private void Awake()
    {
        inputActions = new TestController();

        if (!isRightHand)
            inputActions.PlayerControls.LeftMove.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        else
            inputActions.PlayerControls.RightMove.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }


    private void FixedUpdate()
    {
        Vector3 v = new Vector3(0.0f, 0.0f, 0.0f);
        go.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);

        v.x = movementInput.x;
        v.y = movementInput.y;


        v *= movementForce;
        v *= Time.deltaTime;

        go.GetComponent<Rigidbody>().AddForce(v, ForceMode.Impulse);
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

}
