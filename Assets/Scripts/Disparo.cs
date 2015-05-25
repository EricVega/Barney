using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public LayerMask whatToHit;
	public GameObject Linea;

	void Start () {

	}
	

	void Update () {
		if (Input.GetButtonDown("Fire2")){
			//Debug.Log("Disparo");
			RaycastHit2D hit;
			hit = Physics2D.Raycast(this.transform.position, this.transform.right, 100, whatToHit);

			GameObject tmp = Instantiate(this.Linea) as GameObject;
			LineRenderer line = tmp.GetComponent<LineRenderer>();

			if (hit.collider) {
				Debug.Log("choca");
				line.SetPosition(0, this.transform.position);
				line.SetPosition(1, hit.point);
			}else{
				Debug.Log("No choca");
				line.SetPosition(0, this.transform.position);
				line.SetPosition(1, this.transform.position + (this.transform.right*10));
			}
			Destroy(tmp, 0.5f);
		}
	}
}
