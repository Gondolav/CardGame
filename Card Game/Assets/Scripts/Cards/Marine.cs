using System;

public class Marine : Unit
{
	private const int AttackValue = 1;
	private const int LifeValue = 1;
	private const int TimeToProduceValue = 1;

	private Marine(int attack, int life, int timeToProduce) : base(attack, life, timeToProduce) {}


	public static Unit MakeUnit()
	{
		return new Marine(AttackValue, LifeValue, TimeToProduceValue);
	}
}
