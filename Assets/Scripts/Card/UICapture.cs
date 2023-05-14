using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class UICapture : MonoBehaviour
{
    [SerializeField] private string filePath = "Assets/CapturedImages/";
    [SerializeField] private string fileName = "ui";
    [SerializeField] private string fileExtension = "png";
    [SerializeField] private KeyCode captureKey = KeyCode.F;

    private Camera captureCamera;

    private void Start()
    {
        captureCamera = gameObject.AddComponent<Camera>();
        captureCamera.orthographic = true;
        captureCamera.enabled = false;
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(captureKey))
        {
            CaptureUIElement();
        }
    }

    private void CaptureUIElement()
    {
        if (captureCamera == null)
        {
            Debug.LogWarning("Capture camera is null.");
            return;
        }

        // get the UI element to capture
        RectTransform rect = GetComponent<RectTransform>();

        // set the capture camera's position and size to match the UI element's position and size
        captureCamera.transform.position = rect.position - new Vector3(rect.rect.width / 2f, rect.rect.height / 2f, 0f);
        captureCamera.orthographicSize = Mathf.Max(rect.rect.width / 2f, rect.rect.height / 2f);

        // render the UI element to a texture
        RenderTexture renderTexture = new RenderTexture((int)rect.rect.width, (int)rect.rect.height, 24);
        captureCamera.targetTexture = renderTexture;
        captureCamera.Render();

        // create a new texture and read the pixels from the render texture into it
        Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGBA32, false);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();
        RenderTexture.active = null;

        // encode the texture to a PNG file and save it
        byte[] bytes = texture.EncodeToPNG();
        Destroy(texture);

        string path = Path.Combine(filePath, fileName + "_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "." + fileExtension);
        File.WriteAllBytes(path, bytes);

        Debug.Log("UI element captured and saved to " + path);
    }
}
