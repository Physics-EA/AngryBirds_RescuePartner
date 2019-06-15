using UnityEngine;
using System.Collections;

public class Level_5 : MonoBehaviour {
	public GameObject brid;
	
	void Start () 
	{
		
		if(Camera.main.audio.isPlaying == false)
		{
			if(welcome_win_id.Music_Config == true)
			{
				Camera.main.audio.Play();
			}
		}
		else
		{
			if(welcome_win_id.Music_Config == false)
			{
				Camera.main.audio.Pause();
			}
		}
		next.Current_Level = next.LEVEL.LEVEL_5;
		next.Next_Level = next.LEVEL.LEVEL_6;
		Instantiate(brid,new Vector3 (-1.162564f,-0.5834464f,-0.1f),new Quaternion());
	}
	
	void Update () 
	{
	
	}
}
