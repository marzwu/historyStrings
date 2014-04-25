using UnityEngine;
using System.Collections;

public class onClickHandler : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnClick ()
		{
				Debug.Log ("hello world");
				print ("print");
		
				GameObject label = GameObject.Find ("name0");
				string [] names = {"go", "where", "here"};
				int index = (int)(Random.Range((float)0.0, (float)2.9999));
				label.GetComponent<UILabel> ().text = names [index];
		}


}
