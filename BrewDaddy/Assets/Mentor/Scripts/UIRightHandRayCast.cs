using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEditor;

public class UIRightHandRayCast : MonoBehaviour
{

    public Image handImage;

    public Camera camera;
    public LayerMask itemLayerMask;
    public LayerMask eventLayerMask;
    public bool testClick;
    GameObject currentHeldObject;
    bool isGrabbing = false;
    public UIHandMovement movement;

    public DishWashingScript dish;


    public void CheckForItem()
    {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        Debug.Log(ray.direction);

        if (Physics.Raycast(ray, out hit, 1000, itemLayerMask))
        {

            Debug.Log("Right Hand - " + hit.collider.gameObject.name);
            currentHeldObject = hit.collider.gameObject;
            currentHeldObject.GetComponent<Rigidbody>().useGravity = false;
            isGrabbing = true;

        }

    }

    public float objectMoveSpeed = 1.0f;
    public void MoveCurrentHeldObject()
    {
        if (isGrabbing)
        {
            currentHeldObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            currentHeldObject.transform.position += movement.rightHandInput * objectMoveSpeed * Time.deltaTime;
        }

    }

    public void CheckForEventTrigger()
    {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, eventLayerMask))
        {

            //Debug.Log("Right Hand - " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.tag == "DishWashingGame")
            {
                dish.PromptOnorOff(true);
            }


        }
        else
        {
            dish.PromptOnorOff(false);
        }
    }

    //used to check which minigame should be activated
    public void CheckToActivate()
    {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, eventLayerMask))
        {

            // Debug.Log("Right Hand - " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.tag == "DishWashingGame")
            {
                dish.PromptOnorOff(false);
                dish.ActivateQTE();
            }


        }
    }

    public void Update()
    {
        //... activate event from other script
        CheckForEventTrigger();
        MoveCurrentHeldObject();
    }


    public void OnRightAction(InputValue input)
    {
        if (isGrabbing)
            isGrabbing = false;
        CheckForItem();
        CheckToActivate();

    }


}
