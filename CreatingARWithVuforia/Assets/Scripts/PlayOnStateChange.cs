using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnStateChange : MonoBehaviour
{
	
		public AudioClip appearSound;
		public AudioClip disappearSound;

		private AudioSource audioSource;

		void Awake()
		{
			audioSource = GetComponent<AudioSource>();
			audioSource.enabled = false;


		}


		public void Init()
		{
			audioSource.enabled = true; ;
		}

		public void PlayOnAppear()
		{
			audioSource.clip = appearSound;
			audioSource.Play();
		}

		public void PlayOnDisappear()
		{
			audioSource.clip = disappearSound;
			audioSource.Play();
		}

}
