using System;
using System.Collections.Generic;

namespace Parcels.Models
{
public class anotherparcel
{
  private int _width;
  private int _height;
  private int _weight;

  public void setParcel (int width, int height, int weight){
    _width = width;
    _height = height;
    _weight = weight;
  }
  public int calculatePrice(){
    int price = _width * _height + _weight;
    return price;
  }
}
}
