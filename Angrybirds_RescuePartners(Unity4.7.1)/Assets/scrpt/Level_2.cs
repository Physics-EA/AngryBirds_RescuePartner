using UnityEngine;
using System.Collections;

public class Level_2 : MonoBehaviour 
{

    public GameObject Brid;
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
				Camera.main.audio.Stop();
			}
		}
		next.Current_Level = next.LEVEL.LEVEL_2;
		next.Next_Level = next.LEVEL.LEVEL_3;
		Instantiate(Brid,new Vector3(-1.131356f,0.5992891f,-0.2f),new Quaternion());
	}
	
	
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
	}
}
