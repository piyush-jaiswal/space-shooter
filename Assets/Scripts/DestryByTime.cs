using UnityEngine;
using System.Collections;

public class DestryByTime : MonoBehaviour 
{
	public float lifetime;

	void Start()
	{
		Destroy(gameObject , lifetime);
	}
}
