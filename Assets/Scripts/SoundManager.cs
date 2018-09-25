using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingletonMonoBehaviour<SoundManager>{

	[SerializeField]
	private AudioClip[] Sound = new AudioClip[10];
	private AudioSource audioSource;

	override protected void Awake()
    {
        base.Awake();
    }
	
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			PlaySound(1);
		}

		if(Input.GetKeyDown(KeyCode.C)){
			PlaySound(2);
		}

		if(Input.GetKeyDown(KeyCode.H)){
			PlaySound(3);
		}

		if(Input.GetKeyDown(KeyCode.M)){
			PlaySound(4);
		}

		if(Input.GetKeyDown(KeyCode.N)){
			PlaySound(5);
		}

		if(Input.GetKeyDown(KeyCode.O)){
			PlaySound(6);
		}

		if(Input.GetKeyDown(KeyCode.S)){
			PlaySound(7);
		}

		if(Input.GetKeyDown(KeyCode.Y)){
			PlaySound(8);
		}

		if(Input.GetKeyDown(KeyCode.P)){
			PlaySound(9);
		}

		if(Input.GetKeyDown(KeyCode.U)){
			PlaySound(10);
		}
	}

	public void PlaySound(int soundId){
		switch(soundId){
			case 1:
			audioSource.clip = Sound[0];
        	audioSource.Play ();
			break;
			case 2:
			audioSource.clip = Sound[1];
        	audioSource.Play ();
			break;
			case 3:
			audioSource.clip = Sound[2];
        	audioSource.Play ();
			break;
			case 4:
			audioSource.clip = Sound[3];
        	audioSource.Play ();
			break;
			case 5:
			audioSource.clip = Sound[4];
        	audioSource.Play ();
			break;
			case 6:
			audioSource.clip = Sound[5];
        	audioSource.Play ();
			break;
			case 7:
			audioSource.clip = Sound[6];
        	audioSource.Play ();
			break;
			case 8:
			audioSource.clip = Sound[7];
        	audioSource.Play ();
			break;
			case 9:
			audioSource.clip = Sound[8];
        	audioSource.Play ();
			break;
			case 10:
			audioSource.clip = Sound[9];
        	audioSource.Play ();
			break;
			default:
			break;
		}
	}
}
