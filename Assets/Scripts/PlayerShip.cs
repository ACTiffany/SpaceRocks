using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
	[SerializeField]
	private float thrust;
	[SerializeField]
	private float turnRate;

	[SerializeField]
	private Rigidbody2D physicsBody;

	// Start is called before the first frame update
	void Start()
    {
        
    }


	private void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W))
			physicsBody.AddRelativeForce(new Vector2(0, thrust));

		if (Input.GetKey(KeyCode.A))
			physicsBody.AddTorque(turnRate);
		if (Input.GetKey(KeyCode.D))
			physicsBody.AddTorque(-turnRate);

	}
}
