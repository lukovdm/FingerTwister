using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float angularSpeed;
	public string currentPart;

	public void SpinArrow(){
		rigidbody2D.angularVelocity = Random.Range(angularSpeed * 0.7f, angularSpeed * 1.3f);
	}

	public void OnTriggerEnter2D(Collider2D other) {
		currentPart = other.name;
	}
}
