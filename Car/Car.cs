public class Car
{
    // Miembros de la clase
    private string color;
    private string brand;
    private string model;
    private int doors;
    private string fuel;

   

    // Constructor con parámetros
    public Car(string color, string brand, string model, int doors, string fuel)
    {
        this.color = color;
        this.brand = brand;
        this.model = model;
        this.doors = doors;
        this.fuel = fuel;
    }

    // Getters and setters

    public string getColor()
    {
        return this.color;
    }
    public void setColor(string color)
    {
        this.color = color;
    }

    public string getBrand()
    {
        return this.brand;
    }
    public void setBrand(string brand)
    {
        this.brand = brand;
    }

    public string getModel()
    {
        return this.model;
    }
    public void setModel(string model)
    {
        this.model = model;
    }

    public int getDoors()
    {
        return this.doors;
    }
    public void setDoors(int doors)
    {
        this.doors = doors;
    }

    public string getFuel()
    {
        return this.fuel;
    }
    public void setFuel(string fuel)
    {
        this.fuel = fuel;
    }

    // To string
    public override string ToString()
    {
        return this.brand + ", " + this.model + ", " + this.doors + 
            ", " + this.color + ", " + this.fuel; 
    }
}