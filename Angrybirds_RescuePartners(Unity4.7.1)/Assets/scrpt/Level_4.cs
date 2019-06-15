using UnityEngine;
using System.Collections;

public class Level_4 : MonoBehaviour 
{
	protected GameObject pig;
	protected GameObject zhuandong;
	public GameObject bird;
	void Start () 
	{
		//bird = this.transform.position;
		//GameObject bird_p = Resources.Load("/bird") as GameObject;
		//GameObject instance = Instantiate(Resources.Load("bird")) as GameObject;
		//instance.transform.position = new Vector3(-1.162564f,-0.5592561f,-0.3f);
		zhuandong =GameObject.Find("zhuandong");
		pig = GameObject.Find ("pig");
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
		next.Current_Level = next.LEVEL.LEVEL_4;
		next.Next_Level = next.LEVEL.LEVEL_5;
		Instantiate(bird,new Vector3(-1.162564f,-0.5592561f,-0.3f),new Quaternion());
	}
	
	void Update () 
	{
		zhuandong.transform.Rotate(0.0f,0.0f,-100.0f*Time.deltaTime);
	}
}
