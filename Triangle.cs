using System;
using System.Linq;

namespace TriangleProject {
  public class Triangle {
    private double[] sides = new double[3];
    private double perimeter;
    private double area;
    private string classification;

    public Triangle(double side1, double side2, double side3) {
      double[] newSides = {side1, side2, side3};
      SetSides(newSides);
      CalculatePerimeter();
    }

    public double[] GetSides() {
      return sides;
    }

    public void SetSides(double[] sides) {
      this.sides = sides;
    }

    public double GetPerimeter() {
      return perimeter;
    }

    public void SetPerimeter(double perimeter) {
      this.perimeter = perimeter;
    }

    public double GetArea() {
      return area;
    }

    public void SetArea(double area) {
      this.area = area;
    }

    public string GetClassification() {
      return classification;
    }

    public void SetClassification(string classification) {
      this.classification = classification;
    }

    public bool IsTriangle() {
      for(int i = 0; i < GetSides().Length; i++) {
        double sumTwoSides = 0;
        for(int j = 0; j < GetSides().Length; j++) {
          sumTwoSides += (j != i) ? GetSides()[j] : 0;
        }
        if(GetSides()[i] > sumTwoSides) {
          return false;
        }
      }
      CalculateArea();
      return true;
    }

    public void CalculateArea() {
      double sp = GetPerimeter() / 2;
      double calculatingArea = sp;
      for(int i = 0; i < GetSides().Length; i++) {
        calculatingArea *= sp - GetSides()[i];
      }
      SetArea(Math.Sqrt(calculatingArea));
    }

    public void CalculatePerimeter() {
      SetPerimeter(GetSides().Sum());
    }

    public void Classify() {
      if(GetSides().Sum() / GetSides().Length == GetSides()[0]) {
        SetClassification("equilátero");
      } else if((GetSides()[0] == GetSides()[1] && GetSides()[1] != GetSides()[2]) 
      || (GetSides()[1] == GetSides()[2] && GetSides()[2] != GetSides()[0]) 
      || (GetSides()[2] == GetSides()[0] && GetSides()[0] != GetSides()[1])) {
        SetClassification("isóceles");
      } else {
        SetClassification("escaleno");
      }
    }
  }
}