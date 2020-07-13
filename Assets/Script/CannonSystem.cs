using UnityEngine;
using UnityEngine.Events;

public class CannonSystem : MonoBehaviour 
{
	public float maxProjForce = 18000f;
	public float cooldown = 1f;
	public GameObject projPrefab;

	public Transform projSpawn;
	bool shoot = true;

	void Awake()
	{
		projSpawn = GameObject.FindGameObjectWithTag("spawn").transform;
	}

	public void FireProjectile()
	{
		if (!shoot)
			return;
		GameObject bullet = (GameObject)Instantiate(projPrefab, projSpawn.position, projSpawn.rotation);
		Vector3 force = projSpawn.transform.forward * maxProjForce;
		bullet.GetComponent<Rigidbody>().AddForce(force) ;
		Debug.Log(force);
		shoot = false;
		Invoke("CoolDown", cooldown);
	}

	void CoolDown()
	{
		shoot = true;
	}
}