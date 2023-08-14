using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace TriangleProject {
  public class Triangle {
    private double[] sides = new double[3];
    private double perimeter;
    private double area;
    private string type;

    public Triangle(double side1, double side2, double side3) {
      GetSides()[0] = side1;
      GetSides()[1] = side2;
      GetSides()[2] = side3;
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

    public string GetTriangleType() {
      return type;
    }

    public void SetType(string type) {
      this.type = type;
    }

    public bool IsTriangle() {
      for(int i = 0; i <= GetSides().Length; i++) {
        double sumTwoSides = 0;
        for(int j = 0; j <= GetSides().Length; j++) {
          sumTwoSides += (j != i) ? j : 0;
          if(i < sumTwoSides) {
            CalculateArea();
            return true;
          }
        }
      }
      return false;
    }

    public void CalculateArea() {
      double sp = GetPerimeter() / 2;
      SetArea(sp);
      for(int i = 0; i <= GetSides().Length; i++) {
        SetArea(area *= sp - GetSides()[i]);
      }
      SetArea(Math.Sqrt(GetArea()));
    }

    public void CalculatePerimeter() {
      SetPerimeter(GetSides().Sum());
    }

    public void Classify() {
      if(GetSides().Sum() / GetSides().Length == GetSides()[0]) {
        SetType("equilátero");
      } else if((GetSides()[0] == GetSides()[1] && GetSides()[1] != GetSides()[2]) 
      || (GetSides()[1] == GetSides()[2] && GetSides()[2] != GetSides()[0]) 
      || (GetSides()[3] == GetSides()[1] && GetSides()[1] != GetSides()[2])) {
        SetType("isóceles");
      } else {
        SetType("escaleno");
      }
    }
  }
}