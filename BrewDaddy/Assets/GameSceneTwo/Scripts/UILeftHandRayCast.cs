using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UILeftHandRayCast : MonoBehaviour {

    public Image handImage;
    public Camera camera;
    public LayerMask layerMask;
    

    // Start is called before the first frame update
    void Start() {

    }

    public void CheckForItem() {
        Ray ray = camera.ScreenPointToRay(handImage.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, layerMask)) {
             Debug.Log("Left Hand - " + hit.collider.gameObject.name);
        }

    }

    public void OnLeftAction(InputValue input) {
        CheckForItem();
    }

}
