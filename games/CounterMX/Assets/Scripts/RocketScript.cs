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
        Destroy(this.gameObject, 3.5f);
    }


    public void launch(Vector2 direction, float speed)
    {
        rig.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSrc.PlayOneShot(audioClips[1]);
        Destroy(this.gameObject, audioClips[1].length);
    }
    // Start is called before the first frame update
    void Start()
    {
        launch( new Vector2(0, 0), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 5f);
    }
}
