using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagStuff : MonoBehaviour
{
    private bool taggable;
    public bool is_it;
    public float last_tagged;


    private void OnTriggerEnter2D(Collider2D collision)
    {   

        if(collision.CompareTag("TagThingTag") && taggable && is_it)
        {
            collision.GetComponent<TagStuff>().is_it = true;
            collision.GetComponent<TagStuff>().last_tagged = Time.time;
            collision.GetComponent<TagStuff>().taggable = false;
            is_it = false;
            last_tagged = collision.GetComponent<TagStuff>().last_tagged;
            taggable = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        taggable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= (last_tagged + 2.0f) && !taggable)
        {
            taggable = true;
        }


        GetComponent<SpriteRenderer>().forceRenderingOff = !is_it;
    }
}
