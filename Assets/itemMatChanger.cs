using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMatChanger : MonoBehaviour
{
    [SerializeField]private Material brokenMat;
    [SerializeField]private Material normalMat;
    public string a = "your code can access the itemMatChanger";
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material = normalMat;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void changeToBroken()
    {
        gameObject.GetComponent<Renderer>().material = brokenMat;
    }
    public void changeToNormal()
    {
        gameObject.GetComponent<Renderer>().material = normalMat;
    }
}
