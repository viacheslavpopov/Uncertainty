﻿using System;

public class NonRepeatableTimer : CustomTimer //TODO: fix all
{
    public event Action OnTimerEnded;
    public NonRepeatableTimer(float duration) : base(duration) {}
    
    public override void Tick(float deltaTime)
    {
        _remainingTime -= deltaTime;
        if (_remainingTime<=0)
        {
            OnTimerEnded?.Invoke();
        }
    }
}
