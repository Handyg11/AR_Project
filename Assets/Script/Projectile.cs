using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
	public float lifeTime = 2.0f;
	public float projDuration = 3f;
	public LayerMask targetLayerMask;

    public GameObject body;

	Rigidbody rigidBody;
	Collider sphereCollider;
    bool exploded;

    void Awake()
    {
		sphereCollider = GetComponent<Collider> ();
		rigidBody = GetComponent<Rigidbody>();
    }

	void Update()
	{
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0f)
		{
			Explode();
		}
	}

    void OnCollisionEnter( Collision collision )
    {
		Explode();

		Target target = collision.gameObject.GetComponent<Target>();

		if ( target != null )
			target.Hit();
    }

    void Explode()
    {
        if (exploded) 
			return;

		exploded = true;

		body.SetActive( false );
        rigidBody.isKinematic = true;
		sphereCollider.enabled = false;

		Collider[] colliders = Physics.OverlapSphere(transform.position, projDuration, targetLayerMask);

		for (int i = 0; i < colliders.Length; i++)
		{
			Rigidbody rb = colliders[i].GetComponent<Rigidbody>();
		}

		Destroy(gameObject);
	}
}
