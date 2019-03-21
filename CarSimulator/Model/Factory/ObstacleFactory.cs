using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ObstacleFactory : IGameObjectFactory
{
	private Obstacle obstacle;

	public ObstacleFactory()
	{
		this.obstacle = new Obstacle();
	}

	public AGameObject GetGameObject() {
        return this.obstacle;
	}
}