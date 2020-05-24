using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UIRightHandRayCast : MonoBehaviour {

    public Image handImage;
   
    public Camera camera;
    public LayerMask itemLayerMask;
    public LayerMask eventLayerMask;
    public bool testClick;

    public DishWashingScript dish;


    public void CheckForItem() {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, itemLayerMask)) {
            
            //Debug.Log("Right Hand - "+hit.collider.gameObject.name);
          
        }

    }

    public void CheckForEventTrigger()
    {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, eventLayerMask))
        {

            //Debug.Log("Right Hand - " + hit.collider.gameObject.name);

            if(hit.collider.gameObject.tag == "DishWashingGame")
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
    } 


    public void OnRightAction(InputValue input) {
        CheckForItem();
        CheckToActivate();

    }
}
