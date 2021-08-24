using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        PlayerPrefs.DeleteAll();

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject); 
    }

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    public Char player;

    public FloatingTextManager floatingText;

    public int skor;
    public int experience;


    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += skor.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;
        

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        skor = int.Parse(data[1]);
        experience = int.Parse(data[2]);

        Debug.Log("Load State");
    }


    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingText.Show(msg, fontSize, color, position, motion, duration);
    }

}
