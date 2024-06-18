﻿using CommunityToolkit.Mvvm.ComponentModel;
using Model.Enums;

namespace Model.Abstactions;

/// <summary>
/// Модель события
/// </summary>
public abstract partial class EventBase : ObservableValidator
{
    /// <summary>
    /// Уникальный идентификатор события
    /// </summary>
    [ObservableProperty]
    private long _id;

    /// <summary>
    /// Тип события
    /// </summary>
    [ObservableProperty]
    private EventType _type;

    /// <summary>
    /// Описания события
    /// </summary>
    [ObservableProperty]
    private string _description = string.Empty;

    [ObservableProperty]
    private DateTime _createdAt = DateTime.UtcNow;
}