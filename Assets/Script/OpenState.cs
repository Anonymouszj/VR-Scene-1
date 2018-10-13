using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenState : IState
{

    public void Execute(AIController ac)
    {
        if (ac.fsm.isCanOpen)
        {
            ac.Open();
        }
        else
        {
            ac.fsm.ChangeState(new IdleState());
        }
    }

    private class IdleState : OpenState
    {

    }
}
