package com.maxtrain.bootcamp.dotnet.dnbc8;

public interface IAccount {
	int getId();
	String getDescription();
	double getBalance();
	boolean deposit(double amount);
	boolean withdraw(double amount);
	boolean transfer(double amount, Account toAccount);
}
