namespace TriangleStuff
{
  public class Triangle
  {
    private int SideA;
    private int SideB;
    private int SideC;
    public Triangle(int A, int B, int C)
    {
      SideA = A;
      SideB = B;
      SideC = C;
    }
    //Getters Start
    public int getA()
    {
      return this.SideA;
    }
    public int getB()
    {
      return this.SideB;
    }
    public int getC()
    {
      return this.SideC;
    }
    //Getters End

    public bool isTriangle(){
      if(this.SideA < (this.SideB+this.SideC)&&this.SideB < (this.SideC+this.SideA)&&this.SideC < (this.SideA+this.SideB)){
        return true;
      }
      return false;
    }
    public bool isEquilateral(){
      if(this.SideA == this.SideB && this.SideB == this.SideC)
      {
        return true;
      }
      return false;
    }

    public bool isIsosceles(){
      if((this.SideA == this.SideB && this.SideC != this.SideA)||(this.SideB == this.SideC && this.SideA != this.SideB)||(this.SideC == this.SideA && this.SideB != this.SideC)){
        return true;
      }
      return false;
    }
    public bool isScalene(){
      if((this.SideA != this.SideB) && (this.SideB != this.SideC) && (this.SideC != this.SideA))
      {
        return true;
      }
      return false;
    }
  }
}