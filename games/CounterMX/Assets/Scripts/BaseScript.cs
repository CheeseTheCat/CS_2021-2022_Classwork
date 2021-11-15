using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    [SerializeField]
    private float curHP;

    [SerializeField]
    private float maxHP;

    private void Awake()
    {
        curHP = maxHP;
    }
    private void Start()
    {
        
    }
    public void takeDamage(int ammount)
    {
        curHP -= ammount;
        if (curHP <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Debug.Log("this base has died");
        Destroy(this);
    }
}
