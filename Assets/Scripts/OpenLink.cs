using UnityEngine;
using System.Collections;

public class OpenLink : MonoBehaviour {

    public void OpenURL(string name)
    {
        Application.OpenURL(name);
    }
}
