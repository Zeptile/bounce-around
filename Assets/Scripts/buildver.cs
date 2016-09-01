using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class buildver : MonoBehaviour {

    public string build_version;
    public Text buildText;


    void start()
    {
        buildText.text = "Build Version : " + build_version;
    }

	void update ()
    {

    }
	
}
