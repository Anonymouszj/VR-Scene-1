using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void GameEvent();
public delegate void GameEvent<T>(T t);
public delegate void GameEvent<T1,T2>(T1 t1,T2 t2);
public delegate void GameEvent<T1, T2, T3>(T1 t1, T2 t2, T3 t3);
/// <summary>
/// 基础对象类，所有的对象都被相应的对象管理器约束
/// </summary>

public abstract class AEntity : MonoBehaviour {

    EntityManager entityManager;
    public event GameEvent a;

    public void DestroyEntity()
    {

        //Debug.Log("DestroyEntity "+ gameObject .name );
        transform.parent = null;
        entityManager.Destory(this);
    }
   

    public abstract void Init();
    public void SetManager(EntityManager manager)
    {
        entityManager = manager;
    }

    public EntityManager GetManager()
    {
        return entityManager;
    }
}
