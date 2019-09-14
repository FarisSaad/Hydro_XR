using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoSheetScript : MonoBehaviour
{
    [SerializeField] private bool State;
    private float flowRate;


    private Transform canvas;
    private Button exeBtn;
    private Transform Panel;

    private Text objectNameVar;
    private Text statusVar;
    private Text FlowRateVar;
    // Start is called before the first frame update
    void Start()
    {
        //State = false;
        canvas = gameObject.transform.GetChild(0);
        exeBtn = canvas.transform.GetChild(0).GetComponent<Button>();
        Panel = canvas.transform.GetChild(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        //if recive the leakge signal call changeStatus()
        if (Input.GetKeyDown(KeyCode.Space)){
            ChangeStatus();
        }
    }

    public void ChangeStatus()
    {
        if (State == false)
        {
            for (int i = 0; i < Panel.childCount; i++)
            {
                if (i == 0)
                {
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "Pipe Bending Half 4";
                }
                else if (i == 1)
                {
                    //this value will be depending on the flow rate value
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "Good";
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().color = Color.blue;
                }
                else if (i == 2)
                {
                    //this value will come from the flow rate sensor
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "1000 m/s";
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().color = Color.blue;
                }
            }
            exeBtn.GetComponent<Image>().color = Color.gray;
            exeBtn.enabled = false;
        }
        else
        {
            for (int i = 0; i < Panel.childCount; i++)
            {
                if (i == 0)
                {
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "Pipe Bending Half 4";
                }
                else if (i == 1)
                {
                    //this value will be depending on the flow rate value
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "Need Replacement";
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().color = Color.red;
                }
                else if (i == 2)
                {
                    //this value will come from the flow rate sensor
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().text = "130 m/s";
                    Panel.transform.GetChild(i).GetChild(1).GetComponent<Text>().color = Color.red;
                }
            }
            exeBtn.GetComponent<Image>().color = Color.red;
            exeBtn.enabled = true;

        }

    }
}
