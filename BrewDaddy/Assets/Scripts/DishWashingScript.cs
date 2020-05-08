using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DishWashingScript : MonoBehaviour
{
    public Text QTEPrompt;
    public Image progressBar;
    public Image qteImageCircle;
    public UIHandMovement handScript;


    List<Vector2> directionSequence = new List<Vector2>();
    List<Vector2> playerInputSequence = new List<Vector2>();

    bool isActive = false;



    // Start is called before the first frame update 
    void Start()
    {

        QTEPrompt.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        qteImageCircle.gameObject.SetActive(false);
        resetQTE();

    }

    public void resetQTE()
    {
        isActive = false;
        qteImageCircle.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        progressBar.fillAmount = 1.0f;

        directionSequence.Clear();
        playerInputSequence.Clear();

        var rand = new System.Random();

       // //how many directions should there be? 
       // for (int i = 0; i < 4; i++)
       // {
       //     directionSequence.Add(new Vector2(rand.Next(-1, 1), rand.Next(-1, 1)));
       //     if (directionSequence[i] == new Vector2(0, 0))
       //     {
       //         directionSequence.RemoveAt(i);
       //         i--;
       //         continue;
       //     }
       //     Debug.Log(directionSequence[i]);
       // }

        directionSequence.Add(new Vector2(0, 1));
    }

    public void PromptOnorOff(bool yn)
    {
        QTEPrompt.gameObject.SetActive(yn);
    }

    public void ActivateQTE()
    {
        isActive = true;
        qteImageCircle.gameObject.SetActive(true);
        progressBar.gameObject.SetActive(true);
    }

    float inputTimer = 0.5f;
    int correctCounter = 0;
    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            handScript.canMove = 1;
            return;
        }
       
        handScript.canMove = 0;

        if (inputTimer <= 0.0f)
            inputTimer += Time.deltaTime;

        else if (inputTimer >= 0.5f)
        {

            //code to track player inputs 
            //check to see if we're out of a deadzone
            inputTimer = 0.0f;

             Debug.Log(handScript.rightHandInput);

            //positive diagonal
            if (handScript.rightHandInput.x > 0.5f && handScript.rightHandInput.y > 0.5f)
                playerInputSequence.Add(new Vector2(1, 1));

            //diagonal up left
            if (handScript.rightHandInput.x < -0.5f && handScript.rightHandInput.y > 0.5f)
                playerInputSequence.Add(new Vector2(-1, 1));

            //negative diagonal
            if (handScript.rightHandInput.x < -0.5f && handScript.rightHandInput.y < -0.5f)
                playerInputSequence.Add(new Vector2(1, 1));

            //negative down right
            if (handScript.rightHandInput.x > 0.5f && handScript.rightHandInput.y < -0.5f)
                playerInputSequence.Add(new Vector2(-1, 1));


            //left
            if (handScript.rightHandInput.x < -0.5f && handScript.rightHandInput.y < 0.1f && handScript.rightHandInput.y > -0.1f)
                playerInputSequence.Add(new Vector2(-1, 0));

            //right
            if (handScript.rightHandInput.x > 0.5f && handScript.rightHandInput.y < 0.1f && handScript.rightHandInput.y > -0.1f)
                playerInputSequence.Add(new Vector2(1, 0));

            //down
            if (handScript.rightHandInput.y < -0.5f && handScript.rightHandInput.x < 0.1f && handScript.rightHandInput.x > -0.1f)
                playerInputSequence.Add(new Vector2(0, -1));

            //up
            if (handScript.rightHandInput.y > 0.5f && handScript.rightHandInput.x < 0.1f && handScript.rightHandInput.x > -0.1f)
                playerInputSequence.Add(new Vector2(0, 1));
        }




        int index = playerInputSequence.Count - 1;

        if (index >= 0 && playerInputSequence[index]
            == directionSequence[correctCounter])
        {
            Debug.Log("Correct!\n");
        }

        progressBar.fillAmount -= Time.deltaTime / 5.0f;

        if (progressBar.fillAmount <= 0.0f)
        {
           // Debug.Log("Player input:");
           // for (int i = 0; i < playerInputSequence.Count; i++)
           //     Debug.Log(playerInputSequence[i]);
           // Debug.Log("End of player input");
            resetQTE();
        }

    }
}
