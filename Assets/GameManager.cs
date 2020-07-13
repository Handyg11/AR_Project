using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public void MenuButton(){
		SceneManager.LoadScene("Menu");
	}
	public void QuitButton(){
		Application.Quit();
	}
}
