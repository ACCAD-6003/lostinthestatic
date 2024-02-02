﻿using UnityEngine;

public interface IRadioChannel
{
    public void SeekTo();
    public void SeekAwayFrom();
    public void Update(Transform transform);
}