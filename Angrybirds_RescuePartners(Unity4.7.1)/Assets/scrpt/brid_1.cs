using UnityEngine;
using System.Collections;

public class brid_1 : MonoBehaviour 
{
	Vector3 Brid_Point=new Vector3(0.0f,0.0f,0.0f);
	
	void Start () 
	{
		Brid_Point = this.transform.position;
	}
	
	void Update () 
	{
		if(Input.GetKey("up"))
		{
			this.transform.position += new Vector3(0.0f,0.5f*Time.deltaTime,0.0f);
		}
		if(Input.GetKey("down"))
		{
			this.transform.position -= new Vector3(0.0f,0.5f*Time.deltaTime,0.0f);
		}
		if(Input.GetKey("right"))
		{
			this.transform.position += new Vector3(0.5f*Time.deltaTime,0.0f,0.0f);
		}
		if(Input.GetKey("left"))
		{
			this.transform.position -= new Vector3(0.5f*Time.deltaTime,0.0f,0.0f);
		}
	}
	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.name == "bird_help")
		{
			Debug.Log("In Nextlevel");
		}
		else
		{
			this.transform.position = Brid_Point;
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if(other.name=="bird_help")
		{
			Application.LoadLevel("Next");
			print("zzzzzzzzzzzzzzzzzzzzzzzzzz");
		}
		else
		{
			this.transform.position = Brid_Point;
			print("sssssssssssssssssssssssssssssss");
		}
	}

}
