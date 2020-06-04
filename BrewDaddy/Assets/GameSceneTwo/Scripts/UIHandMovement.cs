using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIHandMovement : MonoBehaviour {

    [Header("Dependencies")]
    public Image leftHandImage;
    public Image rightHandImage;

    [Header("Settings")]
    public float speed;


    [Header("Runtime Values")]
    // these are just to show the inputs in real time
    // otherwise i would make them private
    public Vector3 leftHandInput = Vector3.zero;
    public Vector3 rightHandInput = Vector3.zero;

    public int canMove = 1;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        leftHandImage.transform.position += leftHandInput * speed * Time.deltaTime * canMove;
        rightHandImage.transform.position += rightHandInput * speed * Time.deltaTime * canMove;
    }

    public void OnLeftMove(InputValue input) {
        // the vector2 will upsize to vector3 automatically
        leftHandInput = input.Get<Vector2>();
    }

    public void OnRightMove(InputValue input){
        // the vector2 will upsize to vector3 automatically
        rightHandInput = input.Get<Vector2>();
    }

}
