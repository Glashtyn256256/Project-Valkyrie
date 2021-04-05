using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class BossMotion : MonoBehaviour {

    public int speed = 20;
    public float xLimit = 20.0f;


    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        //Debug.Assert(_rb);
    }

	// Use this for initialization
	void Start () 
    {
       _rb.velocity = new Vector2(speed * Time.deltaTime, 0);
	}

	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x >= xLimit)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y );
            speed = -speed;
            _rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        }
        else if (transform.position.x <= -xLimit)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y);
            speed = -speed;
           _rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        }
	}
}
