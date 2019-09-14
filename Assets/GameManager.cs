using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject brokenObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //if i got a leakage from the database
            brokenObject.transform.GetComponent<itemMatChanger>().changeToBroken();
        }
    }
}
