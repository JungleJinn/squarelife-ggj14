﻿using UnityEngine;
using System.Collections;

/// <summary>
/// The Player's logic - input
/// </summary>

[RequireComponent(typeof(Moving), typeof(Jumping))]
public class PlayerController : MonoBehaviour
{
	// editor variables:

	/// <summary>
	/// Max age in seconds
	/// </summary>
	[SerializeField]
	private float maxAge;

	// publics:

	/// <summary>
	/// the player's current normalized age (0..1)
	/// </summary>
	public float NormalizedAge
	{
		get;
		private set;
	}

	// component refs:

	private Moving moving;
	private Jumping jumping;

	void Awake()
	{

		moving = GetComponent<Moving>();
		jumping = GetComponent<Jumping>();
	}

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		NormalizedAge += Time.deltaTime / maxAge;
	}

	public void MoveHorizontal(float axisValue)
	{
		moving.SetDirection(axisValue);
	}

	public void Jump(bool jump)
	{
		jumping.SetJumping(jump);
	}
}
