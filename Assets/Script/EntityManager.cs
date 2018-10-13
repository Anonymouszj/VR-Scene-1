using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityManager<T>
{
    T Creat();
    T Creat(Transform parent);
    T Creat(Transform parent, Vector3 position, Vector3 angles);
    void Destory(T entity);
}
public class EntityManager : AObjectManager<AEntity>, IEntityManager<AEntity>
{
    static int indexManager = 0;

    internal int id = 0;
    int index = 0;
    protected AEntity template;

    public EntityManager(AEntity template)
    {
        id = indexManager++;
        this.template = template;
    }



    /// <summary>
    /// 实现创建对象
    /// </summary>
    /// <returns></returns>
    protected override AEntity CreatNew()
    {
        AEntity t = GameObject.Instantiate(template.gameObject).GetComponent<AEntity>();
        t.gameObject.name = id.ToString();
        t.SetManager(this);
        index++;
        return t;
    }

    /// <summary>
    /// 实现当创建对象时对对象的操作
    /// </summary>
    /// <param name="obj"></param>
    protected override void OnCreatObject(AEntity obj)
    {
        
        obj.gameObject.SetActive(true);
    }

    /// <summary>
    /// 实现当摧毁对象时对对象的操作
    /// </summary>
    /// <param name="obj"></param>
    protected override void OnDestoryObject(AEntity obj)
    {
        obj.gameObject.SetActive(false);
    }

    /// <summary>
    /// 创建实体副本
    /// </summary>
    /// <param name="entity">实体模板</param>
    /// <param name="parent">父节点</param>
    /// <returns>实体的克隆副本</returns>
    public AEntity Creat(Transform parent)
    {
        AEntity result = Creat();
        result.Init();
       
        result.transform.parent = parent;
        Debug.Log("122");
        return result;
    }

    /// <summary>
    /// 创建实体副本
    /// </summary>
    /// <param name="entity">实体模板</param>
    /// <param name="parent">父节点</param>
    /// <pare="poam namsition">世界位置</param>
    /// <param name="angles">角度</param>
    /// <returns>实体的克隆副本</returns>
    public AEntity Creat(Transform parent, Vector3 position, Vector3 angles)
    {
        AEntity result = Creat(parent);
        result.transform.position = position;
        result.transform.eulerAngles = angles;
        return result;
    }
    public void Destory(AEntity entity)
    {
        DestoryObject(entity);
    }

    public void DestoryAll()
    {
        while (inUse.Count > 0)
        {
            inUse[0].DestroyEntity();
        }

    }
}

