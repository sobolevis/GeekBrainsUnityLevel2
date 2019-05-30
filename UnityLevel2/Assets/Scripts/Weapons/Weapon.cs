using UnityEngine;

public abstract class Weapon : SceneBaseObject
{
	[SerializeField] protected Transform _gun_transform;
	[SerializeField] protected float _force = 300f;
	[SerializeField] protected float _recharge = 1f;

	protected Timer _rechargeTime = new Timer();
	protected bool _fire = true;

	public abstract void Fire(Ammunition ammunition);

	protected virtual void Update()
	{
		_rechargeTime.Update();
		if (_rechargeTime.IsEvent())
			_fire = true;
		else
			_fire = false;
	}
}
