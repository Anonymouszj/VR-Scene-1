using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 对象管理器接口
/// </summary>
public interface IObjectManager<T>
{
    /// <summary>
    /// 初始化管理器
    /// </summary>
    void Init();
    T Creat();
    void DestoryObject(T obj);
}

/// <summary>
/// 对象管理器抽象类
/// </summary>
public abstract class AObjectManager<T> : IObjectManager<T>
{
    /// <summary>
    /// 激活实体列表
    /// </summary>
    internal List<T> inUse = new List<T>();
    /// <summary>
    /// 废弃实体列表
    /// </summary>
    internal List<T> unUse = new List<T>();

    /// <summary>
    /// 当回收对象时的额外处理
    /// </summary>
    protected abstract void OnDestoryObject(T obj);

    /// <summary>
    /// 当创建对象时的额外处理
    /// </summary>
    protected abstract void OnCreatObject(T obj);

    /// <summary>
    /// 调配一个可用的对象
    /// </summary>
    /// <returns>可用的对象</returns>
    public T Creat()
    {
        T result;
        
        if (unUse.Count > 0)
        {
            result = unUse[0];
            unUse.RemoveAt(0);
        }
        else
        {
            result = CreatNew();
        }
        inUse.Add(result);
        OnCreatObject(result);
        return result;
    }

    /// <summary>
    /// 创建一个新对象
    /// </summary>
    /// <returns>新的对象</returns>
    protected abstract T CreatNew();

    /// <summary>
    /// 初始化管理器
    /// </summary>
    public void Init()
    {
        while (inUse.Count > 0)
        {
            DestoryObject(inUse[0]);
        }
    }

    public void DestoryObject(T obj)
    {

        if (inUse.Contains(obj))
        {
            inUse.Remove(obj);
            // Debug.Log("Remove" + obj);
        }
        OnDestoryObject(obj);
        if (!unUse.Contains(obj))
        {
            unUse.Add(obj);
        }        
    }


}
