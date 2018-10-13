using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VR_Door : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    private DOTweenAnimation doanimation;//获取doTween
    private bool isOpen=false;//判断是否开门
    private bool trigger=false;//触发状态
    public GameObject door;//获取门对象

    
    void Start () {
        doanimation = door.GetComponent<DOTweenAnimation>();
	}

    private void OnTriggerEnter(Collider other)
    {

        if (trigger == false)
        {
            if (isOpen == false)
            {
                doanimation.DOPlayForward();
                isOpen = true;
            }
            else
            {
                doanimation.DOPlayBackwards();
                isOpen = false;
            }
        }
        trigger = true;
    }
}
