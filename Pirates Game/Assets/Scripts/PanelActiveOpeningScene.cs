using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelActiveOpeningScene : MonoBehaviour
{

    public GameObject AboutPanel;

    void Start()
    {
        AboutPanel.SetActive(false);
    }

    public void AboutButton()
    {
        AboutPanel.SetActive(true);
    }

}
