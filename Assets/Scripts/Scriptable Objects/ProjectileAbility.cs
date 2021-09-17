using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Ability", menuName = "Assets/Projectile Abilities")]
public class ProjectileAbility : Ability
{
	// **Data Fields**
	[SerializeField]
	private Projectile projectilePrefab;
	[SerializeField]
	private float projectileForce;

	// **Properties**
	public Projectile ProjectilePrefab { get => projectilePrefab; }
	public float ProjectileForce { get => projectileForce; }

	// **Private Methods**

	// **Public Methods**
	public override void ActivateAbility(GameObject parentObject, Transform abilityOrigin)
	{
		Rigidbody2D parentBody = parentObject.GetComponent<Rigidbody2D>();

		Projectile projectile = Instantiate(ProjectilePrefab, abilityOrigin.position, abilityOrigin.rotation);
		Rigidbody2D projectileBody = projectile.GetComponent<Rigidbody2D>();

		projectileBody.velocity = parentBody.velocity;
		projectileBody.AddRelativeForce(Vector2.up * ProjectileForce);
	}
	// **Events**
}
