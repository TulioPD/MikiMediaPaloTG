using UnityEngine;

public class test : MonoBehaviour
{
    public Canvas canvasToSreenShot;

    // Use this for initialization
    void Start()
    {
        //Subscribe
        CanvasScreenShot.OnPictureTaken += receivePNGScreenShot;
        CanvasScreenShot screenShot = GameObject.Find("Canvas").GetComponent<CanvasScreenShot>();

        //take ScreenShot(Image and Text)
        //screenShot.takeScreenShot(canvasToSreenShot, SCREENSHOT_TYPE.IMAGE_AND_TEXT, false);
        //take ScreenShot(Image only)
        screenShot.takeScreenShot(canvasToSreenShot, SCREENSHOT_TYPE.IMAGE_ONLY, false);
        //take ScreenShot(Text only)
        // screenShot.takeScreenShot(canvasToSreenShot, SCREENSHOT_TYPE.TEXT_ONLY, false);

    }

    public void OnEnable()
    {
        //Un-Subscribe
        CanvasScreenShot.OnPictureTaken -= receivePNGScreenShot;
    }

    void receivePNGScreenShot(byte[] pngArray)
    {
        Debug.Log("Picture taken");

        //Do Something With the Image (Save)
        string path = Application.persistentDataPath + "/CanvasScreenShot.png";
        System.IO.File.WriteAllBytes(path, pngArray);
        Debug.Log(path);
    }

}