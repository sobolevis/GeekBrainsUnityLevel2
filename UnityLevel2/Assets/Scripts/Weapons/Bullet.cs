using UnityEngine;

public class Bullet : Ammunition
{
	protected override void Awake()
	{
		base.Awake();
		Destroy(gameObject, _destructTime);
	}

	private void OnCollisionEnter(Collision collision)
	{
		var temp = collision.gameObject.GetComponent<Enemy>();
		if (temp)
			SetDamage(temp);
		else
			return;
		Destroy(GameObject);
	}

	private void SetDamage(ISetDamage obj)
	{
		if (obj != null)
			obj.GetDamage(_damage);
	}
}
