using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btns : MonoBehaviour {

    public Button nextBtn;
    public Button prevBtn;
    public Button playBtn; //0
    public Button optsBtn; //1
    public Button tutobtn; //2
    public Button aboutbtn; //3
    public Button creditbtn; //4
    public Button quitBtn; //5

    private int counter;

    // Use this for initialization
    void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

       // nextBtn = GameObject.FindGameObjectWithTag("nextBtn").GetComponent<Button>();
       // prevBtn = GameObject.FindGameObjectWithTag("prevBtn").GetComponent<Button>();
       // playBtn = GameObject.FindGameObjectWithTag("playBtn").GetComponent<Button>();
       // optsBtn = GameObject.FindGameObjectWithTag("optsBtn").GetComponent<Button>();
       // quitBtn = GameObject.FindGameObjectWithTag("quitBtn").GetComponent<Button>();

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            if(counter == 0)
            {

            }
            else
            {
               counter--;
            }
            
            prevBtn.onClick.Invoke();
        }
         
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            if(counter == 5)
            {

            }
            else
            {
                counter++;
            }
            
            nextBtn.onClick.Invoke();

            if (nextBtn.interactable == false)
            {

                

            }

        }

        if (Input.GetKeyDown(KeyCode.Return)){
            if (counter == 0)
            {
                SceneManager.LoadScene("Scene1");
            }

            if (counter == 1)
            {
                SceneManager.LoadScene("Opcoes");
            }

            if (counter == 2)
            {
                SceneManager.LoadScene("Tutorial");
            }

            if (counter == 3)
            {
                SceneManager.LoadScene("Sobre");
            }

            if (counter == 4)
            {
                SceneManager.LoadScene("Creditos");
            }

            if (counter == 5)
            {
               Application.Quit();
            }

            }
        }
    
}
