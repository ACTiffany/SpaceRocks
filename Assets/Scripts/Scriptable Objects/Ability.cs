using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Ability : ScriptableObject
{
	// **Data Fields**
	[SerializeField]
	private float coolDown;

	// **Properties**
	public float CoolDown { get => coolDown; }

	// **Private Methods**

	// **Public Methods**
	public abstract void ActivateAbility(GameObject parentObject, Transform abilityOrigin);

	// **Events**
}
