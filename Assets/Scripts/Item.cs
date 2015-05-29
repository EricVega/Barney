using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int puntosGanados = 5;
	public int cervezuquis = 1;
	public AudioClip itemSoundClip;
	public float itemSoundVolume = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarMunicion", cervezuquis);
			AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
		}
		Destroy(gameObject);
	}
}
