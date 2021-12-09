using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBaseScript : BaseScript
{

    [SerializeField]
    private RocketScript rocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }
    }

    private void fire()
    {
        RocketScript rocketInstance = Instantiate(rocket);
        rocketInstance.transform.position = transform.position;

        rocketInstance.launch(Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position, 7f);
    }
}
