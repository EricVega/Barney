using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class BotonMedallas : MonoBehaviour {

	private TextMesh textoBoton;
	
	void Awake(){
		textoBoton = GetComponent<TextMesh>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textoBoton.color = Social.localUser.authenticated ? Color.white : Color.gray;	
	}
	
	void OnMouseDown(){
		GetComponent<AudioSource>().Play();
		
		if(Social.localUser.authenticated){
			Social.Active.ShowAchievementsUI();
		}else{
			Social.localUser.Authenticate((bool success) => {});
		}
	}	
}
