﻿using UnityEngine;
using System.Collections;

public class StateBase : MonoBehaviour, IState
{
	public virtual void StateStart(object context)
	{

	}

	public virtual void StateUpdate()
	{

	}

	public virtual void StateExit()
	{

	}
}
