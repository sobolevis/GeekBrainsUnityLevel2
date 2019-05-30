using UnityEngine;

public abstract class Ammunition : SceneBaseObject
{
	[SerializeField] protected float _damage = 1f;
	[SerializeField] protected float _destructTime = 20f;
}
