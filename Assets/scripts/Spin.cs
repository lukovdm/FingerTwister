using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public int angularSpeed;

	public void SpinArrow(){
		rigidbody2D.AddTorque (angularSpeed);
		Debug(
	}
}
