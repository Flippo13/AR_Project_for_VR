using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.MixedReality.Toolkit.UI
{
    //[AddComponentMenu("Scripts/MRTK/Examples/ColorChangerUnityUI")]
    public class GetData : MonoBehaviour
    {
        public GameObject[] buttonArray; 

        private Graphic[] toggleArray; 

        private Graphic toggle1;
        private Graphic toggle2;
        private Graphic toggle3;

        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

        //[SerializeField]
        // Start is called before the first frame update
        private async void Start()
        {
            toggleArray = new Graphic[buttonArray.Length];

            for (int i = 0; i < buttonArray.Length; i++){
                toggleArray[i] = buttonArray[i].GetComponentInChildren<Graphic>();
            }
        }

        public void GetColor()
        {
            //graphic.color = UnityEngine.Random.ColorHSV();
            // graphic = toggle1.GetComponent<Graphic>();
            Debug.Log("Image 1 " + toggleArray[0].color + " Image 2 " + toggleArray[1].color + " Image 3 " + toggleArray[2].color);

            toggle2.color = new Color(0,0,1,1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
