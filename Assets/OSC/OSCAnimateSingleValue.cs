using System;
using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.Rendering;

/*
 * unity script to animate a single value - works both for single-value properties (e.g., light intensity),
 * and for changing one value in a multi-valued property (currently, works for Vector3 and Color)
 */

public class OSCAnimateSingleValue : OSCAnimation {

	public string Component;
	public string Property;
	private float multiplierValue;

	void Start () {

		componentName = Component;
		propertyName = Property;
		
		
		Init ();

	}

	// Update is called once per frame
	void Update () {

		if (newMessage) {

			try
			{
				if (!isMultiValue) { // we directly set the value if the property is single-value
					if (property == null) {
						field.SetValue( comp, localMsg.Values[0]);
						
					} 
					}
				
				
				
				
			}
			catch (System.Exception e)
			{
				Debug.Log ("Wrong propertyname, or missing component, or type mismatch between message value and property value");
			}

			newMessage = false;

		}

	}




}
