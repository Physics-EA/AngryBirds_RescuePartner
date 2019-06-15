using UnityEngine;
using System.Collections;

public class welcome_win_id : MonoBehaviour 
{
	public static bool Music_Config = true ;
//	EventType event_type = EventType.MouseUp;
//	protected GameObject btn_music ;
//	protected int music_fang = 0;
	void Start () 
	{
		if(Camera.main.audio.isPlaying == false)
		{
			if(Music_Config == true)
			{
				Camera.main.audio.Play();
			}
		}
		else
		{
			if(Music_Config == false)
			{
				Camera.main.audio.Stop();
			}
		}
//		btn_music = GameObject.Find ("btn_music");
	}
	
	void Update ()
	{
		if(Camera.main.audio.isPlaying == false)
		{
			if(Music_Config == true)
			{
				Camera.main.audio.Play();
			}
		}
		else
		{
			if(Music_Config == false)
			{
				Camera.main.audio.Pause();
			}
		}
		if(Music_Config ==false)
		{
			if(this.name =="btn_music")
			{
				this.gameObject.GetComponent<tk2dSprite>().spriteId = 7;
			}
		}
		else
		{
			if(this.name =="btn_music")
			{
				this.gameObject.GetComponent<tk2dSprite>().spriteId = 8;
			}
		}
	}
	void ButtonUp()
	{
		if(this.name == "btn_start")
		{
			Application.LoadLevel("Level_1");
		}
		else if(this.name == "btn_jixu" )
		{
			Debug.Log("up btn_jixu");
		}
		else if(this.name == "btn_music")
		{
			
			if(Music_Config == true )
			{
				Music_Config = false;
				Debug.Log(Music_Config);
				this.gameObject.GetComponent<tk2dSprite>().spriteId = 7;
			}
			else
			{
				Music_Config = true;
				this.gameObject.GetComponent<tk2dSprite>().spriteId = 8;
				Debug.Log(Music_Config);
			}
		}
	}
}
