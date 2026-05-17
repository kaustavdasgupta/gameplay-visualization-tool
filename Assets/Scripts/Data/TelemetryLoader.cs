using UnityEngine;

public class TelemetryLoader : MonoBehaviour
{
    [SerializeField]
    private TextAsset jsonFile;

    private void Start()
    {
        string modifiedJson = jsonFile.text.Replace("\"event\"", "\"eventType\"");
        string wrappedJson = "{ \"events\": " + modifiedJson + "}";

        TelemetryWrapper wrapper = JsonUtility.FromJson<TelemetryWrapper>(wrappedJson);

        Debug.Log($"Loaded Events: {wrapper.events.Count}");

        for (int i = 0; i < Mathf.Min(5, wrapper.events.Count); i++)
        {
            TelemetryEvent e = wrapper.events[i];
            //Debug.Log($"{e.eventType} | {e.x}, {e.z}");
        }
    }
}