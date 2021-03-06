﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Villager : MonoBehaviour {

	static List<Villager> allVillagers = new List<Villager>();
	static System.Random randomNumber = new System.Random();

	public static Villager RandomVillager() {
		return allVillagers[randomNumber.Next(0, allVillagers.Count)];
	}

	public static IEnumerable<Villager> IdleVillagers(int count = 1) {
		return allVillagers.OrderBy((v) => randomNumber.Next()).Take(count);
	}

	private bool alive = true;

	public bool IsLiving() {
		return alive;
	}

	public void Kill() {
		alive = false;
		Destroy(this.gameObject);
	}

	// Use this for initialization
	void Start () {
		allVillagers.Add(this); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
