using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAUBehaviour : MonoBehaviour {

	public virtual IEnumerator ThreadedUpdate()
	{
		yield return null;
	}

	public virtual IEnumerator ThreadedFixedUpdate()
	{
		yield return null;
	}

	private void OnEnable()
	{
		//Enable Updates
	}

	private void OnDisable()
	{
		//Disable Updates
	}

