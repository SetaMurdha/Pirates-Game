using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour
{
    //public GameObject benar, salah;
        // Start is called before the first frame update
        void Start()
        {
            
        }
    
    public void jawaban (bool jawab){
            if (jawab){
                // benar.SetActive(false);
                // benar.SetActive(true);
                Debug.Log("Jawaban Benar");
                int skor = PlayerPrefs.GetInt("skor") + 10;
                PlayerPrefs.SetInt ("skor", skor);
            }else{
                //salah.SetActive(false);
                // salah.SetActive(true);
                Debug.Log("Jawaban Salah");
            }
            gameObject.SetActive (false);
            transform.parent.GetChild (gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
