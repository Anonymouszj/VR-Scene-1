using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 熔接机类
/// </summary>
public class Welding_Machine:AEntity
{
    public override void Init()
    {

    }
    private Optical_Fiber optical1;//要熔接的光纤1
    private Optical_Fiber optical2;//要熔接的光纤2
    public Optical_Fiber Optical1
    {
        get
        {
            return optical1;
        }
        set
        {
            optical1 = value;
        }

    }
    public Optical_Fiber Optical2
    {
        get
        {
            return optical2;
        }
        set
        {
            optical2 = value;
        }
    }
    /// <summary>
    /// 熔接的方法
    /// </summary>
    public void Welding()
    {

    }
}
