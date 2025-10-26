using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		AudioManager.Instance.PlaySFX("Axe");
		AudioManager.Instance.PlaySFX("ChickenScream");
		Debug.Log("Starting Game!");
		AudioManager.Instance.musicSource.Stop();
		Debug.Log("Stopping MainMenu Music.");
		SceneManager.LoadScene("GameScene");
	}
	public void QuitGame()
	{
		Debug.Log("Quit!");
		AudioManager.Instance.PlaySFX("Chop");
		Application.Quit();
	}
}
