using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour {

    public Transform canvas;

	void Start ()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
	
    public SpriteRenderer sprender;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("CoinSprite"))
        {
             other.gameObject.SetActive(false);

            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
