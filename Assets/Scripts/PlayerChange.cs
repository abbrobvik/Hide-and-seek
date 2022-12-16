using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{

	[SerializeField] private float InteractMaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, InteractMaxDistance)) {
				GameObject obj = hit.collider.gameObject;
				if (obj.tag == "playable") {
					Debug.Log("Found playable object");
					Destroy(GetComponent<MeshFilter>().mesh);
					GetComponent<MeshFilter>().mesh = obj.GetComponent<MeshFilter>().mesh;
					transform.localScale = obj.transform.localScale;
				} else {

				}
			} else {
				Debug.Log("Out of distance");
			}
		}
    }
}
