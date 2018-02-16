package com;
import java.util.ArrayList;
public class EmployeeManager {
	static ArrayList<Employee> List = new ArrayList<Employee>();
	boolean addEmployee(Employee a)
	{
		boolean check=false;
		for(int i=0;i<List.size()-1;i++)
		{
			if(List.get(i).getempId()==a.getempId())
			{
				check=true;
				break;
			}
		}
		if(check==false)
		{
			List.add(a);	
		}
		
			return check;
		}
	public static void main(String[] args) {
		Employee e1=new Employee("a","sam",22,25000.00);
		Employee e2=new Employee("b","mam",23,25000.00);
		Employee e3=new Employee("c","pam",24,25000.00);
		EmployeeManager em=new EmployeeManager();
		em.addEmployee(e1);
		em.addEmployee(e2);
		em.addEmployee(e3);
		for(int i=0;i<List.size();i++)
		{	Employee e=List.get(i);
			System.out.println("Id: "+e.getempId()+" Name: "+e.getname()+" Age: "+e.getage()+" Basicpay: "+e.getbasicpay());
		}

}
	
}
