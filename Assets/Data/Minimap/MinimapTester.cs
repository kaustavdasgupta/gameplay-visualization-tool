using UnityEngine;
using UnityEngine.UI;

public class MinimapTester : MonoBehaviour
{
    [SerializeField]
    private RectTransform minimap;

    [SerializeField]
    private RectTransform dot;

    private float worldX = -301.45f;
    private float worldZ = -355.55f;

    private float originX = -370f;
    private float originZ = -473f;
    private float scale = 900f;

    private void Start()
    {
        float u = (worldX - originX) / scale;
        float v = (worldZ - originZ) / scale;
        float pixelX = u * minimap.rect.width;
        float pixelY = (1f - v) * minimap.rect.height;
        float localX = pixelX - minimap.rect.width * 0.5f;
        float localY = (minimap.rect.height * 0.5f) - pixelY;

        dot.anchoredPosition =new Vector2(localX, localY);
        Debug.Log($"Dot Position: {dot.anchoredPosition}");
    }
}