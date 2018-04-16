using System;
using System.Collections.Generic;

public class Car
{
  private string _model;
  private int _price;
  private string _message;

  public void setmodel( string model){
    _model = model;

  }
  public void setprice(int price){
    _price = price;

  }
  public string getmodel(){
    return _model;

  }
  public int getprice (){
    return _price;

  }
  public void setmessage(string message){
    _message = message;


  }
  public string getmessage (){
    return _message;

  }
}
public class Program
{
  public static void Main()
  {
    Car car1 = new Car ();
    car1.setmodel("volvo");
    car1.setprice(10);
    car1.setmessage("this car sucks");
    Car car2 = new Car ();
    car2.setmodel("mercedes");
    car2.setprice(20);
    car2.setmessage("this car super sucks");
    Car car3 = new Car ();
    car3.setmodel("ferrari");
    car3.setprice(30);
    car3.setmessage("this car amazingly utterly sucks");
    List<Car> dealer = new List<Car> {car1,car2,car3};

    int pricemax = int.Parse(Console.ReadLine());

    foreach (Car car in dealer){
      if (car.getprice() < pricemax){
        Console.WriteLine ("the car model is"+ car.getmodel());
        Console.WriteLine ("the price is "+ car.getprice());
        Console.WriteLine ("about this car: " + car.getmessage());
      }
    }


  }
}
