﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_VendingMachine
{
  public class Dessert : Product
  {
    public static int DessertsProductCount { get; private set; }

    public Dessert(string name) : base(name)
    {
      DessertsProductCount += 1;
    }

    public override void UseProduct()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine($"Enjoy eating {this.Name} but, one per day is more than enought!");
    }
  }
}
