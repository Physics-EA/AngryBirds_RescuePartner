using UnityEngine;
using System.Collections;

public class Level_1 : MonoBehaviour {

	public GameObject Bird;
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
		next.Current_Level = next.LEVEL.LEVEL_1;
		next.Next_Level = next.LEVEL.LEVEL_2;
		Instantiate(Bird, new Vector3 (-1.162564f,0.7085185f,-0.2f), new Quaternion());
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
