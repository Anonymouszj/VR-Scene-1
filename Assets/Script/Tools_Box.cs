using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// 工具箱类
/// </summary>
public class Tools_Box : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    private Welding_Machine welding_Machine;
    private OTDR oTDR;
     public Welding_Machine Welding_Machine
    {
        get
        {
            return welding_Machine;
        }

        set
        {
            welding_Machine = value;
        }
    }

    public OTDR OTDR
    {
        get
        {
            return oTDR;
        }

        set
        {
            oTDR = value;
        }
    }
    private DOTweenAnimation animation; //获取DoTween动画
    private bool OpenBox = false;
    public GameObject Box;








    // Use this for initialization
    void Start () {
        animation = Box.GetComponent<DOTweenAnimation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (OpenBox = false)
        {
            animation.DOPlayForward();
            OpenBox = true;
        }
        else
        {
            animation.DOPlayBackwards();
            OpenBox = false;
        }
	}

    public void TakeTool(AEntity entity)
    {

    }

    public void PutTool(AEntity entity)
    {

    }
}
