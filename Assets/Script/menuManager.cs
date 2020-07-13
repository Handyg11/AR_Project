using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public GameObject allPanel, insertARText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        allPanel.SetActive(false);
        insertARText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton1(){
        SceneManager.LoadScene("Cube");
    }
    public void PlayButton2(){
        SceneManager.LoadScene("Sphere");
    }
    public void PlayButton3(){
        SceneManager.LoadScene("Cylinder");
    }
}
