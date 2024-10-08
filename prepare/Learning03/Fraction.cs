using System;

public class Fraction
{
 private int _topNumber;
 private int _bottomNumber;

 public Fraction ()
 {
  // 1/1
  _topNumber = 1;
  _bottomNumber = 1;
 }

 public Fraction (int wholeNumber)
 {
  // 5
  _topNumber = wholeNumber;
  _bottomNumber = 1;
 }
 public Fraction (int topNumber, int bottomNumber)
 {
  //3, 4
  _topNumber = topNumber;
  _bottomNumber = bottomNumber;
 }
 public string GetFractionString()
 {
  string text = $"{_topNumber}/{_bottomNumber}";
  return text;
 }

 public double GetDecimalValue()
 {
  return (double) _topNumber / (double) _bottomNumber;
 }



}