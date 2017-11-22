﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatTextManager : MonoBehaviour {

    private static CombatTextManager instance;

    public GameObject textPrefab;

    public GameObject bigTextPrefab;

    public RectTransform canvasTransform;

    public float speed;
    public float fadeTime;
    public Vector3 direction;

    public static CombatTextManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<CombatTextManager>();

            }
            return instance;
        }
    }

    public void CreateText(Vector3 position, string text, Color color, bool crit, float fadeTimeArg, bool useFadeTimeArg)
    {
        GameObject sct = (GameObject)Instantiate(textPrefab, position, Quaternion.identity);
        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        sct.GetComponent<CombatText>().Initialize(speed, direction, fadeTime, crit);
        sct.GetComponent<Text>().text = text;
        sct.GetComponent<Text>().color = color;
    }

    public void CreateBigText(Vector3 position, string text, Color color, bool crit, float fadeTimeArg, bool useFadeTimeArg)
    {
        GameObject sct = (GameObject)Instantiate(bigTextPrefab, position, Quaternion.identity);
        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        if (useFadeTimeArg)
        {
            sct.GetComponent<CombatText>().Initialize(speed, new Vector3(0, 0, 0), fadeTimeArg, crit);
        }
        else
        {
            sct.GetComponent<CombatText>().Initialize(speed, new Vector3(0, 0, 0), 2f, crit);
        }
        sct.GetComponent<Text>().text = text;
        sct.GetComponent<Text>().color = color;
    }

    public void CreateAnnounceText(Vector3 position, string text, Color color, bool crit, float fadeTimeArg, bool useFadeTimeArg)
    {
        GameObject sct = (GameObject)Instantiate(bigTextPrefab, position, Quaternion.identity);
        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        if (useFadeTimeArg)
        {
            sct.GetComponent<CombatText>().Initialize(speed, new Vector3(0, 0, 0), fadeTimeArg, crit);
        }
        else
        {
            sct.GetComponent<CombatText>().Initialize(speed, new Vector3(0, 0, 0), 5f, crit);
        }
        sct.GetComponent<Text>().text = text;
        sct.GetComponent<Text>().color = color;
    }
}
