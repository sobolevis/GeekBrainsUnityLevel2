using UnityEngine;

public abstract class SceneBaseObject : MonoBehaviour
{
	protected GameObject _gameObject;
	protected Transform _transform;
	protected string _name;
	protected bool _isVisible;
	protected int _layer;

	protected Vector3 _position;
	protected Vector3 _scale;
	protected Quaternion _rotation;

	protected Rigidbody _rigidbody;
	protected Collider _collider;

	protected Material _material;
	protected Color _color;

	protected virtual void Awake()
	{
		_gameObject = gameObject;
		_transform = _gameObject.transform;
		_name = _gameObject.name;

		if (_gameObject.GetComponent<Renderer>())
			_material = _gameObject.GetComponent<Renderer>().material;

		if (_gameObject.GetComponent<Rigidbody>())
			_rigidbody = _gameObject.GetComponent<Rigidbody>();

		if (_gameObject.GetComponent<Collider>())
			_collider = _gameObject.GetComponent<Collider>();
	}

	public GameObject GameObject
	{
		get { return _gameObject; }
	}

	public string Name
	{
		get { return _name; }
		set
		{
			_name = value;
			GameObject.name = _name;
		}
	}

	public bool IsVisible
	{
		get { return _isVisible; }
		set
		{
			_isVisible = value;
			if (GameObject.GetComponent<MeshRenderer>())
				GameObject.GetComponent<MeshRenderer>().enabled = _isVisible;
		}
	}

	public int Layer
	{
		get { return _layer; }
		set
		{
			if (_gameObject)
				_gameObject.layer = _layer;
		}
	}

	public Vector3 Position
	{
		get
		{
			if (GameObject)
				_position = _transform.position;
			return _position;
		}
		set
		{
			_position = value;
			if (GameObject)
				_transform.position = _position;
		}
	}

	public Vector3 Scale
	{
		get
		{
			if (GameObject)
				_scale = _transform.localScale;
			return _scale;
		}
		set
		{
			_scale = value;
			if (GameObject)
				_transform.localScale = _scale;
		}
	}

	public Quaternion Rotation
	{
		get
		{
			if (GameObject)
				_rotation = _transform.rotation;
			return _rotation;
		}
		set
		{
			_rotation = value;
			if (GameObject)
				_transform.rotation = _rotation;
		}
	}

	public Rigidbody Rigidbody
	{
		get { return _rigidbody; }
	}

	public Collider Collider
	{
		get { return _collider; }
	}

	public Material Material
	{
		get { return _material; }
	}

	public Color Color
	{
		get { return _color; }
		set
		{
			_color = value;
			if (Material)
				Material.color = _color;
		}
	}

	private void AskLayer(Transform obj, int layer)
	{
		obj.gameObject.layer = layer;
		if(obj.childCount > 0)
			foreach (Transform child in obj)
				AskLayer(child, layer);
	}

	private void AskColor(Transform obj, Color color)
	{
		if (obj.GetComponent<Renderer>())
			obj.GetComponent<Renderer>().material.color = color;

		if (obj.childCount > 0)
			foreach (Transform child in obj)
				AskColor(child, color);
	}

}
