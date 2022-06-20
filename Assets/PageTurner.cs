using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
public class PageTurner : MonoBehaviour
{

    public GameObject page1;
    public GameObject page2;
    public TextMeshPro pageNum;
    // Start is called before the first frame update
    void Start()
    {
        pageNum.SetText("1");
        page1.SetActive(true); 
        page2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPage(){
        if (!page1.activeSelf)
            return;
        else {
            page1.SetActive(false);
            page2.SetActive(true);
            pageNum.SetText("2");
        }
    }

    public void PreviousPage(){
           if (!page2.activeSelf)
            return;
        else {
            page2.SetActive(false);
            page1.SetActive(true);
            pageNum.SetText("1");

        }
    }

}
}
