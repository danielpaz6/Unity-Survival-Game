using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
	public Button playText;
	public Button exitText;

	public void StartLevel()
	{
		// The main menu scene is 0
		SceneManager.LoadScene(1);
	}

	public void ExitGame()
	{
		Application.Quit();
     }
}