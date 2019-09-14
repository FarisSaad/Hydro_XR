using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataVis : MonoBehaviour
{
    public Text[] t;

    public float normalMin = 900f;
    public float noralmax = 1100f;

    public float eMin = 50f;
    public float emax = 150f;

    float timer = 0;
    float time = 2f;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= time)
        {
            timer = 0;

            // shown data

            for (int i = 0; i < t.Length; i++)
            {
                if (i == 0)
                {
                    t[i].text = Random.Range(eMin, emax).ToString();
                }
                else
                {
                    t[i].text = Random.Range(normalMin, noralmax).ToString();
                }
            }
        }   
    }
}
