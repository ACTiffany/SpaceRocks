using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
	[SerializeField]
	private float thrust;
	[SerializeField]
	private float maxVelocity;

	[SerializeField]
	private float turnRate;
	[SerializeField]
	private float maxTurnRate;


	[SerializeField]
	private Rigidbody2D physicsBody;

	// Active movement Values
	private bool isAccelerating = false;
	private Vector2 currentAcceleration;
	
	private bool isTurning = false;
	private float currentTurn;


	private void FixedUpdate()
	{
		HandleMovement();
	}

	// Movement Controls
	private void HandleMovement()
	{
		if (isAccelerating)
			physicsBody.AddRelativeForce(currentAcceleration);

		if (isTurning)
			physicsBody.AddTorque(-currentTurn);

		physicsBody.velocity = Vector2.ClampMagnitude(physicsBody.velocity, maxVelocity);
		physicsBody.angularVelocity = Mathf.Clamp(physicsBody.angularVelocity, -maxVelocity, maxVelocity);

	}
	public void OnThrust(InputAction.CallbackContext value)
	{
		if (value.started)
		{
			isAccelerating = true;
			currentAcceleration = value.ReadValue<Vector2>() * new Vector2(0, 1 * thrust);
		}

		if (value.canceled)
		{
			isAccelerating = false;
		}
	}
	public void OnTurn(InputAction.CallbackContext value)
	{
		if (value.started)
		{
			isTurning = true;
			currentTurn = value.ReadValue<Vector2>().x * turnRate;
		}

		if (value.canceled)
		{
			isTurning = false;
		}
	}
}
