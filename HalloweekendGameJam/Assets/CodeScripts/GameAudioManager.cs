using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameAudioManager : MonoBehaviour
{
	public static GameAudioManager Instance;

	public Sound[] musicSounds, sfxSounds;
	public AudioSource musicSource, sfxSource;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void Start()
	{
		PlayMusic("GameMusic");
	}

	public void ClickSFX(float volume)
	{
		AudioManager.Instance.PlaySFX("Chop");
	}
	public void PlayMusic(string name)
	{
		Sound s = Array.Find(musicSounds, x => x.name == name);

		if (s == null)
		{
			Debug.Log("Music Not Found");
		}

		else
		{
			musicSource.clip = s.clip;
			musicSource.Play();
		}
	}

	public void PlaySFX(string name)
	{
		Sound s = Array.Find(sfxSounds, x => x.name == name);

		if (s == null)
		{
			Debug.Log("SFX not Found");
		}

		else
		{
			sfxSource.PlayOneShot(s.clip);
		}
	}
	public void ToggleMusic()
	{
		AudioManager.Instance.PlaySFX("Chop");
		musicSource.mute = !musicSource.mute;
	}

	public void ToggleSFX()
	{
		AudioManager.Instance.PlaySFX("Chop");
		sfxSource.mute = !sfxSource.mute;
	}

	public void MusicVolume(float volume)
	{
		musicSource.volume = volume;
		AudioManager.Instance.PlaySFX("scroll");
	}

	public void SFXVolume(float volume)
	{
		sfxSource.volume = volume;
		AudioManager.Instance.PlaySFX("scroll");
	}


}
