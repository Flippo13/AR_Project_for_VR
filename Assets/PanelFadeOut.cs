using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFadeOut : MonoBehaviour
{
    public float timeShow = 5;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = timeShow;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf){
            timeLeft -= Time.deltaTime; 
            if (timeLeft <= 0){
                timeLeft = timeShow;
                gameObject.SetActive(false);
            }
        }
    }
}
