package com.maxtrain.bootcamp.dotnet.dnbc8;

public class Savings extends InterestAccount implements IAccount {
	
	public Savings(double intRate, String description) {
		super(intRate, description);
	}
	public Savings(String description) {
		this(1.0, description);
	}
	public Savings() {
		this("Savings");
	}

}
