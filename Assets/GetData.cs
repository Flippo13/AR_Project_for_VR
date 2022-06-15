using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.MixedReality.Toolkit.UI
{
    //[AddComponentMenu("Scripts/MRTK/Examples/ColorChangerUnityUI")]
    public class GetData : MonoBehaviour
    {
        private Graphic toggle1;
        private Graphic toggle2;
        private Graphic toggle3;

        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

        //[SerializeField]
        private Graphic graphic;
        // Start is called before the first frame update
        private void Start()
        {

           // toggle1 = GameObject.Find("PressableButtonsTestCanvas").transform.Find("toggle1").gameObject;
            toggle1 = button1.GetComponentInChildren<Graphic>();
            toggle2 = button2.GetComponentInChildren<Graphic>();
            toggle3 = button3.GetComponentInChildren<Graphic>();

            
        }

        public void GetColor()
        {
            //graphic.color = UnityEngine.Random.ColorHSV();
            // graphic = toggle1.GetComponent<Graphic>();
            Debug.Log("Image 1 " + toggle1.color + " Image 2 " + toggle2.color + " Image 3 " + toggle3.color);

            toggle2.color = new Color(0,0,1,1);



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
