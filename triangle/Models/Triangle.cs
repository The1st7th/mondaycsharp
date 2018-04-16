using System;
using System.Collections.Generic;

namespace Triangles.Models
{
public class Triangle
{
  private int _sideA;
  private int _sideB;
  private int _sideC;
  private string _message;

  public void setTriangle (int sideA, int sideB, int sideC){
    _sideA = sideA;
    _sideB = sideB;
    _sideC = sideC;
  }
  public void setmessage(){
    if ( _sideA == _sideB && _sideC == _sideB  && _sideA == _sideC  ){
      _message = "equilateral triangle";
    }
    if ( (_sideA == _sideB && _sideA != _sideC && _sideB != _sideC) || (_sideB == _sideC && _sideB != _sideA && _sideA != _sideC) || (_sideC == _sideA && _sideC != _sideB && _sideA != _sideB)) {
      _message = "isoceles triangle";
    }
    if ( _sideA != _sideB && _sideA!= _sideC && _sideB != _sideC){
      _message = "scalene triangle";
    }
    if ( (_sideA > _sideB + _sideC)||(_sideB > _sideA + _sideC)||(_sideC > _sideA + _sideB)){
      _message = "it is not a triangle";
    }
  }
  public string getmessage(){
    return _message;
  }
}
}
