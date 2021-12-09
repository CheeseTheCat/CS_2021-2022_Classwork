using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{


    [SerializeField]
    private AudioClip[] audioClips;

    [Header("Components")]
    [SerializeField]
    private Rigidbody2D rig;
    [SerializeField]
    private AudioSource audioSrc;


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D> ();
        audioSrc = GetComponent<AudioSource>();
        audioSrc.PlayOneShot(audioClips[0]);
        Destroy(this.gameObject, 6f);
    }


    public void launch(Vector2 direction, float speed)
    {
        rig.AddForce(direction.normalized * speed, ForceMode2D.Impulse);

        float deg = Mathf.Rad2Deg * Mathf.Atan2(direction.y, direction.x) - 90f;
        transform.eulerAngles = Vector3.forward * deg;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("rocket"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;



            audioSrc.PlayOneShot(audioClips[1]);
            Destroy(this.gameObject, audioClips[1].length);
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
