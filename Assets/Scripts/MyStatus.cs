﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStatus : MonoBehaviour {

	// singleton
	static MyStatus _instance = null;

	private void Awake()
	{
		if (_instance != null)
		{
			return;
		}

		DontDestroyOnLoad(gameObject);
	}

	public static MyStatus instance
	{
		get {
			if (_instance == null)
				_instance = GameObject.FindObjectOfType<MyStatus>();

			Debug.Assert(_instance != null);
			return _instance;
		}
	}

	public class DataUpdateNotifier<T>
	{
		public delegate void DataUpdatedEvent(T value);
		public event DataUpdatedEvent OnUpdate = delegate{};
public static implicit operator T(DataUpdateNotifier<T> value)
		{
			return value.value;
		}

		public DataUpdateNotifier(T initial = default(T))
		{
			_value = initial;
		}

		T _value;

		public T value {
			get { return _value; }
			set { _value = value; OnUpdate(value); }
		}
	}


	/* [-100, 100] 범위를 갖는 성향 */
	public DataUpdateNotifier<int> political = new DataUpdateNotifier<int>(); // [사회주의 - 민주주의]
	public DataUpdateNotifier<int> economy = new DataUpdateNotifier<int>();   // [공산주의 - 자본주의]
	public DataUpdateNotifier<int> mechanic = new DataUpdateNotifier<int>();  // [신토불이 - 산업발전]
	public DataUpdateNotifier<int> health = new DataUpdateNotifier<int>(10);
	public DataUpdateNotifier<int> money = new DataUpdateNotifier<int>(); // 돈!
	public DataUpdateNotifier<int> endingIndex = new DataUpdateNotifier<int>(); // 엔딩!
	public DataUpdateNotifier<bool> isRobotAppear = new DataUpdateNotifier<bool>(); // 로봇 종족이 나타났는가
}
