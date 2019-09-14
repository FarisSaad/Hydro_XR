using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{

    public Data[] data;

    private string gameDataFileName = "data.json";
    // Start is called before the first frame update
    void Start()
    {
        LoadGameData();
    }

    private void LoadGameData()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<Data[]>(dataAsJson);

            //data = loadedData.allData;
        }
        else
        {
            Debug.LogError("Cannot Load Game Data!");
        }
    }
}
