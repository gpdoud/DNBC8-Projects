package com.maxtrain.bootcamp.dotnet.dnbc8;

public abstract class Account implements IAccount {
	
	private static int nextId = 1;
	private int id;
	private String description;
	private double balance;
	
	public void print() {
		System.out.println(this.toString());
	}
	private boolean isAmountGtZero(double amount) {
		return amount > 0;
	}
	private boolean isSufficientFunds(double amount) {
		return balance >= amount;
	}
	public boolean deposit(double amount) {
		if(!isAmountGtZero(amount))
			return false;
		balance += amount;
		return true;
	}
	public boolean withdraw(double amount) {
		if(!isSufficientFunds(amount) || !isAmountGtZero(amount))
			return false;
		balance -= amount;
		return true;
	}
	public boolean transfer(double amount, Account toAccount) {
		boolean success = withdraw(amount);
		if(!success) {
			return false;
		}
		toAccount.deposit(amount);
		return true;
	}
	@Override
	public String toString() {
		return String.format("%02d/%-17s/%-9.2f", getId(), getDescription(), getBalance());
	}
	public Account(String description) {
		setId(nextId++);
		setDescription(description + " " + nextId);
		setBalance(0);
	}
	public Account() {
		this("New Account");
	}
	/*
	// getters & setters
	*/
	public int getId() {
		return id;
	}
	protected void setId(int id) {
		this.id = id;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public double getBalance() {
		return balance;
	}
	protected void setBalance(double balance) {
		this.balance = balance;
	} 
}
