using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallSpawn : MonoBehaviour {

    public BallExit count;
    public SpriteRenderer sprender;
    public Text countText;


    void Start()
    {
        Time.timeScale = 1;
        if (gameObject.CompareTag("Respawn"))
        {
            sprender = gameObject.GetComponent<SpriteRenderer>();
            sprender.enabled = false;   
        }
    }

void OnMouseDown()
    {
        if (BallExit.isBallActive == false && Canvas_init.isCanvasActive == false)
        {
            BallExit.isBallActive = true;
            GameObject ball = (GameObject)Resources.Load("BallSprite");
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
            Instantiate(ball, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
        }
    }

}
