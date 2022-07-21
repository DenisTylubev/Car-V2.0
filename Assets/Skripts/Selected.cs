using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    private int i;
    private int currentCharacter;
    public GameObject[] AllCgaracter;
    public GameObject ArrowTOLeft;
    public GameObject ArrowToRight;
    public GameObject ButtonSelect;
    public GameObject TextSelect;

    private void Start()
    {
        if(PlayerPrefs.HasKey("CurrentCharacter"))
        {

            i = PlayerPrefs.GetInt("CurrentCharacter");
            currentCharacter = PlayerPrefs.GetInt("CurrentCharacter");
          
        }
        else
        {


            PlayerPrefs.SetInt("CurrentCharacter",i);
        }
        AllCgaracter[i].SetActive(true);
        ButtonSelect.SetActive(false);
        TextSelect.SetActive(true);
        if (i > 0)
        {
            ArrowTOLeft.SetActive(true);
        }
        if(i== AllCgaracter.Length)
        {

            ArrowToRight.SetActive(false);
        }
        
    }
    public void ArrowRight()
    {

        if(i< AllCgaracter.Length)
        {
            if (i == 0)
            {

                ArrowTOLeft.SetActive(true);
            }
            AllCgaracter[i].SetActive(false);
            i++;
            AllCgaracter[i].SetActive(true);
            if(currentCharacter == i)
            {
                ButtonSelect.SetActive(false);
                TextSelect.SetActive(true);

            }
            else
            {
                ButtonSelect.SetActive(true);
                TextSelect.SetActive(false);
            }
            if( i + 1 == AllCgaracter.Length)
            {
                ArrowToRight.SetActive(false);

            }

        }
    }
    public void ArrowLeft()
    {

        if (i < AllCgaracter.Length)
        {
            AllCgaracter[i].SetActive(false);
            i--;
            AllCgaracter[i].SetActive(true);
            ArrowToRight.SetActive(true);
            if (currentCharacter == i)
            {
                ButtonSelect.SetActive(false);
                TextSelect.SetActive(true);

            }
            else
            {
                ButtonSelect.SetActive(true);
                TextSelect.SetActive(false);
            }
            if (i == 0)
            {

                ArrowTOLeft.SetActive(false);
            }
           
           
           
            
            

        }
    }
    public void SelectedCgaracter()
    {

        PlayerPrefs.SetInt("CurrentCharacter",i);
        currentCharacter = i;
        ButtonSelect.SetActive(false);
        TextSelect.SetActive(true);
    }
}
