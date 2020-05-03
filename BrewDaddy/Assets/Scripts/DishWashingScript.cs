using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DishWashingScript : MonoBehaviour
{
    public Text QTEPrompt;
    public Image progressBar;
    public Image qteImageCircle;

    bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        QTEPrompt.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        qteImageCircle.gameObject.SetActive(false);
    }

    public void resetQTE()
    {
        isActive = false;
        qteImageCircle.gameObject.SetActive(false);
        progressBar.gameObject.SetActive(false);
        progressBar.fillAmount = 1.0f;
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

    // Update is called once per frame 
    void Update()
    {
        if (!isActive)
            return;

        progressBar.fillAmount -= Time.deltaTime / 2.0f;

        if(progressBar.fillAmount <= 0.0f)
        {
            resetQTE();
        }

    }
}
