using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	private bool jarras = false;

	void Start(){
		NotificationCenter.DefaultCenter().AddObserver(this, "RecibirComprobacion");
	}

	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (speed.x * inputX, speed.y * inputY, 0);

		movement *= Time.deltaTime;

		transform.Translate (movement);

		bool shoot = Input.GetButtonDown ("Fire2");
		//shoot |= Input.GetButtonDown ();

		if (shoot){
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null) {
				NotificationCenter.DefaultCenter().PostNotification(this, "TieneMunicion", jarras);
				if (jarras){
					weapon.Attack(false);
					jarras = false;
				}
			}
		}
	}

	void RecibirComprobacion(Notification not){
		jarras = (bool)not.data;

	}
}
