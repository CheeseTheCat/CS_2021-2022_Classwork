using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_SidetoSide : MonoBehaviour
{
    public float movement_speed;
    private Vector3 start_pos;
    public Vector3 target_pos;

    private Vector3 current_target;

    void Start()
    {
        start_pos = transform.position;
        current_target = target_pos;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, current_target, movement_speed * Time.deltaTime);

        //Switch current target if it's reached the target
        if (transform.position == current_target)
        {
            if (current_target == start_pos)
            {
                current_target = target_pos;
            }
            else
            {
                current_target = start_pos;
            }
        }
    }
}