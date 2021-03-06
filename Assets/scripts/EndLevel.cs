﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            generate generate_ = GameObject.Find("Player").GetComponent<generate>();
            generate_.level_up();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}