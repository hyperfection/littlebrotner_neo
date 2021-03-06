﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3 : MonoBehaviour {

	[SerializeField]
	Color normalColor;

	[SerializeField]
	Color alertColor;

	SpriteRenderer _background;
	SpriteRenderer _backgroundLight;

	// Use this for initialization
	void Awake () {
		_background = transform.Find("Background").GetComponent<SpriteRenderer>();
		_backgroundLight = _background.transform.Find("Light").GetComponent<SpriteRenderer>();

		_background.color = normalColor;
		_backgroundLight.color = normalColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
