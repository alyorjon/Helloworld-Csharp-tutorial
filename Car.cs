using System;
namespace HELLOWORLD
{
    public class Car
{
    private string brand;
    private string model;
    private int year;
    private decimal price;
    
    // 1. Default constructor
    public Car()
    {
        brand = "Noma'lum";
        model = "Noma'lum";
        year = 2020;
        price = 0;
    }
    
    // 2. Parametrli constructor
    public Car(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
        this.year = DateTime.Now.Year;
        this.price = 0;
    }
    
    // 3. To'liq constructor
    public Car(string brand, string model, int year, decimal price)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.price = price;
    }
    public string Model
        {
            get { return model; }
            set { model = value; }    
    }
    // 4. Constructor chaining (this bilan)
    public Car(string brand, string model, int year) : this(brand, model, year, 0)
        {
            // Bu constructor yuqoridagi to'liq constructorni chaqiradi
        }
}
}