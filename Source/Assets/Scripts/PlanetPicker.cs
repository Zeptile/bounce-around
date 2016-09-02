using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlanetPicker : MonoBehaviour {

    public static int planetId = 1;
    public static string scene = "lvlPick";
    public Text planetName;
    public Text description;

    public Sprite planet1;
    public Sprite planet2;
    public Sprite planet3;
    public Sprite planet4;

    private SpriteRenderer spriteRenderer;

    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = planet1;
        }
    }

    void Update()
    {
        if (planetId < 1)
            planetId = 4;
        if (planetId > 4)
            planetId = 1;

        switch (planetId)
        {
            case 1:
                spriteRenderer.sprite = planet1;
                scene = "lvlPick";
                planetName.text = "Earth land";
                description.text = "Something about earth";
                break;
            case 2:
                spriteRenderer.sprite = planet2;
                scene = "lvlPick2";
                planetName.text = "Jungle land";
                description.text = "Something about jungle";
                break;
            case 3:
                spriteRenderer.sprite = planet3;
                scene = "lvlPick3";
                planetName.text = "lava land";
                description.text = "Something about lava";
                break;
            case 4:
                spriteRenderer.sprite = planet4;
                scene = "lvlPick4";
                planetName.text = "Ice land";
                description.text = "Something about ice";
                break;
            default:
                spriteRenderer.sprite = planet1;
                break;
        }
	}

}
