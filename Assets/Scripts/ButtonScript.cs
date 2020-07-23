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
		Debug.Log("start1");
		SceneManager.LoadScene(1);
		Debug.Log("start2");
	}

	public void ExitGame()
	{
		Debug.Log("exit1");
		Application.Quit();
		Debug.Log("exit2");
	}
}