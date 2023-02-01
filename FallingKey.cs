
using Godot;
using System;

public class FallingKey : Key
{
    [Export]
    public float fallRate = 10;
    private Vector2 fallRateVec;
    public Lane lane;

    public override void _Ready()
    {
        base._Ready();
        fallRateVec = new Vector2(0, fallRate);
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
        Position += fallRateVec;
    }
}