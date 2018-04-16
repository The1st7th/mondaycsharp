using System;
using System.Collections.Generic;

namespace vacation.Models
{
public class Local
{
  private string _recipient;
  private string _sender;
  public Dictionary<String,String> localFood = new Dictionary<string, string>() {};

  public string GetRecipient()
  {
    return _recipient;
  }

  public void SetRecipient(string newRecipient)
  {
    _recipient = newRecipient;
  }

  public string GetSender()
  {
    return _sender;
  }

  public void SetSender(string newSender)
  {
    _sender = newSender;
  }
  public void setLocalFood(string location, string food){
    localFood.Add(location, food);
  }

}

}
