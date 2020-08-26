package com.maxtrain.bootcamp.dotnet.dnbc8;

class InterestAccount extends Account {

	private double intRate;
	
	public void print() {
		System.out.println(this.toString());
	}

	public InterestAccount(double intRate, String description) {
		super(description);
		this.setIntRate(intRate);
	}
	
	public InterestAccount(double intRate) {
		this(intRate, "New InterestAccount");
	}
	
	public InterestAccount() {
		this(1.0);
	}

	public double getIntRate() {
		return intRate;
	}
	public void setIntRate(double intRate) {
		this.intRate = intRate;
	}

}
