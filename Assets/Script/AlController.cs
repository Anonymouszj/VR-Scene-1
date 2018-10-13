using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    public FSM fsm;
    void Start()
    {
        fsm = GetComponent<FSM>();
        fsm.ac = this;      //初始化一个默认状态机        
        fsm.ChangeState(new OpenState());
    }
    public void Open()
    {
        
    }
}
