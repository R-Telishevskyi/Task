using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ListObject : MonoBehaviour
{
	public string description;
	public Sprite picture;
	public GameObject viewObject;

	public Image imageHolder;
	public Text textHolder;

	private Object3DController object3DController;

	void Start()
	{
		imageHolder.sprite = picture;
		textHolder.text = description;
		object3DController = GameObject.Find("Object3DPlace").GetComponent<Object3DController>();
	}

	public void InstantiateObject()
	{
		object3DController.RemoveObject();
		Instantiate( viewObject ).transform.SetParent( object3DController.transform );
		object3DController.SetObjectName( description );
	}
}
