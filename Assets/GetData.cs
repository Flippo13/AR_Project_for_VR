using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

namespace Microsoft.MixedReality.Toolkit.UI
{
    //[AddComponentMenu("Scripts/MRTK/Examples/ColorChangerUnityUI")]
    public class GetData : MonoBehaviour
    {
        public string filename = "";

        public GameObject[] buttonArray; 
        [SerializeField]
        private Image[] toggleArray; 
        [SerializeField]
        private TextMeshProUGUI[] taskTextArray;

        public TextMeshPro testMesh; 
        public TextMeshProUGUI textMeshGUI;

        //[SerializeField]
        // Start is called before the first frame update
         void Awake()
        {
            toggleArray = new Image[buttonArray.Length];
            taskTextArray = new TextMeshProUGUI[buttonArray.Length];

            if (filename == "")
                filename = Application.dataPath + "/qualityControlReport.csv";
            else
                filename = Application.dataPath + "/"+filename+".csv";

            for (int i = 0; i < buttonArray.Length; i++){
                toggleArray[i] = buttonArray[i].GetComponentInChildren<Image>();
                taskTextArray[i] = buttonArray[i].GetComponentInChildren<TextMeshProUGUI>();
            }

            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("Tasks, Status");
            tw.Close();
        }

        // Update is called once per frame
        void Update()
        {

        }


        public void WriteReport(){
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("Task, Status");
            tw.Close();
            tw = new StreamWriter(filename, true);
            string status = "";
            for(int i = 0; i < buttonArray.Length; i++)
            {
                if (toggleArray[i].color == Color.green){
                    status = "Passed";
                } 
                else if (toggleArray[i].color == Color.red)
                {
                    status = "Failed";
                }
                else if (toggleArray[i].color == Color.grey)
                {
                    status = "Not Checked";
                }

                tw.WriteLine(taskTextArray[i].text + "," + status);
            }
            tw.Close();
        }
    }
}

