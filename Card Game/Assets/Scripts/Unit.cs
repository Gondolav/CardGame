using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This class represents a generic unit card.
/// </summary>
abstract public class Unit : Card, IType
{
	private const int DefaultShield = 0;

	private int attack;
	public int Attack { get; set; }

	private int life;
	public int Life { get; set; }

	private int shield;
	public int Shield { get; set; }

	private bool[] moves;
	public bool[] Moves { get; set; }

	private bool inEnemyLand;
	public bool InEnemyLand { get; set; }

	private readonly int timeToProduce;
	public int TimeToProduce
	{
		get
		{
			return timeToProduce;
		}
	}

	private readonly int score;
	public int Score
	{
		get
		{
			return score;
		}
	}

	// we can use Extensions to give enums methods, if required
	private enum UnitType
	{
		Ground,
		Space
	}

	protected Unit(int attack, int life, int timeToProduce, int score)
	{
		Utility.Require(attack >= 0, "Attack < 0");
		Utility.Require(life >= 1, "Life <= 0");

		this.Attack = attack;
		this.Life = life;
		this.Shield = DefaultShield;
		this.Moves = new bool[2];
		this.timeToProduce = timeToProduce;
		this.score = score;
	}
}
