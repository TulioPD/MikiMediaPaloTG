using System.IO;

using UnityEditor;

using UnityEngine;
using UnityEngine.UI;

public class CardCapture : MonoBehaviour
{
    [SerializeField] private string filePath = "Assets/Resources/Sprites/CardImage/";
    [SerializeField] private string fileName = "card";
    [SerializeField] private string fileExtension = "jpg";
    [SerializeField] private KeyCode captureKey = KeyCode.F;

    private GameObject cardSelector;
    private Camera mainCamera;
    private Camera captureCamera;

    private void Start()
    {
        cardSelector = gameObject;
        mainCamera = Camera.main;
        captureCamera = mainCamera;
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(captureKey))
        {
            if (cardSelector != null && cardSelector.GetComponent<Image>() != null)
            {
                CaptureCardImage();
            }
            else
            {
                Debug.LogWarning("Card object or image component is null.");
            }
        }
    }

    public void CaptureCardImage()
    {
        if (captureCamera == null || cardSelector == null)
        {
            
            Debug.LogWarning("Capture camera or card selector is null.");
            return;
        }

        // create a new camera for rendering
        GameObject cameraObject = new GameObject("CardCaptureCamera");
        Camera newCamera = cameraObject.AddComponent<Camera>();
        newCamera.CopyFrom(captureCamera);

        // set the new camera as active
        newCamera.gameObject.SetActive(true);

        // set the Camera to render to the screen
        newCamera.targetTexture = null;

        // get the current resolution and set the render texture to that size
        int resWidth = Screen.currentResolution.width;
        int resHeight = Screen.currentResolution.height;
        RenderTexture renderTexture = new RenderTexture(resWidth, resHeight, 24);

        // assign the render texture to the Camera
        newCamera.targetTexture = renderTexture;

        // Render the Card
        newCamera.Render();

        // create a new texture with the same size as the render texture
        Texture2D texture = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);

        // Read the pixels from the render texture into the texture
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        RenderTexture.active = null;

        // Encode the texture to JPG format
        byte[] bytes = texture.EncodeToJPG();
        Destroy(texture);

        // set the file name and path
        string fileName = "Card_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
        string path = Path.Combine(Application.dataPath, "Resources", "Sprites", "CardImage", fileName);

        // write the bytes to the file
        File.WriteAllBytes(path, bytes);

        // destroy the new camera
        Destroy(cameraObject);

        // refresh the assets to make sure the new file is visible in the editor
        AssetDatabase.Refresh();

        // Log a message
        Debug.Log("Card image captured and saved to " + path);
    }

}
