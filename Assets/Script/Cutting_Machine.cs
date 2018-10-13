using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 光纤切割机
/// </summary>
public class Cutting_Machine : AEntity
{
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    private Optical_Fiber optical;//光纤
    public Optical_Fiber Optical//属性
    {
        get
        {
            return optical;
        }
        set
        {
            optical = value;
        }
    }
    /// <summary>
    /// 切割光纤方法
    /// </summary>
    public void cut()
    {

    }

}
