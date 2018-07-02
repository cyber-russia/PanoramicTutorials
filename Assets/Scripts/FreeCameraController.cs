using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SupremumStudio
{
	/// <summary>
	/// Компонент позволяющий вращать камеру вокруг своей оси
	/// </summary>
	public class FreeCameraController : MonoBehaviour
	{
		[Range(1,10)]
		[Header("Чувствительность мышки")]
		public float sensitivity = 1f;
		[Range(0,80)]
		[Header("Максимальный угол отклонения по оси Y")]		
		public float maxYAngle = 80f;
		
		private Vector2 currentRotation;

		void Update()
		{
			currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
			currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;

			currentRotation.x = Mathf.Repeat(currentRotation.x, 360);  /// ...358-359-0-1-2...
			currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle); // [-80,80]
			
			Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);	
		}

	}
}

