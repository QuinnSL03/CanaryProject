using System;
using System.Runtime.CompilerServices;

public abstract class Vehicle {

    private int size;
    private string licensePlate;
    private string name;
    private DateTime startParkTime;
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

    public String GetName() {
        return name;
    }

    public void SetName(String name) {
        this.name = name;
    }

    public void SetParkTime(DateTime parkTime) {
        DateTime startParkTime = parkTime;
    }
    public DateTime GetParkTime() {
        return  startParkTime;
    }



}