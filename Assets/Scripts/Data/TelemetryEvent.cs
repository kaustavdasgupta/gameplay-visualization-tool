using UnityEngine;
using System;

[System.Serializable]
public class TelemetryEvent
{
    public string user_id;
    public string match_id;
    public string map_id;

    public float x;
    public float y;
    public float z;

    public string ts;
    public string eventType;
}
