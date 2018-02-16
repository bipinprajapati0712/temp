package com;

public class Employee {

	String empId;
	String name;
	int age;
	double basicpay;
	Employee(String empId,String name,int age,double basicpay)
	{
		this.empId=empId;
		this.name=name;
		this.age=age;
		this.basicpay=basicpay;
	}
	public void setempId(String empId)
	{
		this.empId=empId;
	}
	public String getempId()
	{
		return empId;
	}
	public void setname(String name)
	{
		this.name=name;
	}
	public String getname()
	{
		return name;
	}
	public void setage(int age)
	{
		this.age=age;
	}
	public int getage()
	{
		return age;
	}
	public void setbasicpay(double basicpay)
	{
		this.basicpay=basicpay;
	}
	public double getbasicpay()
	{
		return basicpay;
	}

}



