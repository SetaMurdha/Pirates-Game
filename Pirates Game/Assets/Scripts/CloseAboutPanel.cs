using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseAboutPanel : MonoBehaviour
{
    public GameObject Panel;

    public void closePanel()
    {
        Panel.SetActive(false);
    }
}
