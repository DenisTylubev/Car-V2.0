using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sele : MonoBehaviour
{

    private GameObject[]  charac;
    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("SelectPlayer");
        charac = new GameObject[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {

            charac[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in charac)
        {
            go.SetActive(false);

        }
        if(charac[index])
        {

            charac[index].SetActive(true);
        }

    }
    public void SelectLeft()
    {

        charac[index].SetActive(false);
        index--;
        if(index < 0)
        {
            index = charac.Length - 1;
        }
        charac[index].SetActive(true); 
    }
    public void SelectRight()
    {

        charac[index].SetActive(false);
        index++;
        if (index== charac.Length)
        {
            index =0;
        }
        charac[index].SetActive(true);
    }

    public void StarScene()
    {

        PlayerPrefs.SetInt("SelectPlayer", index);
        SceneManager.LoadScene("SampleScene");

    }

}
