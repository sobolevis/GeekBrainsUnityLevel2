using UnityEngine;

public class FlashLightController : BaseController
{
	[SerializeField] private KeyCode _control = KeyCode.F;
	[SerializeField] private float _timeout = 120;
	[SerializeField] private Light _light;

	[SerializeField] private Color _maxColor = Color.white;
	[SerializeField] private Color _midColor = Color.yellow;
	[SerializeField] private Color _minColor = Color.red;

	private float _curTime;
	private float _curReloadTime;

	public override void Update()
	{
		base.Update();

		if (Input.GetKeyDown(_control) && !_light.enabled)
			ActiveFlashlight(true);
		else if (Input.GetKeyDown(_control) && _light.enabled)
			ActiveFlashlight(false);

		if (_light.enabled)
		{
			_curTime += Time.deltaTime;
			if (_curTime > _timeout)
			{
				_curTime = 0;
				ActiveFlashlight(false);
			}
			else if (_curTime != 0)
			{
				// ???
			}
		}
	}

	private void ActiveFlashlight(bool value)
	{
		_light.enabled = value;
	}

}
