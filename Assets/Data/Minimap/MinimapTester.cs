using UnityEngine;
using UnityEngine.UI;

public class MinimapTester : MonoBehaviour
{
    [SerializeField]
    private RectTransform dot;

    // README example coordinate
    private float worldX = -301.45f;
    private float worldZ = -355.55f;

    // Ambrose Valley config
    private float originX = -370f;
    private float originZ = -473f;
    private float scale = 900f;

    private void Start()
    {
        float u = (worldX - originX) / scale;
        float v = (worldZ - originZ) / scale;
        float pixelX = u * 1024f;
        float pixelY = (1f - v) * 1024f;

        dot.anchoredPosition = new Vector2(pixelX, -pixelY);
        Debug.Log($"Pixel: {pixelX}, {pixelY}");
    }
}