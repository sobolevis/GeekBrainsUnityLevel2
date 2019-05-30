public sealed class Gun : Weapon
{
	public override void Fire(Ammunition ammunition)
	{
		if (_fire && ammunition)
		{
			Bullet temp = null;
			if (ammunition)
				temp = Instantiate(ammunition, _gun_transform.position, _gun_transform.rotation) as Bullet;

			if(temp)
			{
				temp.name = "Bullet";
				temp.Rigidbody.AddForce(_gun_transform.forward * _force);
			}

			_fire = false;
			_rechargeTime.Start(_recharge);
		}
			
	}

}
