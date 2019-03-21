using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CarFactory : IGameObjectFactory
{
	private Car car;

	public CarFactory()
	{
		this.car = new Car();
	}

	public CarFactory(Integer threads) {
		this.car = new Car(threads);
	}

	public AGameObject GetGameObject() {
		return this.car;
	}
}