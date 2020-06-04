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
    public DishManager dishManager;

    public float deadzoneThreshold = 0.5f;
    public float gameLengthInSeconds = 5.0f;

    List<Vector2> directionSequence = new List<Vector2>();

    bool isActive = false;


    // Start is called before the first frame update 
    void Start()
    {

        QTEPrompt.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        qteImageCircle.gameObject.SetActive(false);
        resetQTE();

    }

    public void resetDirectionSequence()
    {
        directionSequence.Clear();

        var rand = new System.Random();

        //how many directions should there be? 
        for (int i = 0; i < 4; i++)
        {
            directionSequence.Add(new Vector2(rand.Next(-1, 1), rand.Next(-1, 1)));
            if (directionSequence[i] == new Vector2(0, 0) || directionSequence[i].magnitude > 1)
            {
                directionSequence.RemoveAt(i);
                i--;
                continue;
            }
            Debug.Log(directionSequence[i]);
        }
    }

    public void resetQTE()
    {
        isActive = false;
        qteImageCircle.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        progressBar.fillAmount = 1.0f;
        correctCounter = 0;

        resetDirectionSequence();

        //directionSequence.Add(new Vector2(1, 1));
    }

    public void PromptOnorOff(bool yn)
    {
        QTEPrompt.gameObject.SetActive(yn);
    }

    public void ActivateQTE()
    {
        if (dishManager.numDirtyDishes > 0){
            isActive = true;
            qteImageCircle.gameObject.SetActive(true);
            progressBar.gameObject.SetActive(true);
        }
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

        //Debug.Log(handScript.rightHandInput);

        handScript.canMove = 0;

        inputTimer += Time.deltaTime;


        if (inputTimer >= 0.5f)
        {

            //left
            if (handScript.rightHandInput.x < -deadzoneThreshold && handScript.rightHandInput.y < deadzoneThreshold && handScript.rightHandInput.y > -deadzoneThreshold)
            {
                if (directionSequence[correctCounter] == new Vector2(-1, 0))
                {
                    correctCounter++;
                    Debug.Log("correct!");

                }

                inputTimer = 0.0f;
            }

            //right
            if (handScript.rightHandInput.x > deadzoneThreshold && handScript.rightHandInput.y < deadzoneThreshold && handScript.rightHandInput.y > -deadzoneThreshold)
            {
                if (directionSequence[correctCounter] == new Vector2(1, 0))
                {
                    correctCounter++;
                    Debug.Log("correct!");

                }

                inputTimer = 0.0f;
            }

            //down
            if (handScript.rightHandInput.y < -deadzoneThreshold && handScript.rightHandInput.x < deadzoneThreshold && handScript.rightHandInput.x > -deadzoneThreshold)
            {
                if (directionSequence[correctCounter] == new Vector2(0, -1))
                {
                    correctCounter++;
                    Debug.Log("correct!");

                }

                inputTimer = 0.0f;
            }

            //up
            if (handScript.rightHandInput.y > deadzoneThreshold && handScript.rightHandInput.x < deadzoneThreshold && handScript.rightHandInput.x > -deadzoneThreshold)
            {
                if (directionSequence[correctCounter] == new Vector2(0, 1))
                {
                    correctCounter++;
                    Debug.Log("correct!");

                }

                inputTimer = 0.0f;
            }
        }

        if (correctCounter == directionSequence.Count)
        {
            Debug.Log("Next Dish!");

            if (dishManager.numDirtyDishes == 0)
                resetQTE();
            else
                resetDirectionSequence();

        }

        progressBar.fillAmount -= Time.deltaTime / gameLengthInSeconds;

        if (progressBar.fillAmount <= 0.0f)
        {
            //Debug.Log("Player input:"); 
            //for (int i = 0; i < playerInputSequence.Count; i++)
            //    Debug.Log(playerInputSequence[i]);
            //Debug.Log("End of player input");
            resetQTE();
        }

    }
}
