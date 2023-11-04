using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using wpf_financial_accounting_system.Core.Enums;

namespace wpf_financial_accounting_system.MVVM.Model;

public class TransactionModel
{
    private string? _description;
    private int _id;
    private decimal _amount;
    private DateTime _dateTime;
    private TransactionType _type;
    private int _categoryId;
    private bool _isRecurring = false;

    public string? Description
    {
        get => _description;
        set => _description = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public decimal Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public DateTime Time
    {
        get => _dateTime;
        set => _dateTime = value;
    }

    public TransactionType Type
    {
        get => _type;
        set => _type = value;
    }

    public int CategoryId
    {
        get => _categoryId;
        set => _categoryId = value;
    }

    public bool IsRecurring
    {
        get => _isRecurring;
        set => _isRecurring = value;
    }
    
}