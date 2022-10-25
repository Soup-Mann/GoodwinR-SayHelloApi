using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_SayHelloApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AllApiDescripController : ControllerBase
{
    [HttpGet]
    [Route("Hi")]
    public string saywsp(){
        return "Hi!\nThis is a fucntion that Asks your name and then greets you !";
}

[HttpGet]
[Route("AddTwoNum")]
public string TwoNum(){
    return "Hi!\nthis program takes 2 numbers and adds them!";
}

[HttpGet]
[Route("WakeUp")]
public string awaken(){
    return "Hi!\nThis program will ask you for you name and the time you woke up \n then it will repeat it back to you with a greeting!";
}

[HttpGet]
[Route("Greater")]
public string biggest(){
    return "Hi!\nThis program will take 2 numbers and tell you if they are greater than, \n Less than \n or equal too eachother!";
}

[HttpGet]
[Route("MadLib")]
public string oohUMadLmao(){
    return "Hi!\n This Program takes a bunch of user inputs and puts it into a story!!";
}

[HttpGet]
[Route("OddOrEven")]
public string Oddest(){
    return "Hi!\nTHis program takes a user input and  lets you know whether or not its odd or even!";
}

[HttpGet]
[Route("Reverse")]
public string TurnAround(){
    return "Hi!\nthis program takes a user input of a number \n then a word\nthen it reverses them! ";
}

[HttpGet]
[Route("GuessIt")]
public string guessinggame(){
    return "Hi!\nthis program will randomly select a number and \n tell you to try and guess that number! if you dont it will ask you to try again until you get it\nit will tell you if your too high or too low";
}

[HttpGet]
[Route("RestaurantPicker")]
public string GOHere(){
    return "Hi!\nthis program will allow you to get a random restaurant!\n You will be able to select a category\n or just try totally random!!!!!\n Goodluck! :)";
}
}
