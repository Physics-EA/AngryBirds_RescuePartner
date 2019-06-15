using UnityEngine;
using System.Collections;

public class Level_3: MonoBehaviour 
{
	public GameObject bird;
	GameObject zhuandong;
	// Use this for initialization
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
		next.Current_Level = next.LEVEL.LEVEL_3;
		next.Next_Level = next.LEVEL.LEVEL_4;
		Instantiate (bird,new Vector3(-1.06129f,0.7085185f,-0.3f),new Quaternion());
		zhuandong = GameObject.Find("zhuandong");
	}
	
	// Update is called once per frame
	void Update () 
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
		zhuandong.transform.Rotate(0.0f,0.0f,-70.0f*Time.deltaTime);
	}
}
