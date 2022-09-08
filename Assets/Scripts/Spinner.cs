using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour 
{
    public float spin = 0;

	// Before rendering each frame..
	void Update () 
	{
		transform.Rotate (new Vector3 (0, spin, 0 ) * Time.deltaTime);
	}
}	
