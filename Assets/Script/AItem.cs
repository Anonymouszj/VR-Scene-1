using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 可拾取道具的抽象类
/// </summary>
public abstract class AItem : AEntity {

    /// <summary>
    /// 判断有效
    /// </summary>
    protected abstract bool Available { get; }

    private void OnTriggerEnter(Collider other)
    {
        AEntity aEntity = other.GetComponentInParent<AEntity>();
        if (aEntity)
        {
            TakeItem(aEntity);
        }
    }

    /// <summary>
    /// 拾取道具的接口方法
    /// </summary>
    /// <param name="aEntity"></param>
    internal void TakeItem(AEntity aEntity)
    {
        if(Available)
        {
            ItemEffect(aEntity);
        }
    }

    /// <summary>
    /// 实际的道具效果
    /// </summary>
    /// <param name="aEntity"></param>
    protected abstract void ItemEffect(AEntity aEntity);

}
