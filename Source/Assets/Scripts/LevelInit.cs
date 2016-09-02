using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelInit : MonoBehaviour {

    public Transform failed_ui;
    public Transform passed_ui;


    public void levelInit()
    {
        Time.timeScale = 1;
        failed_ui.gameObject.SetActive(false);
        passed_ui.gameObject.SetActive(false);
        BallExit.isBallActive = false;
        BallExit.count = 3;
    }
}
