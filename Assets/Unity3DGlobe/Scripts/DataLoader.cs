using UnityEngine;
using System.Collections;

public class DataLoader : MonoBehaviour {
    public DataVisualizer Visualizer;
    // Use this for initialization

    public string fileName;

	void Start () {
        TextAsset jsonData = Resources.Load<TextAsset>(fileName);
        string json = jsonData.text;
        SeriesArray data = JsonUtility.FromJson<SeriesArray>(json);
        Visualizer.CreateMeshes(data.AllData);

    }

	void Update () {

	}
}
[System.Serializable]
public class SeriesArray
{
    public SeriesData[] AllData;
}
