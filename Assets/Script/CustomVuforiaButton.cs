using System;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CustomVuforiaButton : MonoBehaviour
{
	public UnityEvent onPress;
	public UnityEvent onHold;
	public UnityEvent onRelease;

	bool isPressed;

	void Start()
	{
		var btn = GetComponentsInChildren<VirtualButtonBehaviour>();
		for(int i = 0; i< btn.Length; ++i){
			btn[i].RegisterOnButtonPressed(OnButtonPressed);
			btn[i].RegisterOnButtonReleased(OnButtonReleased);
		}
	}

	void Update()
	{
		if (isPressed)
			onHold.Invoke();
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
			onPress.Invoke();
		isPressed = true;
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
			onRelease.Invoke();
		isPressed = false;
	}
}
