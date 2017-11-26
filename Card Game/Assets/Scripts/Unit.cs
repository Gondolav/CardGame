using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This class represents a generic unit card.
/// </summary>
abstract public class Unit : Card, IType {
    private const int DefaultShield = 0;

	private int attack;
    public int Attack {get; set;}

	private int life;
    public int Life {get; set;}

	private int shield;
    public int Shield {get; set;}

	private bool[] moves;
    public bool[] Moves {get; set;}

	private bool inEnemyLand;
	public bool InEnemyLand {get; set;}

    private readonly int timeToProduce;
    public int TimeToProduce {
        get {
            return timeToProduce;
        }
    }

    // we can use Extensions to give enums methods, if required
    private enum UnitType {
        Ground,
        Space
    }

	private Unit(int attack, int life, bool[] moves, int timeToProduce) {
        Utility.Require(attack >= 0, "Attack < 0");
        Utility.Require(life >= 1, "Life <= 0");

        this.Attack = attack;
        this.Life = life;
		this.Shield = DefaultShield;
        this.Moves = moves;
        this.timeToProduce = timeToProduce;
    }
}
