using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Object3DController : MonoBehaviour
{
	public Text objectName;

	public void ChangeAnimationState()
	{
		if( transform.childCount != 0 )
		{
			bool state = transform.GetChild(0).GetComponent<Animator>().enabled;
			transform.GetChild(0).GetComponent<Animator>().enabled = !state;
		}
	}

	public void RemoveObject()
	{
		if( transform.childCount != 0 )
		{
			Destroy( transform.GetChild(0).gameObject );
			objectName.text = string.Empty;
		}
	}

	public void SetObjectName(string name)
	{
		objectName.text = name;
	}
}
