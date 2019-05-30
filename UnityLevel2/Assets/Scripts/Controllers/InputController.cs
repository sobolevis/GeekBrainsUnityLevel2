using UnityEngine;

public sealed class InputController : BaseController
{
	private bool _isActiveFlashlight = false;

	public override void Update()
	{
		base.Update();
		if (Input.GetKeyDown(KeyCode.F))
		{
			_isActiveFlashlight = !_isActiveFlashlight;
			if (_isActiveFlashlight)
			{
				// Вызов функции On() класса FlashlightController
			}
			else
			{
				// Вызов функции Off() класса FlashlightController
			}
		}
	}
}
