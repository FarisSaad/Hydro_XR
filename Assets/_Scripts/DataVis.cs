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
    float time = 0.25f;

    public float debug1;
    public float debug2;

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
                    debug1 = Random.Range(eMin, emax);
                    t[i].text = debug1.ToString();
                }
                else
                {
                    debug2 = Random.Range(normalMin, noralmax);
                    t[i].text = debug2.ToString();
                }
            }
        }   
    }
}
