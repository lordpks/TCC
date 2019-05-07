#pragma strict

function OnTriggerStay(other: Collider)
     {
        
           SceneManagement.SceneManager.LoadScene("MainMenu");
      	
     }