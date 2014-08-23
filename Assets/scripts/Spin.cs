using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float angularSpeed;

	public void SpinArrow(){
		rigidbody2D.angularVelocity = Random.Range(angularSpeed - 1, angularSpeed + 1);
		Debug.Log ("Spin!! button");
	}

	void Update () {
		Debug.Log (rigidbody2D.angularVelocity);
	}
}
