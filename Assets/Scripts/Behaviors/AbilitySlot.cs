using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class AbilitySlot : MonoBehaviour
{
	// **Data Fields**
	[SerializeField]
	private Ability ability;
	[SerializeField]
	private Transform abilityOrigin;
	[SerializeField]
	private GameObject parentObject;

	private float coolDownExpiration;

	// **Properties**
	public Ability Ability { get => ability; set => ability = value; }
	public Transform AbilityOrigin { get => abilityOrigin; set => abilityOrigin = value; }
	public GameObject ParentObject { get => parentObject; set => parentObject = value; }

	// **Private Methods**
	private void Start()
	{
		coolDownExpiration = Time.time;
	}

	// **Public Methods**
	public void OnActivateAbility(InputAction.CallbackContext value)
	{
		if (Time.time > coolDownExpiration)
		{
			// Activate the Ability
			Ability.ActivateAbility(ParentObject, AbilityOrigin);
			// Set the cooldown timer
			coolDownExpiration = Time.time + Ability.CoolDown;
		}
	}

	// **Events**
}
