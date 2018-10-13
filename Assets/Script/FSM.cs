using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void Execute(AIController ac);
}

public class FSM : MonoBehaviour  {
    public IState currentState
    {
        get;
        private set;
    }


    public bool isCanOpen = false;
    public AIController ac;

    void Start()
    {

    }

    public void ChangeState(IState newState)
    {
        currentState = newState;
    }

    void Update()
    {
        if (currentState != null && ac != null)

        { currentState.Execute(ac); }

    }

}
