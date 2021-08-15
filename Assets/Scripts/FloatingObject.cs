using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FloatingObject : MonoBehaviour
{

	[SerializeField]
	private float maxInitialForce;
	[SerializeField]
	private float maxVelocity;

	[SerializeField]
	private float maximuSpin;


	[SerializeField]
	private Rigidbody2D physicsBody;

	
	void OnEnable()
    {
		physicsBody.angularVelocity = Random.Range(-maximuSpin, maximuSpin);

		physicsBody.SetRotation(Random.Range(0, 360));
		physicsBody.AddRelativeForce(new Vector2(Random.Range(0, maxInitialForce), 0));
	}

	private void FixedUpdate()
	{
		physicsBody.velocity = Vector2.ClampMagnitude(physicsBody.velocity, maxVelocity);
		physicsBody.angularVelocity = Mathf.Clamp( physicsBody.angularVelocity, -maximuSpin, maximuSpin);
	}
}
