using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualityControlImage : MonoBehaviour
{

    private Image image; 
    // Start is called before the first frame update
   
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispayImage(Sprite sprite){
        image = GetComponent<Image>();
       
        image.sprite = sprite;
    }
}
