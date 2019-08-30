using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public GameObject[] Cars;
    public Color[] Colors;
    public GameObject[] Textures;
    public Camera MainCamera;
    public Text text_info;
    public Text text_title;
    public bool showInfo;
    public int Object;

    void Start()
    {
        showInfo = true;
        DeleteAll();
    }

    public void SelectObject(int ind)
    {
        DeleteAll();
        Object = ind;
        Cars[ind].SetActive(true);
        Info(ind);
    }

    void DeleteAll()
    {
        for (int i = 0; i < Cars.Length; i++)
        {
            Cars[i].SetActive(false);
        }
    }
    
    void Update()
    {

    }

    public void ShowInfo()
    {
        if (showInfo == true)
        {
            showInfo = false;
        }
        else
        {
            showInfo = true;
        }
        Info(Object);
    }

    public void Info(int ind)
    {
        if (showInfo == true)
        {
            switch (ind)
            {
                case 0:
                    text_title.alignment = TextAnchor.LowerCenter;
                    text_info.alignment = TextAnchor.LowerCenter;
                    text_title.text = "Taxi";
                    text_info.text = "Brand - VolksWagen;\nMax speed - 190km/h;\nPower - 200hp;\nCountry - Germany;\nPrice - 100,000$";
                    break;
                case 1:
                    text_title.alignment = TextAnchor.LowerCenter;
                    text_info.alignment = TextAnchor.LowerCenter;
                    text_title.text = "Bus";
                    text_info.text = "Brand - Mersedes;\nMax speed - 150km/h;\nPower - 600hp;\nCountry - Germany;\nPrice - 170,000$";
                    break;
                case 2:
                    text_title.alignment = TextAnchor.LowerCenter;
                    text_info.alignment = TextAnchor.LowerCenter;
                    text_title.text = "Car";
                    text_info.text = "Brand - Toyota;\nMax speed - 240km/h;\nPower - 160hp;\nCountry - Japan;\nPrice - 40,000$";
                    break;
                case 3:
                    text_title.alignment = TextAnchor.LowerCenter;
                    text_info.alignment = TextAnchor.LowerCenter;
                    text_title.text = "Police";
                    text_info.text = "Brand - Ford;\nMax speed - 240km/h;\nPower - 250hp;\nCountry - United States;\nPrice - 70,000$";
                    break;
            }
        }
        else
        {
            text_title.alignment = TextAnchor.LowerCenter;
            text_info.alignment = TextAnchor.LowerCenter;
            text_title.text = " ";
            text_info.text = " ";
        }
    }

    public void NextCar()
    {
        if (Object == 3)
        {
            Object = 0;
        }
        else
        {
            Object = Object + 1;
        }
        SelectObject(Object);
    }

    public void moreView()
    {
        MainCamera.fieldOfView = 60;
    }

    public void lessView()
    {
        MainCamera.fieldOfView = 50;
    }

    public void setRed()
    {
        Textures[Object].GetComponent<Renderer>().material.color = Colors[0];
    }

    public void setBlue()
    {
        Textures[Object].GetComponent<Renderer>().material.color = Colors[1];
    }

    public void setYellow()
    {
        Textures[Object].GetComponent<Renderer>().material.color = Colors[2];
    }

    public void setBlack()
    {
        Textures[Object].GetComponent<Renderer>().material.color = Colors[3];
    }
}
