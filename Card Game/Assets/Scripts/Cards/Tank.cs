using System;

public class Tank : Unit
{
	private const int AttackValue = 2;
	private const int LifeValue = 2;
	private const int TimeToProduceValue = 2;
	private const int ScoreValue = 2;

	private Tank(int attack, int life, int timeToProduce, int score) : base(attack, life, timeToProduce, score) { }


	public static Unit MakeUnit()
	{
		return new Tank(AttackValue, LifeValue, TimeToProduceValue, ScoreValue);
	}
}

