using System;

namespace ReadTrackRepeat.Data
{
  public class Challenge
  {
    public int Year { get; set; }
    public Challenge(int year)
    {
      Year = year;
    }
    public Challenge() : this (DateTime.Now.Year)
    {
    }
  }
}
