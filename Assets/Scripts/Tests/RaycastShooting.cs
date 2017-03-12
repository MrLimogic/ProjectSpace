using UnityEngine;
using System.Collections;

public class RaycastShooting : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")){

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));

            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) {

                Debug.Log("OBJ: " + hit.transform.name);
                Destroy(hit.transform.gameObject);
            }
        }
	
	}
}
