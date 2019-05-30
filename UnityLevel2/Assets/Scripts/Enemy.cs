using UnityEngine;

public abstract class Enemy : SceneBaseObject, ISetDamage 
{
	[SerializeField] float _health = 10f;

	protected bool _isDead = false;
	protected float _speed = 2f;
	protected float _deadSpeed = 5f;

	private void Update()
	{
		if(_isDead)
		{
			var color = Material.color;
			if (color.a > 0)
			{
				color.a -= _deadSpeed / 100;
				Color = color;
			}
			if (color.a < 1)
			{
				Destroy(Collider);
				Destroy(GameObject, 5f);
			}
				
		}
	}

	public virtual void GetDamage(float damage)
	{
		_health -= damage;
		if (_health < 0)
			_isDead = true;
	}
}
