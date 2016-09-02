using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sounds : MonoBehaviour {

    public static bool isSoundOn = true;
    public static bool isMusicOn = true;

    public Text soundText;
    public Text musicText;

    public Image soundImage;
    public Image musicImage;

    public Sprite soundOn;
    public Sprite soundOff;
    public Sprite musicOn;
    public Sprite musicOff;

    public void toggleSound()
    {
        if(Sounds.isSoundOn == true)
        {
            soundImage.GetComponent<Image>();
            soundImage.sprite = soundOff;
            isSoundOn = false;

            soundText.text = "un-mute sounds";
            //turn sfx off
        }
        else if(Sounds.isSoundOn == false)
        {
            soundImage.GetComponent<Image>();
            soundImage.sprite = soundOn;
            isSoundOn = true;

            soundText.text = "mute sounds";
            //turn sfx on
        }
    }


    public void toggleMusic()
    {
        if (Sounds.isMusicOn == true)
        {
            musicImage.GetComponent<Image>();
            musicImage.sprite = musicOff;
            isMusicOn = false;

            musicText.text = "un-mute music";
            //turn Music off
        }
        else if (Sounds.isMusicOn == false)
        {
            musicImage.GetComponent<Image>();
            musicImage.sprite = musicOn;
            isMusicOn = true;

            musicText.text = "mute music";
            //turn Music on
        }
    }
}


