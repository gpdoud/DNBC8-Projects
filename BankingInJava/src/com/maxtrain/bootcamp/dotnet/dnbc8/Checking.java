package com.maxtrain.bootcamp.dotnet.dnbc8;

public class Checking implements IAccount {
	
	private InterestAccount intacct;
	
	public void print() {
		System.out.println(intacct.toString());
	}
	public boolean deposit(double amount) {
		return intacct.deposit(amount);
	}
	public boolean withdraw(double amount) {
		return intacct.withdraw(amount);
	}
	public boolean transfer(double amount, Account toAccount) {
		return intacct.transfer(amount, toAccount);
	}
	public Checking(double intRate, String description) {
		intacct = new InterestAccount(intRate, description);
	}
	public Checking(double intRate) {
		this(intRate, "Checking");
	}
	public Checking() {
		this(1.0);
	}
	@Override
	public String toString() {
		return String.format("%02d/%-17s/%-9.2f", getId(), getDescription(), getBalance());

	}
	public int getId() { 
		return intacct.getId(); 
	}
	public String getDescription() { 
		return intacct.getDescription(); 
	}
	public void setDescription(String description) { 
		intacct.setDescription(description);
	}
	public double getBalance() { 
		return intacct.getBalance(); 
	}
}
