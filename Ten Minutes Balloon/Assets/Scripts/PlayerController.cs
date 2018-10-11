using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Camera _mainCamera;

	public void OnMouseDrag()
	{
		var mousePosition = Input.mousePosition;
		var worldPoint = _mainCamera.ScreenToWorldPoint (new Vector3(mousePosition.x, mousePosition.y, 10f));
		transform.position = new Vector3 (worldPoint.x, worldPoint.y, transform.position.z);
	}
	// Use this for initialization
	private void Awake()
	{
		_mainCamera = Camera.main; //Cache the camera, micro optimization.
	}
}
