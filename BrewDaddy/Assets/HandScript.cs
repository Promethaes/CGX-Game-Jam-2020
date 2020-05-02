using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject go;
    public bool keyset = false;//left hand by default
    List<string> keys = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        if(keyset == false)
        {
            keys.Add("w");
            keys.Add("s");
            keys.Add("a");
            keys.Add("d");
        }
        else
        {
            keys.Add("up");
            keys.Add("down");
            keys.Add("left");
            keys.Add("right");
        }

    }

    public float movementForce = 100.0f;

    bool forward = false;
    bool back = false;
    bool left = false;
    bool right = false;
    

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKey(keys[0]))
            forward = true;
        else
            forward = false;
        if (Input.GetKey(keys[1]))
            back = true;
        else
            back = false;
        if (Input.GetKey(keys[2]))
            left = true;
        else
            left = false;
        if (Input.GetKey(keys[3]))
            right = true;
        else
            right = false;
    }

    private void FixedUpdate()
    {
        Vector3 v = new Vector3(0.0f, 0.0f, 0.0f);
        go.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);

        if (forward)
            v.y += movementForce;
        if (back)
            v.y -= movementForce;
        if (left)
            v.x -= movementForce;
        if (right)
            v.x += movementForce;

        v *= Time.deltaTime;

        go.GetComponent<Rigidbody>().AddForce(v, ForceMode.Impulse);
    }


}
