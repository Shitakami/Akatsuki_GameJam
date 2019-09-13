using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugController2 : MonoBehaviour
{


	[SerializeField]
	private Text m_text;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		m_text.text = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.Touch).ToString();

	}
}
