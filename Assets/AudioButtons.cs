using UnityEngine;
using System.Collections;

public class AudioButtons : MonoBehaviour {
	public AudioSource Player;
	public AudioClip Fall;
	public AudioClip Confused;
	public AudioClip Die;
	public AudioClip Steps;
	public AudioClip Swipe;
	public AudioClip Morning;
	public AudioClip Winter;
	public AudioClip Bonus;
	public AudioClip Pause;

	public void PlayFall () {
		Player.clip = Fall;
		Player.loop = false;
		Player.Play ();
	}
	public void PlayConfused () {
		Player.clip = Confused;
		Player.Play ();
		Player.loop = false;
	}
	public void PlayDie () {
		Player.clip = Die;
		Player.Play ();
		Player.loop = false;
	}
	public void PlaySteps () {
		Player.clip = Steps;
		Player.Play ();
		Player.loop = true;
	}
	public void PlaySwipe () {
		Player.clip = Swipe;
		Player.Play ();
		Player.loop = false;
	}
	public void PlayMorning () {
		Player.clip = Morning;
		Player.Play ();
		Player.loop = true;
	}
	public void PlayWinter () {
		Player.clip = Winter;
		Player.Play ();
		Player.loop = true;
	}
	public void PlayBonus () {
		Player.clip = Bonus;
		Player.Play ();
		Player.loop = true;
	}
	public void PlayPause () {
		Player.clip = Pause;
		Player.Play ();
		Player.loop = true;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
