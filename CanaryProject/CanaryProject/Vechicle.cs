using System;
using System.Runtime.CompilerServices;

public abstract class Vehicle {

    private int size;
    private string licensePlate;
    private string name;
    private int vehicleType;
 
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
    public string GetLicensePlate() {
        if(licensePlate == null) {
            return "N/A";
        }
        return licensePlate;
    }

    public String GetName() {
        return name;
    }

    public void SetName(String name) {
        this.name = name;
    }
    public int GetType() {
        return vehicleType;
    }

    public void SetType(int vehicleType) {
        this.vehicleType = vehicleType;
    }



}