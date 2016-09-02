using UnityEngine;
using System.Collections;

public class Canvas_init : MonoBehaviour {

    public Transform canvas;
    public static bool isCanvasActive;

    public void open()
    {
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        isCanvasActive = true;
    }

    public void close()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        isCanvasActive = false;
    }
}
