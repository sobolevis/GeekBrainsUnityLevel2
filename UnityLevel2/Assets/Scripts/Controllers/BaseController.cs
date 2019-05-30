public abstract class BaseController : SceneBaseObject
{
	public bool Enabled { get; set; } = false;

	public virtual void Update() { }
	public virtual void On() { }
	public virtual void Off() { }
}
