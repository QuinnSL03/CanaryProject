using System;

public abstract class Vehicle {

    private int size = 0;
    private string licensePlate = "";
    public Vehicle() {

    }
    public void SetSize(int size) {
        this.size = size;
    }
    public int GetSize() {
        return size;
    }
    public void SetLicensePlate(string licensePlate) {
        this.licensePlate = licensePlate;
    }
    public string GetLicensePlate(string licensePlate) {
        return licensePlate;
    }


}