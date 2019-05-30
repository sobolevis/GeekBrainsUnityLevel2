using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main Instance { get; private set; }

	public GameObject Controllers { get; private set; }
	public InputController InputController { get; private set; }
	public FlashLightController FlashLightController { get; private set; }

	void Awake()
    {
		Instance = this;
		Controllers = new GameObject { name = "Controllers" };
		InputController = Controllers.AddComponent<InputController>();
		FlashLightController = Controllers.AddComponent<FlashLightController>();
    }

	public void DestroyObject(GameObject obj)
	{
		if (obj)
			Destroy(obj);
	}

}
