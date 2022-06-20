// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.UI
{

 public enum ColorState {
     Grey, 
     Green, 
     Red
 }
    /// <summary>
    /// Change the color of the material on a UnityUI Graphic (ex. Image).  Useful for visualizing button presses.
    /// </summary>
    //[AddComponentMenu("Scripts/MRTK/Examples/ColorChangerUnityUI")]
    public class ColorChanger3 : MonoBehaviour
    {
        [SerializeField]
        private Graphic graphic;

        private ColorState state; 
        private void Start()
        {
            state = ColorState.Grey;
            if (graphic == null)
            {
                graphic = GetComponent<Graphic>(); //checkpoint3
            }
        }

        private void Update() {
            if (state == ColorState.Grey)
            {
                graphic.color = Color.grey;
            }
            else if (state == ColorState.Green)
            {
                graphic.color = Color.green;
            }
            else if (state == ColorState.Red)
            {
                graphic.color = Color.red;
            }
            
        }

        /// <summary>
        /// Sets a random color on the renderer's material.
        /// </summary>
        private Dictionary<string, int> checkPoints = new Dictionary<string, int>();

        ///public Dictionary<string, int> CheckPoints { get => checkPoints; set => checkPoints = value; }

        public void RandomColor()
        {
            //graphic.color = UnityEngine.Random.ColorHSV();
            if (!checkPoints.ContainsKey("EF3"))
            {
                checkPoints.Add("EF3", 0);  //EF; adding a key
            }

            if (graphic.color == Color.red) //when switched to red (initial colour is not set to 'green' even though it looks green)
            {
                graphic.color = Color.green;
                checkPoints["EF3"] = 0; //EF = elephant foot doesn't exist
                print(checkPoints["EF3"].ToString());
            }
            else
            {
                graphic.color = Color.red;
                checkPoints["EF3"] = 1;  //EF = elephant foot exists
                print(checkPoints["EF3"].ToString());
            }
        }

        public void ChangeColor(){
            Debug.Log("Change Color");
            if (state == ColorState.Grey)
            {
                state = ColorState.Green;
            }
            else if (state == ColorState.Green)
            {
                state = ColorState.Red;
            }
            else if (state == ColorState.Red)
            {
                state = ColorState.Grey;
            }
        }
    }
}