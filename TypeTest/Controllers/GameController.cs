using Microsoft.AspNetCore.Mvc;
using TypingSpeed.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace TypingSpeed.Controllers
{
  public class PlayerController : Controller
  {


    [HttpGet("/game")]
    public ActionResult Index()
    {
      Player newPlayer = new Player();
      newPlayer.SetStartTimer();

      //List<Player> allCounters = Player.GetAll();
      return View(newPlayer);
    }

    [HttpPost("/game")]
    public ActionResult Finish(Player playerObject)
    {
      string result = playerObject.calculateTime();
      // lists stats of your attempt
      //pass in temporary Player
      // would you like to save your high score?
      // if yes, enter name, submit
      return View("Show", result);
    }
    [HttpGet("/game/results")]
    public ActionResult show(DateTime playerObject)
    {

      return View();
    }



  }
}
