using UnityEngine;
using System.Collections;

public class spawncubes : MonoBehaviour {

    public Transform prefab;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < 2; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 1, 2), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
