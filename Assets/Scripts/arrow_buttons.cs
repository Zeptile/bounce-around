using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class arrow_buttons : MonoBehaviour {

    public void nextPlanet()
    {
        PlanetPicker.planetId = PlanetPicker.planetId + 1;
    }

    public void previousPlanet()
    {
        PlanetPicker.planetId = PlanetPicker.planetId - 1;
    }

    public void loadLevelPicker()
    {
        SceneManager.LoadScene(PlanetPicker.scene);
    }
}
