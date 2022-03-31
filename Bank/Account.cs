﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    private double balance = 0;

    public void Credit(double amount)
    {
        balance += amount;
    }
    public void Debit(double amount)
    {
        if(balance > amount)
        {
            balance -= amount;
        }
    }
    public double Blance
    {
        get { return balance; }
    }
}