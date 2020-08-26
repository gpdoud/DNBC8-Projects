package com.maxtrain.bootcamp.dotnet;

import java.util.ArrayList;

public class CustomerTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Customer customer = new Customer("MAX Technical Training", true, 0);
		customer.setId(1);
		
		System.out.println(customer.getName() + ", sales total is " 
							+ customer.getSales());
		
		try {
			customer.addSales(1000);
		} catch (ArithmeticException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println(customer.getName() + ", sales total is " 
							+ customer.getSales());
		
		try {
			customer.addSales(-1000);
		} catch (ArithmeticException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println(customer.getName() + ", sales total is " 
							+ customer.getSales());
		
		ArrayList<Customer> customers = new ArrayList<Customer>();
		customers.add(customer);
		
		Customer customer2 = new Customer("Cust2", true);
		Customer customer3 = new Customer("Cust3");
		customers.add(customer2);
		customers.add(customer3);
		
		for(Customer c : customers) {
			String message = String.format("%d/%s/%f", c.getId(), c.getName(), c.getSales());
			System.out.println(message);
		}
	}

}
