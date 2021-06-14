using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMenuScript : MonoBehaviour
{
	public float TempoLimite; 
	public float currentTime; 

	public void Continue () {

		currentTime += Time.deltaTime;
		
		if (currentTime >= TempoLimite) 
		{
			currentTime = 0;
			
			SceneManager.LoadScene("0");
			
		}
		



	}
}
