using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace TypingSpeed.Models
{
  public class Player
  {
    private string _name;
    private int _correctKeys;
    private int _missedKeys;
    private DateTime _startTimer;
    //DateTime.Now

    public Player()
    {

    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public DateTime GetStartTimer()
    {
      return _startTimer;
    }

    public void SetStartTimer()
    {
      _startTimer = DateTime.Now;
    }

    public string calculateTime()
    {
      // day difference Error

      // hour, minute, second
      DateTime endGameTime = DateTime.Now;
      Console.WriteLine(endGameTime.Hour);
      Console.WriteLine(endGameTime.Minute);
      Console.WriteLine(endGameTime.Second);
      Console.WriteLine(_startTimer.Second);
      Console.WriteLine("starttimer:"+_startTimer.Second);
      int hourDifference = endGameTime.Hour - _startTimer.Hour;
      Console.WriteLine("hourdifference:"+hourDifference);
      int minuteDifference = endGameTime.Minute - _startTimer.Minute;
      int secondDifference = endGameTime.Second - _startTimer.Second;
      string result = "Hours: " + hourDifference.ToString() + " Minutes: " + minuteDifference.ToString() + " Seconds: " + secondDifference.ToString();
      Console.WriteLine(result);
      return result;
    }
  }
}
