using UnityEngine;
using System.Collections;

public class Disparo2 : MonoBehaviour {

	public int daño = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
}
