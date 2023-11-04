using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using wpf_financial_accounting_system.Core.Enums;

namespace wpf_financial_accounting_system.MVVM.Model;

public class TransactionModel
{
    public string? Description { get; set; } 
    public int Id { get; set; } 
    public decimal Amount { get; set; } 
    public DateTime Time { get; set; } 
    public TransactionType Type { get; set; } 
    public int CategoryId { get; set; } 
    public bool IsRecurring { get; set; } = false;
}