﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generate : MonoBehaviour {

	public Vector2 vectorX = new Vector2(7, 9);
    public Vector2 scale_size = new Vector2(0, 8);
    public Vector2 vectorY = new Vector2(-3, -7);
    public static int count = 3;
    public GameObject Sprite_Prefub;
    public GameObject[] New_sprires;
    [SerializeField] public GameObject end;
    [SerializeField] private Text level;

    private void Start()
    {
        level.text = ("LEVEL: " + (count - 2));
        New_sprires = new GameObject[count];
        Generate();
    }

    void Generate ()
    {
        float x, y, x_prev = 5;
        for (int i = 0; i < count; i++)
        {
            x = Random.Range(vectorX.x, vectorX.y) + x_prev;
            y = Random.Range(vectorY.x, vectorY.y);
            Vector3 pos = new Vector3 (x, y, 0);
            New_sprires[i] = Instantiate(Sprite_Prefub, pos, transform.rotation);
            Vector3 Sprite_scale = New_sprires[i].transform.localScale;
            Sprite_scale.x += (Random.Range(scale_size.x, scale_size.y) * (float)0.1);
            New_sprires[i].transform.localScale = Sprite_scale; 
            x_prev = x + (New_sprires[i].GetComponent<Renderer>().bounds.size.x);
            if (i == count - 1)
            {
                Vector3 new_position_end = New_sprires[i].transform.position;
                new_position_end.y += 5;
                end.transform.position = new_position_end;
            }
        }
    }

    public void  level_up()
    {
        count++;
    }

    public void level_restart()
    {
        count = 3;
    }
}
