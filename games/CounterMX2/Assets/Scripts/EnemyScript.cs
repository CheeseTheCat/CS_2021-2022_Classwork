using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody2D rig;
    int damage;
    private AudioSource audiosrc;

    [Header("AudioComponets")]
    [SerializeField]
    private AudioClip exp;


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        audiosrc = GetComponent<AudioSource>();
        damage = Random.Range(10, 25);
        Destroy(gameObject, 10f);
    }

    public void assigneTarget(BaseScript target,float speed)
    {
        rig.AddForce((target.transform.position - transform.position).normalized * speed, ForceMode2D.Impulse);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bunker"))
        {

            collision.gameObject.GetComponent<BaseScript>().takeDamage(this.damage);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;


            audiosrc.Play();
            Destroy(gameObject, audiosrc.clip.length);

        }

        else if (!collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deg = Mathf.Rad2Deg * Mathf.Atan2(rig.velocity.y, rig.velocity.x) - 90f;
        transform.eulerAngles = Vector3.forward * deg;
    }
}
