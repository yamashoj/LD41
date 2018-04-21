﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

	//public static AudioManager instance;

	// Use this for initialization
	void Awake () {

//		if (instance == null) {
//			instance = this;
//		} else {		
//			Destroy (gameObject);
//			return;
//		}

		foreach (Sound s in sounds) {

			s.source = gameObject.AddComponent<AudioSource> ();

			s.source.volume = s.volume;
			s.source.clip = s.clip;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;

		}

	}

	void Start () {

		Play ("MainTheme");

	} 
	
	public void Play (string name) {

		Sound s = Array.Find (sounds, sound => sound.name == name);

		if (s == null) {

			Debug.LogWarning ("Sound: " + s.name + " not found!");
			return;

		}
				
		s.source.Play();
	}
}
