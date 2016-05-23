using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private Rigidbody myRigidbody;

	public float mySpeed = 10.0f;
	public float myRotationSpeed = 100.0f;


	private string myMovement = "Move";
	private string myRotation = "Rotate";

	private float myInputMov = 0.0f;
	private float myInputRot;


	void Start () {

	}

	public void Init() {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	private void Move() {
		myInputMov = Input.GetAxis (myMovement);
		Vector3 movement = transform.forward * myInputMov * mySpeed * Time.deltaTime;
		myRigidbody.MovePos (myRigidbody.position + movement);
	}

	private void Rotate() {
		myInputRot = Input.GetAxis (myRotation);
		float rotate = myInputRot * myRotationSpeed * Time.deltaTime;
		Quaternion turnRot = Quaternion.Euler (0f, rotate, 0f);
		myRigidbody.MoveRot (myRigidbody.rotation * turnRot);
	}

	public void setPosition(Transform spawnPosition) {
		myRigidbody.position = spawnPosition.position;
	}
		
	void Update () {
		Move ();
		Rotate ();
	}
}
