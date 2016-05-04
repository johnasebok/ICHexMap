using UnityEngine;
using System.Collections;

public class continueButton : MonoBehaviour {
    public GameObject gameScreenToEnable;
    public GameObject gameScreentodisable;
    // Use this for initialization
    public void buttonClicked()
    {
        gameScreenToEnable.SetActive(true);
        gameScreentodisable.SetActive(false);
    }
}
