using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] public GameObject menu;

    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        stop = false;
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        stop = false;
        menu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")){
            if(stop == false){
                Time.timeScale = 0;
                stop = true;
                menu.SetActive(true);
            }else{
                Time.timeScale = 1;
                stop = false;
                menu.SetActive(false);
            }
        }
    }
}
