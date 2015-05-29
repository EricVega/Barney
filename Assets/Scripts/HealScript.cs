using UnityEngine;
using System.Collections;

public class HealScript : MonoBehaviour {

	public int hp = 2;
	public bool isEnemy = true;
	
	void OnTriggerEnter2D (Collider2D collider) {
		Disparo2 shot = collider.gameObject.GetComponent<Disparo2> ();

		if (shot != null){
			if (shot.isEnemyShot != isEnemy){
				hp -= shot.daño;

				Destroy(shot.gameObject);
				if (hp <= 0){
					Destroy(gameObject);
					if (isEnemy == false) NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
				}
			}
		}
	}
}
