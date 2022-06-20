using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraInfo : MonoBehaviour
{
    public GameObject[] extraInfoArray;

    public bool extraInfoToggle = false;
    // Start is called before the first frame update
    void Start()
    {
         for(int i = 0; i < extraInfoArray.Length; i++) 
         {
             extraInfoArray[i].SetActive(false);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void ToggleExtraInfo()
    {
        extraInfoToggle = !extraInfoToggle;
        for(int i = 0; i < extraInfoArray.Length; i++) {
            if (extraInfoArray[i].transform.parent.gameObject.activeSelf){
                extraInfoArray[i].SetActive(extraInfoToggle);
            }
        }
    }
}
