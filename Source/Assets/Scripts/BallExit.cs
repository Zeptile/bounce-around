using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallExit : MonoBehaviour {
    public SpriteRenderer sprender;

    public static int count = 3;
    public static bool isBallActive;
    public Transform canvas;

    public Text countText;


    void Start () {
        GameObject theball = GameObject.Find("Respawn");
    }
	
	void Update ()
    {
        if( count == 0)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        setCountText();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
        count = count - 1;
        isBallActive = false;
    }

    void setCountText()
    {
        countText.text = ": " + count.ToString();
    }
}
