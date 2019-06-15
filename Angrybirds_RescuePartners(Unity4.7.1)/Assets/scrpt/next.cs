using UnityEngine;
using System.Collections;

public class next : MonoBehaviour 
{
	private int Next_Level_flang = 0;
	private int Return_Play_flang = 0;
	public GameObject Nexit_Level;
	public GameObject Return_Play;
	EventType event_type = EventType.MouseUp;
	public  enum LEVEL : int
	{
		LEVEL_1=0,
		LEVEL_2,
		LEVEL_3,
		LEVEL_4,
		LEVEL_5,
		LEVEL_6,
		LEVEL_7,
		LEVEL_8,
		LEVEL_9,
		LEVEL_10,
		LEVEL_11,
		LEVEL_12,
		LEVEL_13,
		LEVEL_14,
		LEVEL_15,
		LEVEL_16,
		LEVEL_17,
		LEVEL_18,
		LEVEL_19,
		LEVEL_20,
		LEVEL_21,
		LEVEL_22,
		LEVEL_23,
		LEVEL_24,
		LEVEL_25,
		LEVEL_26,
		LEVEL_27,
		LEVEL_28,
		LEVEL_29,
		LEVEL_30,
		LEVEL_31,
		LEVEL_32,
		LEVEL_33,
		LEVEL_34,
		LEVEL_35,
		LEVEL_36,
		LEVEL_37,
		LEVEL_38,
		LEVEL_39,
		LEVEL_40,
		LEVEL_41,
	};
	public static LEVEL Current_Level = LEVEL.LEVEL_1;
	public static LEVEL Next_Level = LEVEL.LEVEL_2;
	
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
	}
	
	void Update () 
	{
	
	}
	void OnGUI()
	{
		if(Event.current.type == EventType.MouseDown)
		{
			event_type = EventType.MouseDown;
			if(lyx_judge_scall_center_1(Input.mousePosition,Nexit_Level.transform.position,new Vector2(0.4791667F,0.2083333F))==true)
			{
				Next_Level_flang = 1;
				Nexit_Level.transform.localScale = new Vector3(1.1f,1.1f,1.0f);
			}
			else if(lyx_judge_scall_center_1(Input.mousePosition,Return_Play.transform.position,new Vector2(0.4791667F,0.2083333F))==true)
			{
				Return_Play_flang=1;
				Return_Play.transform.localScale = new Vector3(1.1f,1.1f,1.0f);
			}
				
		}
		else if(Event.current.type == EventType.MouseDrag &&event_type == EventType.MouseDown)
		{
			if(Next_Level_flang == 1 &&lyx_judge_scall_center_1(Input.mousePosition,Nexit_Level.transform.position,new Vector2(0.4791667F,0.2083333F))==false)
			{
				Nexit_Level.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
			}
			else if(Return_Play_flang==1 &&lyx_judge_scall_center_1(Input.mousePosition,Return_Play.transform.position,new Vector2(0.4791667F,0.2083333F))==false)
			{
				
				Return_Play.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
				
			}
		}
		else if(Event.current.type == EventType.MouseUp)
		{
			if(Next_Level_flang==1&& lyx_judge_scall_center_1(Input.mousePosition,Nexit_Level.transform.position,new Vector2(0.4791667F,0.2083333F))==true)
			{
				
				Nexit_Level.transform.localScale = new Vector3(1.1f,1.1f,1.1f);
				switch (Next_Level)
				{
					case LEVEL.LEVEL_2:
				{
					Application.LoadLevel("Level_2");
					break;
				}
				case LEVEL.LEVEL_3:
				{
					Application.LoadLevel("Level_3");
					break;
				}
				case LEVEL.LEVEL_4:
				{
					Application.LoadLevel("Level_4");
					break;
				}
				case LEVEL.LEVEL_5:
				{
					Application.LoadLevel("Level_5");
					break;
				}
				case LEVEL.LEVEL_6:
				{
					Application.LoadLevel("Level_6");
					break;
				}
				case LEVEL.LEVEL_7:
				{
					Application.LoadLevel("Level_7");
					break;
				}
				case LEVEL.LEVEL_8:
				{
					Application.LoadLevel("Level_8");
					break;
				}
				case LEVEL.LEVEL_9:
				{
					Application.LoadLevel("Level_9");
					break;
				}
				case LEVEL.LEVEL_10:
				{
					Application.LoadLevel("Level_10");
					break;
				}
				case LEVEL.LEVEL_11:
				{
					Application.LoadLevel("Level_11");
					break;
				}
				case LEVEL.LEVEL_12:
				{
					Application.LoadLevel("Level_12");
					break;
				}
				case LEVEL.LEVEL_13:
				{
					Application.LoadLevel("Level_13");
					break;
				}
				case LEVEL.LEVEL_14:
				{
					Application.LoadLevel("Level_14");
					break;
				}
				case LEVEL.LEVEL_15:
				{
					Application.LoadLevel("Level_15");
					break;
				}
				case LEVEL.LEVEL_16:
				{
					Application.LoadLevel("Level_16");
					break;
				}
				case LEVEL.LEVEL_17:
				{
					Application.LoadLevel("Level_17");
					break;
				}
				case LEVEL.LEVEL_18:
				{
					Application.LoadLevel("Level_18");
					break;
				}
				case LEVEL.LEVEL_19:
				{
					Application.LoadLevel("Level_19");
					break;
				}
				case LEVEL.LEVEL_20:
				{
					Application.LoadLevel("Level_20");
					break;
				}
				case LEVEL.LEVEL_21:
				{
						Application.LoadLevel("Level_21");
						break;
				}
				case LEVEL.LEVEL_22:
				{
					Application.LoadLevel("Level_22");
					break;
				}
				case LEVEL.LEVEL_23:
				{
					Application.LoadLevel("Level_23");break;
				}
				case LEVEL.LEVEL_24:
				{
					Application.LoadLevel("Level_24");break;
				}
				case LEVEL.LEVEL_25:
				{
					Application.LoadLevel("Level_25");break;
				}
				case LEVEL.LEVEL_26:
				{
					Application.LoadLevel("Level_26");break;
				}
				case LEVEL.LEVEL_27:
				{
					Application.LoadLevel("Level_27");break;
				}
				case LEVEL.LEVEL_28:
				{
					Application.LoadLevel("Level_28");break;
				}
				case LEVEL.LEVEL_29:
				{
					Application.LoadLevel("Level_29");break;
				}
				case LEVEL.LEVEL_30:
				{
					Application.LoadLevel("Level_30");break;
				}
				case LEVEL.LEVEL_31:
				{
						Application.LoadLevel("Level_31");
						break;
				}
				case LEVEL.LEVEL_32:
				{
					Application.LoadLevel("Level_32");
					break;
				}
				case LEVEL.LEVEL_33:
				{
					Application.LoadLevel("Level_33");break;
				}
				case LEVEL.LEVEL_34:
				{
					Application.LoadLevel("Level_34");break;
				}
				case LEVEL.LEVEL_35:
				{
					Application.LoadLevel("Level_35");break;
				}
				case LEVEL.LEVEL_36:
				{
					Application.LoadLevel("Level_36");break;
				}
				case LEVEL.LEVEL_37:
				{
					Application.LoadLevel("Level_37");break;
				}
				case LEVEL.LEVEL_38:
				{
					Application.LoadLevel("Level_38");break;
				}
				case LEVEL.LEVEL_39:
				{
					Application.LoadLevel("Level_39");break;
				}
				case LEVEL.LEVEL_40:
				{
					Application.LoadLevel("Level_40");break;
				}
				}
			}
			else if(lyx_judge_scall_center_1(Input.mousePosition,Return_Play.transform.position,new Vector2(0.4791667F,0.2083333F))==true)
			{
				
				Return_Play.transform.localScale = new Vector3(1.1f,1.1f,1.0f);
			switch (Current_Level )
			{
				case LEVEL.LEVEL_1:
				{
						Application.LoadLevel("Level_1");
						break;
				}
				case LEVEL.LEVEL_2:
				{
					Application.LoadLevel("Level_2");
					break;
				}
				case LEVEL.LEVEL_3:
				{
					Application.LoadLevel("Level_3");break;
				}
				case LEVEL.LEVEL_4:
				{
					Application.LoadLevel("Level_4");break;
				}
				case LEVEL.LEVEL_5:
				{
					Application.LoadLevel("Level_5");break;
				}
				case LEVEL.LEVEL_6:
				{
					Application.LoadLevel("Level_6");break;
				}
				case LEVEL.LEVEL_7:
				{
					Application.LoadLevel("Level_7");break;
				}
				case LEVEL.LEVEL_8:
				{
					Application.LoadLevel("Level_8");break;
				}
				case LEVEL.LEVEL_9:
				{
					Application.LoadLevel("Level_9");break;
				}
				case LEVEL.LEVEL_10:
				{
					Application.LoadLevel("Level_10");break;
				}
				case LEVEL.LEVEL_11:
				{
						Application.LoadLevel("Level_11");break;
						break;
				}
				case LEVEL.LEVEL_12:
				{
					Application.LoadLevel("Level_12");break;
					break;
				}
				case LEVEL.LEVEL_13:
				{
					Application.LoadLevel("Level_13");break;
				}
				case LEVEL.LEVEL_14:
				{
					Application.LoadLevel("Level_14");break;
				}
				case LEVEL.LEVEL_15:
				{
					Application.LoadLevel("Level_15");break;
				}
				case LEVEL.LEVEL_16:
				{
					Application.LoadLevel("Level_16");break;
				}
				case LEVEL.LEVEL_17:
				{
					Application.LoadLevel("Level_17");break;
				}
				case LEVEL.LEVEL_18:
				{
					Application.LoadLevel("Level_18");break;
				}
				case LEVEL.LEVEL_19:
				{
					Application.LoadLevel("Level_19");break;
				}
				case LEVEL.LEVEL_20:
				{
					Application.LoadLevel("Level_20");break;
				}
				case LEVEL.LEVEL_21:
				{
						Application.LoadLevel("Level_21");
						break;
				}
				case LEVEL.LEVEL_22:
				{
					Application.LoadLevel("Level_22");break;
					break;
				}
				case LEVEL.LEVEL_23:
				{
					Application.LoadLevel("Level_23");break;
				}
				case LEVEL.LEVEL_24:
				{
					Application.LoadLevel("Level_24");break;
				}
				case LEVEL.LEVEL_25:
				{
					Application.LoadLevel("Level_25");break;
				}
				case LEVEL.LEVEL_26:
				{
					Application.LoadLevel("Level_26");break;
				}
				case LEVEL.LEVEL_27:
				{
					Application.LoadLevel("Level_27");break;
				}
				case LEVEL.LEVEL_28:
				{
					Application.LoadLevel("Level_28");break;
				}
				case LEVEL.LEVEL_29:
				{
					Application.LoadLevel("Level_29");break;
				}
				case LEVEL.LEVEL_30:
				{
					Application.LoadLevel("Level_30");break;
				}
				case LEVEL.LEVEL_31:
				{
						Application.LoadLevel("Level_31");
						break;
				}
				case LEVEL.LEVEL_32:
				{
					Application.LoadLevel("Level_32");break;
					break;
				}
				case LEVEL.LEVEL_33:
				{
					Application.LoadLevel("Level_33");break;
				}
				case LEVEL.LEVEL_34:
				{
					Application.LoadLevel("Level_34");break;
				}
				case LEVEL.LEVEL_35:
				{
					Application.LoadLevel("Level_35");break;
				}
				case LEVEL.LEVEL_36:
				{
					Application.LoadLevel("Level_36");break;
				}
				case LEVEL.LEVEL_37:
				{
					Application.LoadLevel("Level_37");break;
				}
				case LEVEL.LEVEL_38:
				{
					Application.LoadLevel("Level_38");break;
				}
				case LEVEL.LEVEL_39:
				{
					Application.LoadLevel("Level_39");break;
				}
				case LEVEL.LEVEL_40:
				{
					Application.LoadLevel("Level_40");break;
				}
			}
				
			}
					
			Next_Level_flang = 0;
			Return_Play_flang = 0;
			event_type = EventType.MouseUp;
		}
	}
	/// <summary>
	/// 判断点击的是不是在按钮上
	/// </summary>
	/// <param name=“point”>鼠标按下的位置</param>
	/// <param name='targe_position'>按钮的位置</param>
	/// <param name='scall'>按钮的大小</param>
	public static bool lyx_judge_scall_center_1(Vector3 point,Vector3 targe_position,Vector2 scall)
	{
			Vector3 mouse_point= Camera.main.ScreenToWorldPoint(new Vector3 (point.x,point.y,0.0f));
			float x1 = targe_position.x-(scall.x/2.0f);
			float x2 = targe_position.x+(scall.x/2.0f);
			float y1 = targe_position.y-(scall.y/2.0f);
			float y2 = targe_position.y+(scall.y/2.0f);
		if(mouse_point.x > x1 && mouse_point.x < x2 && mouse_point.y > y1 && mouse_point.y < y2)
			{
				return true;
			}
			else 
			{
				return false;
			}
	}
}
